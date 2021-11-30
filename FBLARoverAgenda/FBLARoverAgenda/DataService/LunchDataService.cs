using FBLARoverAgenda.ViewModels;
using System.Reflection;
using System.Runtime.Serialization.Json;
using Xamarin.Forms.Internals;

namespace FBLARoverAgenda.DataService
{
    /// <summary>
    /// Data service to load the data from json file.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class LunchDataService
    {
        #region fields

        private static LunchDataService lunchDataService;

        private LunchPageViewModel lunchPageViewModel;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates an instance for the <see cref="MyOrdersDataService"/> class.
        /// </summary>
        private LunchDataService()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets an instance of the <see cref="LunchDataService"/>.
        /// </summary>
        public static LunchDataService Instance => lunchDataService ?? (lunchDataService = new LunchDataService());

        /// <summary>
        /// Gets or sets the value of my orders page view model.
        /// </summary>
        public LunchPageViewModel MySchedulePageViewModel =>
            this.lunchPageViewModel = PopulateData<LunchPageViewModel>("ecommerce.json");

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

        #endregion
    }
}