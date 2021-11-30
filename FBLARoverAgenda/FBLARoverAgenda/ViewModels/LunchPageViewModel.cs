using FBLARoverAgenda.Models;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace FBLARoverAgenda.ViewModels
{
    /// <summary>
    /// ViewModel for my orders page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class LunchPageViewModel : BaseViewModel
    {
        #region Fields

        private ObservableCollection<Food> foodDetails;

        private ObservableCollection<Food> menuFoods;

        private Command itemSelectedCommand;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the property that has been bound with list view, which displays the collection of orders from json.
        /// </summary>
        [DataMember(Name = "foods")]
        public ObservableCollection<Food> MenuFoods
        {
            get
            {
                return this.menuFoods;
            }

            set
            {
                if (this.menuFoods == value)
                {
                    return;
                }

                this.SetProperty(ref this.menuFoods, value);
                this.GetProducts(this.menuFoods);
            }
        }

        /// <summary>
        /// Gets the property that has been bound with a list view, which displays the order details in list.
        /// </summary>
        public ObservableCollection<Food> FoodDetails
        {
            get
            {
                return this.foodDetails;
            }

            private set
            {
                if (this.foodDetails == value)
                {
                    return;
                }

                this.SetProperty(ref this.foodDetails, value);
            }
        }

        #endregion

        #region Command

        /// <summary>
        /// Gets the command that will be executed when an item is selected.
        /// </summary>
        public Command ItemSelectedCommand
        {
            get
            {
                return this.itemSelectedCommand ?? (this.itemSelectedCommand = new Command(this.ItemSelected));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when an item is selected.
        /// </summary>
        /// <param name="attachedObject">The Object</param>
        private void ItemSelected(object attachedObject)
        {
            // Do something
        }

        /// <summary>
        /// This method is used to get the ordered items from json.
        /// </summary>
        /// <param name="items">Ordered items</param>
        private void GetProducts(ObservableCollection<Food> items)
        {
            this.FoodDetails = new ObservableCollection<Food>();
            if (items != null && items.Count > 0)
            {
                this.FoodDetails = items;
            }
        }

        #endregion
    }
}
