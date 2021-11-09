using System.Runtime.Serialization;
using Xamarin.Forms.Internals;

namespace FBLARoverAgenda.Models
{
    /// <summary>
    /// Model for the movies List page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class Movie
    {
        private string posterImage;

        #region Properties

        /// <summary>
        /// Gets or sets the movie name.
        /// </summary>
        [DataMember(Name = "name")]
        public string TeacherName { get; set; }

        /// <summary>
        /// Gets or sets the release year of the movie.
        /// </summary>
        [DataMember(Name = "email")]
        public string TeacherEmail { get; set; }

        /// <summary>
        /// Gets or sets the  image of the movie.
        /// </summary>
        [DataMember(Name = "image")]
        public string PosterImage
        {
            get
            {
                return App.ImageServerPath + this.posterImage;
            }

            set
            {
                this.posterImage = value;
            }
        }

        #endregion
    }
}
