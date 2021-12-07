using FBLARoverAgenda.Models;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace FBLARoverAgenda.ViewModels
{
    /// <summary>
    /// ViewModel for my classes page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class MySchedulePageViewModel : BaseViewModel
    {
        #region Fields

        private ObservableCollection<Class> classDetails;

        private ObservableCollection<Class> myClasses;

        private Command itemSelectedCommand;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the property that has been bound with list view, which displays the collection of classes from json.
        /// </summary>
        [DataMember(Name = "classes")]
        public ObservableCollection<Class> MyClasses
        {
            get
            {
                return this.myClasses;
            }

            set
            {
                if (this.myClasses == value)
                {
                    return;
                }

                this.SetProperty(ref this.myClasses, value);
                this.GetProducts(this.MyClasses);
            }
        }

        /// <summary>
        /// Gets the property that has been bound with a list view, which displays the class details in list.
        /// </summary>
        public ObservableCollection<Class> ClassDetails
        {
            get
            {
                return this.classDetails;
            }

            private set
            {
                if (this.classDetails == value)
                {
                    return;
                }

                this.SetProperty(ref this.classDetails, value);
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
        private void GetProducts(ObservableCollection<Class> items)
        {
            this.ClassDetails = new ObservableCollection<Class>();
            if (items != null && items.Count > 0)
            {
                this.ClassDetails = items;
            }
        }

        #endregion
    }
}
