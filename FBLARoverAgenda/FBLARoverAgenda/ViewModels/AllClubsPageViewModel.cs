using FBLARoverAgenda.Models;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace FBLARoverAgenda.ViewModels
{
    /// <summary>
    /// ViewModel for my address page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [DataContract]
    public class AllClubsPageViewModel : BaseViewModel
    {
        #region Fields

        private static AllClubsPageViewModel myAddressViewModel;

        private Command editCommand;

        private Command deleteCommand;

        private Command addCardCommand;

        #endregion

        #region Constructor

        public AllClubsPageViewModel()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the value of my address page view model.
        /// </summary>
        public static AllClubsPageViewModel BindingContext =>
            myAddressViewModel = PopulateData<AllClubsPageViewModel>("detail.json");

        [DataMember(Name = "clubDetails")]
        public ObservableCollection<Address> ClubDetails { get; set; }

        #endregion

        #region Command

        /// <summary>
        /// Gets the command is executed when the edit button is clicked.
        /// </summary>
        public Command EditCommand
        {
            get
            {
                return this.editCommand ?? (this.editCommand = new Command(this.EditButtonClicked));
            }
        }

        /// <summary>
        /// Gets the command is executed when the delete button is clicked.
        /// </summary>
        public Command DeleteCommand
        {
            get
            {
                return this.deleteCommand ?? (this.deleteCommand = new Command(this.DeleteButtonClicked));
            }
        }

        /// <summary>
        /// Gets the command is executed when the add card button is clicked.
        /// </summary>
        public Command AddCardCommand
        {
            get
            {
                return this.addCardCommand ?? (this.addCardCommand = new Command(this.AddCardButtonClicked));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Populates the data for view model from json file.
        /// </summary>
        /// <typeparam name="T">Type of view model.</typeparam>
        /// <param name="fileName">Json file to fetch data.</param>
        /// <returns>Returns the view model object.</returns>
        private static T PopulateData<T>(string fileName)
        {
            var file = "FBLARoverAgenda.Data." + fileName;

            var assembly = typeof(App).GetTypeInfo().Assembly;

            T data;

            using (var stream = assembly.GetManifestResourceStream(file))
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                data = (T)serializer.ReadObject(stream);
            }

            return data;
        }

        /// <summary>
        /// Invoked when the edit button clicked
        /// </summary>
        /// <param name="obj">The object</param>
        private void EditButtonClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the delete button clicked
        /// </summary>
        /// <param name="obj">The object</param>
        private void DeleteButtonClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the add card button clicked
        /// </summary>
        /// <param name="obj">The object</param>
        private void AddCardButtonClicked(object obj)
        {
            // Do something
        }

        #endregion
    }
}
