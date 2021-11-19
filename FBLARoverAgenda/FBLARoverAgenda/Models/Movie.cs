using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace FBLARoverAgenda.Models
{
    /// <summary>
    /// Model for the movies List page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class Movie
    {
        private string posterImage;

        #region methods
        public Command EmailCommand { get; set; } 
        #endregion

        public Movie()
        {
            this.EmailCommand = new Command(this.EmailTeacher);
        }

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

        public async void EmailTeacher(object obj)
        {
            List<string> recipients = new List<string>();
            recipients.Add(TeacherEmail);

            await SendEmail("Question", "Hi ", recipients);
        }

        public async Task SendEmail(string subject, string greeting, List<string> recipients)
        {
            try
            {
                var message = new EmailMessage
                {
                    Subject = subject,
                    Body = $"{greeting}",
                    To = recipients,
                    BodyFormat = EmailBodyFormat.PlainText
                };
                await Email.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException fbsEx)
            {
                // Email is not supported on this device  
            }
            catch (Exception ex)
            {
                // Some other exception occurred  
            }
        }

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
