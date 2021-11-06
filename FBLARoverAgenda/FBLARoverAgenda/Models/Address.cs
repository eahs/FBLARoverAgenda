using System.Runtime.Serialization;
using Xamarin.Forms.Internals;

namespace FBLARoverAgenda.Models
{
    /// <summary>
    /// Model for my address page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class Address
    {
        #region Properties
        /// <summary>
        /// Gets or sets user name.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the advisor name.
        /// </summary>
        [DataMember(Name = "advisorName")]
        public string AdvisorName { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        [DataMember(Name = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the advisor email.
        /// </summary>
        [DataMember(Name = "advisorEmail")]
        public string AdvisorEmail { get; set; }

        #endregion
    }
}
