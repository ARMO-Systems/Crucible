using System;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Windows.Forms;
using AutocompleteMenuNS;
using Crucible.Properties;
using Crucible.XPO;
using DevExpress.LookAndFeel;
using DevExpress.Xpo;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace Crucible
{
    internal sealed partial class MainForm : XtraForm
    {
        private readonly XPCollection< ReviewXPO > allReviews;
        private readonly CSharpFilterReview filter = new CSharpFilterReview();

        private readonly IDisposable memoCodeObservable;
        private readonly UnitOfWork uow;
        private XPCollection< CriteriaXPO > criterias;

        public MainForm()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery( rgbiSkins, true );
            uow = new UnitOfWork { LockingOption = LockingOption.None };
            CreateCriterias();

            gridControl1.DataSource = criterias;
            allReviews = new XPCollection< ReviewXPO >( uow );
            gridControlReviews.DataSource = allReviews;
            InitReviewChanges();

            timerRefreshData.Tick += ( o, e ) => DownloadReviews( false );
            timerHour.Tick += ( o, e ) => DownloadReviews();
            iFind.ItemClick += ( sender, args ) => DownloadReviews();
            CheckFiltr.ItemClick += ( sender, args ) => DownloadReviews( false );
            notifyIcon.Click += ( o, e ) => Restore();
            notifyIcon.BalloonTipClicked += ( o, e ) => Restore();
            tabbedControlGroup1.SelectedTabPageIndex = 0;
            UserLookAndFeel.Default.SkinName = Settings.Default.SkinName;
            memoCodeObservable =
                Observable.FromEventPattern< EventArgs >( richTextBox1, "TextChanged" ).
                    Select( ev => new { richTextBox1.Text, Position = richTextBox1.SelectionStart } ).
                    DistinctUntilChanged().
                    Where( item => item.Position != 0 ).
                    Select( item => item.Text.Substring( 0, item.Position ) ).
                    ObserveOn( SynchronizationContext.Current ).
                    Subscribe( OnCodeChanged );
            DownloadReviews();
        }

        private string ServerURL
        {
            get { return string.Format( "http://{0}/cru/", textEditServer.Text ); }
        }

        private ReviewXPO FocusedReview
        {
            get { return gridViewReviews.GetFocusedRow() as ReviewXPO; }
        }

        private CriteriaXPO FocusedCriteria
        {
            get { return gridView1.GetFocusedRow() as CriteriaXPO; }
        }

        private void CreateCriterias()
        {
            criterias = new XPCollection< CriteriaXPO >( uow );
            if ( criterias.Count != 0 )
                return;

            criterias.Add( new CriteriaXPO( uow )
            {
                Name = "Обновленные ревью",
                Criteria =
                    "( ( ( review.Reviewers.Any( item => item.User.UserName == \"adp\" && !item.Completed ) || review.Author.UserName == \"adp\" ) && review.Changes.First( item => item.ChangeTime == review.LastChangeTime ).User.UserName != \"adp\" ) || ( review.Author.UserName == \"adp\" && review.Reviewers.All( item => item.Completed ) ) ) && review.State == state.Review"
            } );

            criterias.Add( new CriteriaXPO( uow ) { Name = "Без фильтра" } );
            criterias.Add( new CriteriaXPO( uow )
            {
                Name = "Мои ревью",
                Criteria = "review.Reviewers.Any( item => item.User.UserName == \"adp\" && !item.Completed ) && !review.Reviewers.Any( item => item.User.UserName != \"adp\" && !item.Completed ) && review.State == state.Review"
            } );
            criterias.Add( new CriteriaXPO( uow ) { Name = "Все на ревью", Criteria = "review.Reviewers.Any( item => !item.Completed ) && review.State == state.Review" } );
            criterias.Add( new CriteriaXPO( uow ) { Name = "Мертвые", Criteria = "review.State != state.Review && review.State != state.Closed" } );
            uow.CommitChanges();
        }

        private void OnCodeChanged( string text )
        {
            SetFilterAndCheckErrors();

            if ( text.Last() != '.' )
                return;

            autocompleteMenu1.SetAutocompleteItems( filter.GetSymbols( text ).Select( item => new MethodAutocompleteItem( item ) { ImageIndex = item.Last() == ')' ? 1 : 0 } ) );
        }

        private void SetUserMessage( string message )
        {
            siStatus.Caption = message;
            notifyIcon.Text = message.Substring( 0, Math.Min( 63, message.Length ) );
        }

        private async void DownloadReviews( bool ids = true )
        {
            SetUserMessage( Resources.RefreshData );

            try
            {
                timerRefreshData.Stop();
                await CrucibleParser.GetDataFromCrucibleAsync( textEditServer.Text, textEditUserName.Text, textEditPassword.Text, ids );
                allReviews.Reload();
                foreach ( var review in allReviews )
                {
                    review.Reload();
                    review.Reviewers.Reload();
                    review.Changes.Reload();
                    foreach ( var reviewer in review.Reviewers )
                        reviewer.Reload();
                }
                gridControlReviews.DataSource = allReviews;
                InitReviewChanges();
                UpdateReviewByFilter();
                SetUserMessage( string.Format( "Время последнего обновления: {0}", DateTime.Now.ToLongTimeString() ) );
                timerRefreshData.Start();
            }
            catch ( Exception ex )
            {
                SetUserMessage( ex.Message );
            }
        }

        private void InitReviewChanges()
        {
            gridControlReviewChanges.DataSource = FocusedReview != null ? FocusedReview.Changes : null;
        }

        private void gridView1_FocusedRowChanged( object sender, FocusedRowChangedEventArgs e )
        {
            InitReviewChanges();
        }

        private void gridViewReviews_DoubleClick( object sender, EventArgs e )
        {
            if ( FocusedReview == null )
                return;

            Process.Start( string.Format( "{0}{1}", ServerURL, FocusedReview.ID ) );
        }

        private void MainForm_Resize( object sender, EventArgs e )
        {
            if ( WindowState == FormWindowState.Minimized )
                Hide();
        }

        private void Restore()
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void iExit_ItemClick( object sender, ItemClickEventArgs e )
        {
            Settings.Default.SkinName = UserLookAndFeel.Default.SkinName;
            Settings.Default.Save();
            uow.CommitChanges();
            Application.Exit();
        }

        private void MainForm_FormClosing( object sender, FormClosingEventArgs e )
        {
            if ( e.CloseReason != CloseReason.UserClosing )
                return;

            memoCodeObservable.Dispose();
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
        }

        private void gridViewReviewChanges_DoubleClick( object sender, EventArgs e )
        {
            if ( FocusedReview == null )
                return;

            var reviewChangeItem = gridViewReviewChanges.GetFocusedRow() as ReviewChangeItemXPO;
            if ( reviewChangeItem == null )
                return;

            Process.Start( @"c:\Program Files (x86)\Google\Chrome\Application\chrome.exe", string.Format( "{0}{1}#{2}", ServerURL, FocusedReview.ID, reviewChangeItem.ID ) );
        }

        private void gridViewReviews_CustomRowFilter( object sender, RowFilterEventArgs e )
        {
            var review = ( ReviewXPO ) gridViewReviews.GetRow( e.ListSourceRow );
            if ( review == null )
                return;

            try
            {
                e.Visible = filter.FilterByCode( review );
                e.Handled = true;
            }
            catch ( Exception )
            {
            }
        }

        private void SetFilterAndCheckErrors()
        {
            memoEditErrors.Text = string.Empty;
            try
            {
                filter.Filter = richTextBox1.Text;
                memoEditErrors.Text = Resources.PossibleOK;
            }
            catch ( Exception ex )
            {
                memoEditErrors.Text = ex.Message;
            }
        }

        private void gridView1_FocusedRowChanged_1( object sender, FocusedRowChangedEventArgs e )
        {
            UpdateReviewByFilter();
        }

        private void UpdateReviewByFilter()
        {
            if ( FocusedCriteria == null )
                return;

            richTextBox1.Text = FocusedCriteria.Criteria;

            SetFilterAndCheckErrors();
            gridViewReviews.RefreshData();
            InitReviewChanges();
            notifyIcon.Icon = gridViewReviews.RowCount > 0 ? Resources.Shiel_red : Resources.Sheild_green;
        }

        private void iSave_ItemClick( object sender, ItemClickEventArgs e )
        {
            if ( FocusedCriteria != null )
                FocusedCriteria.Criteria = richTextBox1.Text;

            UpdateReviewByFilter();
        }
    }
}