using Xamarin.Forms.Internals;

namespace FBLARoverAgenda.Controls
{
    /// <summary>
    /// This class extends the behavior of the SearchableListView control to filter the ListViewItem based on text.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class SearchableMoviesList : SearchableListView
    {
        #region Method 

        /// <summary>
        /// Filtering the list view items based on the search text.
        /// </summary>
        /// <param name="obj">The list view item</param>
        /// <returns>Returns the filtered item</returns>
        public override bool FilterContacts(object obj)
        {
            if (base.FilterContacts(obj))
            {
                var taskInfo = obj as Models.Movie;
                if (taskInfo == null || string.IsNullOrEmpty(taskInfo.TeacherName) || string.IsNullOrEmpty(taskInfo.TeacherName))
                {
                    return false;
                }

                return taskInfo.TeacherName.ToUpperInvariant().Contains(this.SearchText.ToUpperInvariant())
                       || taskInfo.TeacherName.ToUpperInvariant().Contains(this.SearchText.ToUpperInvariant());
            }

            return false;
        }

        #endregion
    }
}
