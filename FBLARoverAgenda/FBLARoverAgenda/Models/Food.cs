using System.Runtime.Serialization;
using Xamarin.Forms.Internals;

namespace FBLARoverAgenda.Models
{
    /// <summary>
    /// Model for pages with order.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class Food
    {
        #region Fields

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the property that has been bound with a label, which displays the product name.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the property that has been bound with a label, which displays the order description.
        /// </summary>
        [DataMember(Name = "venue")]
        public string Venue { get; set; }

        /// <summary>
        /// Gets or sets the property that has been bound with a label, which displays the status of the order.
        /// </summary>
        [DataMember(Name = "price")]
        public string Price { get; set; }

        #endregion
    }
}
