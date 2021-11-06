using System.Runtime.Serialization;
using Xamarin.Forms.Internals;

namespace FBLARoverAgenda.Models
{
    /// <summary>
    /// Model for pages with order.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class Orders
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
        [DataMember(Name = "block")]
        public string Block { get; set; }

        /// <summary>
        /// Gets or sets the property that has been bound with a label, which displays the status of the order.
        /// </summary>
        [DataMember(Name = "room")]
        public string Room { get; set; }

        /// <summary>
        /// Gets or sets the property that has been bound with a label, which displays the order id.
        /// </summary>
        [DataMember(Name = "teacher")]
        public string Teacher { get; set; }

        #endregion
    }
}
