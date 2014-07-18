using Crucible.XPO;

namespace Crucible
{
    internal sealed partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.navbarImageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.navbarImageList = new System.Windows.Forms.ImageList(this.components);
            this.gridControlReviews = new DevExpress.XtraGrid.GridControl();
            this.gridViewReviews = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAuthor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangeTime1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colCreateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReviewers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.CheckFiltr = new DevExpress.XtraBars.BarButtonItem();
            this.iOpen = new DevExpress.XtraBars.BarButtonItem();
            this.iSave = new DevExpress.XtraBars.BarButtonItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.iClose = new DevExpress.XtraBars.BarButtonItem();
            this.iFind = new DevExpress.XtraBars.BarButtonItem();
            this.iHelp = new DevExpress.XtraBars.BarButtonItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.siStatus = new DevExpress.XtraBars.BarStaticItem();
            this.siInfo = new DevExpress.XtraBars.BarStaticItem();
            this.alignButtonGroup = new DevExpress.XtraBars.BarButtonGroup();
            this.iBoldFontStyle = new DevExpress.XtraBars.BarButtonItem();
            this.iItalicFontStyle = new DevExpress.XtraBars.BarButtonItem();
            this.iUnderlinedFontStyle = new DevExpress.XtraBars.BarButtonItem();
            this.fontStyleButtonGroup = new DevExpress.XtraBars.BarButtonGroup();
            this.iLeftTextAlign = new DevExpress.XtraBars.BarButtonItem();
            this.iCenterTextAlign = new DevExpress.XtraBars.BarButtonItem();
            this.iRightTextAlign = new DevExpress.XtraBars.BarButtonItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(this.components);
            this.homeRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.fileRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.exitRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.helpRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.skinsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.helpRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControlReviewChanges = new DevExpress.XtraGrid.GridControl();
            this.gridViewReviewChanges = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colChangeTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCriteria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.memoEditErrors = new DevExpress.XtraEditors.MemoEdit();
            this.textEditServer = new DevExpress.XtraEditors.TextEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.textEditUserName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.timerRefreshData = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerHour = new System.Windows.Forms.Timer(this.components);
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReviewChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReviewChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditErrors.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarImageListLarge
            // 
            this.navbarImageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageListLarge.ImageStream")));
            this.navbarImageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageListLarge.Images.SetKeyName(0, "Mail_16x16.png");
            this.navbarImageListLarge.Images.SetKeyName(1, "Organizer_16x16.png");
            // 
            // navbarImageList
            // 
            this.navbarImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageList.ImageStream")));
            this.navbarImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageList.Images.SetKeyName(0, "Inbox_16x16.png");
            this.navbarImageList.Images.SetKeyName(1, "Outbox_16x16.png");
            this.navbarImageList.Images.SetKeyName(2, "Drafts_16x16.png");
            this.navbarImageList.Images.SetKeyName(3, "Trash_16x16.png");
            this.navbarImageList.Images.SetKeyName(4, "Calendar_16x16.png");
            this.navbarImageList.Images.SetKeyName(5, "Tasks_16x16.png");
            // 
            // gridControlReviews
            // 
            this.gridControlReviews.Location = new System.Drawing.Point(7, 29);
            this.gridControlReviews.MainView = this.gridViewReviews;
            this.gridControlReviews.Name = "gridControlReviews";
            this.gridControlReviews.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit2});
            this.gridControlReviews.ShowOnlyPredefinedDetails = true;
            this.gridControlReviews.Size = new System.Drawing.Size(1013, 270);
            this.gridControlReviews.TabIndex = 0;
            this.gridControlReviews.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReviews});
            // 
            // gridViewReviews
            // 
            this.gridViewReviews.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridViewReviews.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAuthor,
            this.colState,
            this.colChangeTime1,
            this.colCreateTime,
            this.colID1,
            this.colName,
            this.colReviewers});
            this.gridViewReviews.GridControl = this.gridControlReviews;
            this.gridViewReviews.Name = "gridViewReviews";
            this.gridViewReviews.OptionsBehavior.Editable = false;
            this.gridViewReviews.OptionsCustomization.AllowGroup = false;
            this.gridViewReviews.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewReviews.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewReviews.OptionsView.ShowAutoFilterRow = true;
            this.gridViewReviews.OptionsView.ShowGroupPanel = false;
            this.gridViewReviews.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colChangeTime1, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewReviews.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridViewReviews.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.gridViewReviews_CustomRowFilter);
            this.gridViewReviews.DoubleClick += new System.EventHandler(this.gridViewReviews_DoubleClick);
            // 
            // colAuthor
            // 
            this.colAuthor.Caption = "Автор";
            this.colAuthor.FieldName = "Author.UserName";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.Visible = true;
            this.colAuthor.VisibleIndex = 3;
            this.colAuthor.Width = 91;
            // 
            // colState
            // 
            this.colState.Caption = "Состояние";
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 4;
            this.colState.Width = 91;
            // 
            // colChangeTime1
            // 
            this.colChangeTime1.Caption = "Последнее изменение";
            this.colChangeTime1.ColumnEdit = this.repositoryItemDateEdit2;
            this.colChangeTime1.FieldName = "LastChangeTime";
            this.colChangeTime1.Name = "colChangeTime1";
            this.colChangeTime1.Visible = true;
            this.colChangeTime1.VisibleIndex = 0;
            this.colChangeTime1.Width = 149;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Mask.EditMask = "g";
            this.repositoryItemDateEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            this.repositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colCreateTime
            // 
            this.colCreateTime.Caption = "Время создания";
            this.colCreateTime.ColumnEdit = this.repositoryItemDateEdit2;
            this.colCreateTime.FieldName = "CreateTime";
            this.colCreateTime.Name = "colCreateTime";
            this.colCreateTime.Visible = true;
            this.colCreateTime.VisibleIndex = 5;
            this.colCreateTime.Width = 189;
            // 
            // colID1
            // 
            this.colID1.Caption = "ID";
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 2;
            this.colID1.Width = 86;
            // 
            // colName
            // 
            this.colName.Caption = "Название";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 604;
            // 
            // colReviewers
            // 
            this.colReviewers.Caption = "Ревьюверы";
            this.colReviewers.FieldName = "Reviewers";
            this.colReviewers.Name = "colReviewers";
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.appMenu;
            this.ribbonControl.ApplicationButtonText = null;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.ExpandCollapseItem.Name = "";
            this.ribbonControl.Images = this.ribbonImageCollection;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.CheckFiltr,
            this.iOpen,
            this.iClose,
            this.iFind,
            this.iSave,
            this.iExit,
            this.iHelp,
            this.iAbout,
            this.siStatus,
            this.siInfo,
            this.alignButtonGroup,
            this.iBoldFontStyle,
            this.iItalicFontStyle,
            this.iUnderlinedFontStyle,
            this.fontStyleButtonGroup,
            this.iLeftTextAlign,
            this.iCenterTextAlign,
            this.iRightTextAlign,
            this.rgbiSkins});
            this.ribbonControl.LargeImages = this.ribbonImageCollectionLarge;
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 63;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.iAbout);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homeRibbonPage,
            this.helpRibbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl.Size = new System.Drawing.Size(1586, 117);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.Toolbar.ItemLinks.Add(this.CheckFiltr);
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iOpen);
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iSave);
            this.ribbonControl.Toolbar.ItemLinks.Add(this.iHelp);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // appMenu
            // 
            this.appMenu.ItemLinks.Add(this.CheckFiltr);
            this.appMenu.ItemLinks.Add(this.iOpen);
            this.appMenu.ItemLinks.Add(this.iSave);
            this.appMenu.ItemLinks.Add(this.iExit);
            this.appMenu.Name = "appMenu";
            this.appMenu.Ribbon = this.ribbonControl;
            this.appMenu.ShowRightPane = true;
            // 
            // CheckFiltr
            // 
            this.CheckFiltr.Caption = "Обновить текущие";
            this.CheckFiltr.Description = "Creates a new, blank file.";
            this.CheckFiltr.Hint = "Creates a new, blank file";
            this.CheckFiltr.Id = 1;
            this.CheckFiltr.ImageIndex = 0;
            this.CheckFiltr.LargeImageIndex = 0;
            this.CheckFiltr.Name = "CheckFiltr";
            // 
            // iOpen
            // 
            this.iOpen.Caption = "&Open";
            this.iOpen.Description = "Opens a file.";
            this.iOpen.Hint = "Opens a file";
            this.iOpen.Id = 2;
            this.iOpen.ImageIndex = 1;
            this.iOpen.LargeImageIndex = 1;
            this.iOpen.Name = "iOpen";
            this.iOpen.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // iSave
            // 
            this.iSave.Caption = "Сохранить и применить";
            this.iSave.Description = "Saves the active document.";
            this.iSave.Hint = "Saves the active document";
            this.iSave.Id = 16;
            this.iSave.ImageIndex = 4;
            this.iSave.LargeImageIndex = 4;
            this.iSave.Name = "iSave";
            this.iSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iSave_ItemClick);
            // 
            // iExit
            // 
            this.iExit.Caption = "Выход";
            this.iExit.Description = "Closes this program after prompting you to save unsaved data.";
            this.iExit.Hint = "Closes this program after prompting you to save unsaved data";
            this.iExit.Id = 20;
            this.iExit.ImageIndex = 6;
            this.iExit.LargeImageIndex = 6;
            this.iExit.Name = "iExit";
            this.iExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iExit_ItemClick);
            // 
            // ribbonImageCollection
            // 
            this.ribbonImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollection.ImageStream")));
            this.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png");
            this.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png");
            // 
            // iClose
            // 
            this.iClose.Caption = "&Close";
            this.iClose.Description = "Closes the active document.";
            this.iClose.Hint = "Closes the active document";
            this.iClose.Id = 3;
            this.iClose.ImageIndex = 2;
            this.iClose.LargeImageIndex = 2;
            this.iClose.Name = "iClose";
            this.iClose.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // iFind
            // 
            this.iFind.Caption = "Обновить все";
            this.iFind.Description = "Searches for the specified info.";
            this.iFind.Hint = "Searches for the specified info";
            this.iFind.Id = 15;
            this.iFind.ImageIndex = 3;
            this.iFind.LargeImageIndex = 3;
            this.iFind.Name = "iFind";
            this.iFind.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // iHelp
            // 
            this.iHelp.Caption = "Help";
            this.iHelp.Description = "Start the program help system.";
            this.iHelp.Hint = "Start the program help system";
            this.iHelp.Id = 22;
            this.iHelp.ImageIndex = 7;
            this.iHelp.LargeImageIndex = 7;
            this.iHelp.Name = "iHelp";
            // 
            // iAbout
            // 
            this.iAbout.Caption = "About";
            this.iAbout.Description = "Displays general program information.";
            this.iAbout.Hint = "Displays general program information";
            this.iAbout.Id = 24;
            this.iAbout.ImageIndex = 8;
            this.iAbout.LargeImageIndex = 8;
            this.iAbout.Name = "iAbout";
            // 
            // siStatus
            // 
            this.siStatus.Caption = "Some Status Info";
            this.siStatus.Id = 31;
            this.siStatus.Name = "siStatus";
            this.siStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // siInfo
            // 
            this.siInfo.Id = 32;
            this.siInfo.Name = "siInfo";
            this.siInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // alignButtonGroup
            // 
            this.alignButtonGroup.Caption = "Align Commands";
            this.alignButtonGroup.Id = 52;
            this.alignButtonGroup.ItemLinks.Add(this.iBoldFontStyle);
            this.alignButtonGroup.ItemLinks.Add(this.iItalicFontStyle);
            this.alignButtonGroup.ItemLinks.Add(this.iUnderlinedFontStyle);
            this.alignButtonGroup.Name = "alignButtonGroup";
            // 
            // iBoldFontStyle
            // 
            this.iBoldFontStyle.Caption = "Bold";
            this.iBoldFontStyle.Id = 53;
            this.iBoldFontStyle.ImageIndex = 9;
            this.iBoldFontStyle.Name = "iBoldFontStyle";
            // 
            // iItalicFontStyle
            // 
            this.iItalicFontStyle.Caption = "Italic";
            this.iItalicFontStyle.Id = 54;
            this.iItalicFontStyle.ImageIndex = 10;
            this.iItalicFontStyle.Name = "iItalicFontStyle";
            // 
            // iUnderlinedFontStyle
            // 
            this.iUnderlinedFontStyle.Caption = "Underlined";
            this.iUnderlinedFontStyle.Id = 55;
            this.iUnderlinedFontStyle.ImageIndex = 11;
            this.iUnderlinedFontStyle.Name = "iUnderlinedFontStyle";
            // 
            // fontStyleButtonGroup
            // 
            this.fontStyleButtonGroup.Caption = "Font Style";
            this.fontStyleButtonGroup.Id = 56;
            this.fontStyleButtonGroup.ItemLinks.Add(this.iLeftTextAlign);
            this.fontStyleButtonGroup.ItemLinks.Add(this.iCenterTextAlign);
            this.fontStyleButtonGroup.ItemLinks.Add(this.iRightTextAlign);
            this.fontStyleButtonGroup.Name = "fontStyleButtonGroup";
            // 
            // iLeftTextAlign
            // 
            this.iLeftTextAlign.Caption = "Left";
            this.iLeftTextAlign.Id = 57;
            this.iLeftTextAlign.ImageIndex = 12;
            this.iLeftTextAlign.Name = "iLeftTextAlign";
            // 
            // iCenterTextAlign
            // 
            this.iCenterTextAlign.Caption = "Center";
            this.iCenterTextAlign.Id = 58;
            this.iCenterTextAlign.ImageIndex = 13;
            this.iCenterTextAlign.Name = "iCenterTextAlign";
            // 
            // iRightTextAlign
            // 
            this.iRightTextAlign.Caption = "Right";
            this.iRightTextAlign.Id = 59;
            this.iRightTextAlign.ImageIndex = 14;
            this.iRightTextAlign.Name = "iRightTextAlign";
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "Skins";
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Gallery.AllowHoverImages = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.ColumnCount = 4;
            this.rgbiSkins.Gallery.FixedHoverImageSize = false;
            this.rgbiSkins.Gallery.ImageSize = new System.Drawing.Size(32, 17);
            this.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
            this.rgbiSkins.Gallery.RowCount = 4;
            this.rgbiSkins.Id = 60;
            this.rgbiSkins.Name = "rgbiSkins";
            // 
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png");
            // 
            // homeRibbonPage
            // 
            this.homeRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.fileRibbonPageGroup,
            this.exitRibbonPageGroup,
            this.ribbonPageGroup1});
            this.homeRibbonPage.Name = "homeRibbonPage";
            this.homeRibbonPage.Text = "Home";
            // 
            // fileRibbonPageGroup
            // 
            this.fileRibbonPageGroup.AllowMinimize = false;
            this.fileRibbonPageGroup.AllowTextClipping = false;
            this.fileRibbonPageGroup.ItemLinks.Add(this.iFind);
            this.fileRibbonPageGroup.ItemLinks.Add(this.CheckFiltr);
            this.fileRibbonPageGroup.Name = "fileRibbonPageGroup";
            this.fileRibbonPageGroup.ShowCaptionButton = false;
            this.fileRibbonPageGroup.Text = "Репозиторий";
            // 
            // exitRibbonPageGroup
            // 
            this.exitRibbonPageGroup.AllowMinimize = false;
            this.exitRibbonPageGroup.AllowTextClipping = false;
            this.exitRibbonPageGroup.ItemLinks.Add(this.iExit);
            this.exitRibbonPageGroup.Name = "exitRibbonPageGroup";
            this.exitRibbonPageGroup.ShowCaptionButton = false;
            this.exitRibbonPageGroup.Text = "Программа";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.iSave);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Фильтры";
            // 
            // helpRibbonPage
            // 
            this.helpRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.skinsRibbonPageGroup,
            this.helpRibbonPageGroup});
            this.helpRibbonPage.Name = "helpRibbonPage";
            this.helpRibbonPage.Text = "Help";
            // 
            // skinsRibbonPageGroup
            // 
            this.skinsRibbonPageGroup.ItemLinks.Add(this.rgbiSkins);
            this.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup";
            this.skinsRibbonPageGroup.ShowCaptionButton = false;
            this.skinsRibbonPageGroup.Text = "Skins";
            // 
            // helpRibbonPageGroup
            // 
            this.helpRibbonPageGroup.ItemLinks.Add(this.iHelp);
            this.helpRibbonPageGroup.ItemLinks.Add(this.iAbout);
            this.helpRibbonPageGroup.Name = "helpRibbonPageGroup";
            this.helpRibbonPageGroup.Text = "Help";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.siStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.siInfo);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 704);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1586, 27);
            // 
            // gridControlReviewChanges
            // 
            this.gridControlReviewChanges.Location = new System.Drawing.Point(7, 303);
            this.gridControlReviewChanges.MainView = this.gridViewReviewChanges;
            this.gridControlReviewChanges.MenuManager = this.ribbonControl;
            this.gridControlReviewChanges.Name = "gridControlReviewChanges";
            this.gridControlReviewChanges.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemMemoEdit1});
            this.gridControlReviewChanges.ShowOnlyPredefinedDetails = true;
            this.gridControlReviewChanges.Size = new System.Drawing.Size(1013, 277);
            this.gridControlReviewChanges.TabIndex = 7;
            this.gridControlReviewChanges.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReviewChanges});
            // 
            // gridViewReviewChanges
            // 
            this.gridViewReviewChanges.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUser,
            this.colComment,
            this.colChangeTime,
            this.colID});
            this.gridViewReviewChanges.GridControl = this.gridControlReviewChanges;
            this.gridViewReviewChanges.Name = "gridViewReviewChanges";
            this.gridViewReviewChanges.OptionsBehavior.Editable = false;
            this.gridViewReviewChanges.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewReviewChanges.OptionsDetail.ShowDetailTabs = false;
            this.gridViewReviewChanges.OptionsView.RowAutoHeight = true;
            this.gridViewReviewChanges.OptionsView.ShowDetailButtons = false;
            this.gridViewReviewChanges.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colChangeTime, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewReviewChanges.DoubleClick += new System.EventHandler(this.gridViewReviewChanges_DoubleClick);
            // 
            // colUser
            // 
            this.colUser.Caption = "Пользователь";
            this.colUser.FieldName = "User.UserName";
            this.colUser.Name = "colUser";
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 1;
            this.colUser.Width = 110;
            // 
            // colComment
            // 
            this.colComment.Caption = "Комментарий";
            this.colComment.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colComment.FieldName = "Comment";
            this.colComment.Name = "colComment";
            this.colComment.Visible = true;
            this.colComment.VisibleIndex = 2;
            this.colComment.Width = 581;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colChangeTime
            // 
            this.colChangeTime.Caption = "Время изменения";
            this.colChangeTime.ColumnEdit = this.repositoryItemDateEdit1;
            this.colChangeTime.FieldName = "ChangeTime";
            this.colChangeTime.Name = "colChangeTime";
            this.colChangeTime.Visible = true;
            this.colChangeTime.VisibleIndex = 0;
            this.colChangeTime.Width = 120;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Mask.EditMask = "g";
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 3;
            this.colID.Width = 184;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.richTextBox1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.memoEditErrors);
            this.layoutControl1.Controls.Add(this.textEditServer);
            this.layoutControl1.Controls.Add(this.textEditPassword);
            this.layoutControl1.Controls.Add(this.textEditUserName);
            this.layoutControl1.Controls.Add(this.gridControlReviewChanges);
            this.layoutControl1.Controls.Add(this.gridControlReviews);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 117);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(729, 349, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1586, 587);
            this.layoutControl1.TabIndex = 8;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // richTextBox1
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.richTextBox1, this.autocompleteMenu1);
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(1024, 322);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(555, 188);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "review.Reviewers.Any( item => item.User.UserName == \"adp\" && !item.Completed ) &&" +
    " !review.Reviewers.Any( item => item.User.UserName != \"adp\" && !item.Completed )" +
    "";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1024, 45);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(555, 257);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.colCriteria,
            this.colName1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged_1);
            // 
            // colOid
            // 
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            // 
            // colCriteria
            // 
            this.colCriteria.FieldName = "Criteria";
            this.colCriteria.Name = "colCriteria";
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            // 
            // memoEditErrors
            // 
            this.memoEditErrors.Location = new System.Drawing.Point(1024, 530);
            this.memoEditErrors.MenuManager = this.ribbonControl;
            this.memoEditErrors.Name = "memoEditErrors";
            this.memoEditErrors.Size = new System.Drawing.Size(555, 50);
            this.memoEditErrors.StyleController = this.layoutControl1;
            this.memoEditErrors.TabIndex = 12;
            // 
            // textEditServer
            // 
            this.textEditServer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", global::Crucible.Properties.Settings.Default, "Server", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEditServer.EditValue = global::Crucible.Properties.Settings.Default.Server;
            this.textEditServer.Location = new System.Drawing.Point(126, 29);
            this.textEditServer.MenuManager = this.ribbonControl;
            this.textEditServer.Name = "textEditServer";
            this.textEditServer.Size = new System.Drawing.Size(1453, 20);
            this.textEditServer.StyleController = this.layoutControl1;
            this.textEditServer.TabIndex = 10;
            // 
            // textEditPassword
            // 
            this.textEditPassword.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", global::Crucible.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEditPassword.EditValue = global::Crucible.Properties.Settings.Default.Password;
            this.textEditPassword.Location = new System.Drawing.Point(914, 84);
            this.textEditPassword.MenuManager = this.ribbonControl;
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.PasswordChar = '*';
            this.textEditPassword.Size = new System.Drawing.Size(653, 20);
            this.textEditPassword.StyleController = this.layoutControl1;
            this.textEditPassword.TabIndex = 9;
            // 
            // textEditUserName
            // 
            this.textEditUserName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", global::Crucible.Properties.Settings.Default, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textEditUserName.EditValue = global::Crucible.Properties.Settings.Default.UserName;
            this.textEditUserName.Location = new System.Drawing.Point(138, 84);
            this.textEditUserName.MenuManager = this.ribbonControl;
            this.textEditUserName.Name = "textEditUserName";
            this.textEditUserName.Size = new System.Drawing.Size(653, 20);
            this.textEditUserName.StyleController = this.layoutControl1;
            this.textEditUserName.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1586, 587);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1";
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup2;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(1586, 587);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.tabbedControlGroup1.Text = "tabbedControlGroup1";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Ревью";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem9});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1576, 555);
            this.layoutControlGroup2.Text = "Ревью";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlReviews;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1017, 274);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlReviewChanges;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 274);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1017, 281);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gridControl1;
            this.layoutControlItem6.CustomizationFormText = "Фильтры";
            this.layoutControlItem6.Location = new System.Drawing.Point(1017, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(559, 277);
            this.layoutControlItem6.Text = "Фильтры";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.memoEditErrors;
            this.layoutControlItem7.CustomizationFormText = "Ошибки компиляции";
            this.layoutControlItem7.Location = new System.Drawing.Point(1017, 485);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(559, 70);
            this.layoutControlItem7.Text = "Результат компиляции";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.richTextBox1;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem9.Location = new System.Drawing.Point(1017, 277);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(559, 208);
            this.layoutControlItem9.Text = "Код";
            this.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Настройки";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1576, 555);
            this.layoutControlGroup3.Text = "Настройки";
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "Доступ";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(1576, 67);
            this.layoutControlGroup4.Text = "Доступ";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textEditUserName;
            this.layoutControlItem3.CustomizationFormText = "Имя пользователя";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(776, 24);
            this.layoutControlItem3.Text = "Имя пользователя";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEditPassword;
            this.layoutControlItem4.CustomizationFormText = "Пароль";
            this.layoutControlItem4.Location = new System.Drawing.Point(776, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(776, 24);
            this.layoutControlItem4.Text = "Пароль";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(116, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textEditServer;
            this.layoutControlItem5.CustomizationFormText = "Сервер";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1576, 24);
            this.layoutControlItem5.Text = "Сервер";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(116, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 91);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1576, 464);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // timerRefreshData
            // 
            this.timerRefreshData.Enabled = true;
            this.timerRefreshData.Interval = 300000;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Появились ревью";
            this.notifyIcon.BalloonTipTitle = "Появились ревью";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // timerHour
            // 
            this.timerHour.Enabled = true;
            this.timerHour.Interval = 3600000;
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.AllowsTabKey = true;
            this.autocompleteMenu1.AppearInterval = 300;
            this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu1.ImageList = this.imageList1;
            this.autocompleteMenu1.Items = new string[0];
            this.autocompleteMenu1.TargetControlWrapper = null;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "property.png");
            this.imageList1.Images.SetKeyName(1, "method.png");
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.CustomizationFormText = "layoutControlGroup5";
            this.layoutControlGroup5.Location = new System.Drawing.Point(1017, 277);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(559, 139);
            this.layoutControlGroup5.Text = "layoutControlGroup5";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 731);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReviewChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReviewChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditErrors.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem CheckFiltr;
        private DevExpress.XtraBars.BarButtonItem iOpen;
        private DevExpress.XtraBars.BarButtonItem iClose;
        private DevExpress.XtraBars.BarButtonItem iFind;
        private DevExpress.XtraBars.BarButtonItem iSave;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarButtonItem iHelp;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private DevExpress.XtraBars.BarStaticItem siStatus;
        private DevExpress.XtraBars.BarStaticItem siInfo;
        private DevExpress.XtraBars.BarButtonGroup alignButtonGroup;
        private DevExpress.XtraBars.BarButtonItem iBoldFontStyle;
        private DevExpress.XtraBars.BarButtonItem iItalicFontStyle;
        private DevExpress.XtraBars.BarButtonItem iUnderlinedFontStyle;
        private DevExpress.XtraBars.BarButtonGroup fontStyleButtonGroup;
        private DevExpress.XtraBars.BarButtonItem iLeftTextAlign;
        private DevExpress.XtraBars.BarButtonItem iCenterTextAlign;
        private DevExpress.XtraBars.BarButtonItem iRightTextAlign;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiSkins;
        private DevExpress.XtraBars.Ribbon.RibbonPage homeRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup fileRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup skinsRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup exitRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage helpRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup helpRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.Utils.ImageCollection ribbonImageCollection;
        private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private System.Windows.Forms.ImageList navbarImageList;
        private System.Windows.Forms.ImageList navbarImageListLarge;
        private DevExpress.XtraGrid.GridControl gridControlReviews;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewReviews;
        private DevExpress.XtraGrid.GridControl gridControlReviewChanges;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewReviewChanges;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private System.Windows.Forms.Timer timerRefreshData;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private DevExpress.XtraEditors.TextEdit textEditServer;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.TextEdit textEditUserName;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthor;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colChangeTime1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraGrid.Columns.GridColumn colComment;
        private DevExpress.XtraGrid.Columns.GridColumn colChangeTime;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colReviewers;
        private DevExpress.XtraEditors.MemoEdit memoEditErrors;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn colCriteria;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.Timer timerHour;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;

    }
}
