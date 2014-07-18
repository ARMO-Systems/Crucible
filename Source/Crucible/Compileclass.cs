using System.Linq;
using Crucible.XPO;

namespace Crucible
{
    public class CompileClass
    {
        public static bool Filter( ReviewXPO review )
        {
            /*
            var s =  ( ( ( review.Reviewers.Any( item => item.User.UserName == "adp" && !item.Completed ) || review.Author.UserName == "adp" )
                      && review.Changes.First( item => item.ChangeTime == review.LastChangeTime ).User.UserName != "adp" )
                    || ( review.Author.UserName == "adp" && review.Reviewers.All( item => item.Completed ) ) ) && review.State == state.Review;*/

            return review.Reviewers.Any( item => item.Completed );
        }
    }
}