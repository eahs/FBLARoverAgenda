using FBLARoverAgenda.ViewModels;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Json;
using Xamarin.Forms.Internals;

namespace FBLARoverAgenda.DataService
{
    /// <summary>
    /// Data service to load the data from json file.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class TeachersListPageDataService
    {
        #region fields

        private static TeachersListPageDataService moviesDataService;

        private TeachersListPageViewModel moviesViewModel;

        #endregion

        #region Properties

        /// <summary>
        /// Gets an instance of the <see cref="TeachersListPageDataService"/>.
        /// </summary>
        public static TeachersListPageDataService Instance => moviesDataService ?? (moviesDataService = new TeachersListPageDataService());

        /// <summary>
        /// Gets or sets the value of movie page view model.
        /// </summary>
        public TeachersListPageViewModel TeachersListPageViewModel =>
            this.moviesViewModel ?? LoadTeachers();
            //(this.moviesViewModel = PopulateData<TeachersListPageViewModel>("navigation.json"));

        public TeachersListPageViewModel LoadTeachers ()
        {
            TeachersListPageViewModel vm = new TeachersListPageViewModel
            {
                TeachersList = new System.Collections.ObjectModel.ObservableCollection<Models.Movie>()
            };

            vm.TeachersList.Add(new Models.Movie
            {
                TeacherName = "Hammerstone, Morgan",
                TeacherEmail = "hammerstonem@eastonsd.org"
            });
            vm.TeachersList.Add(new Models.Movie
            {
                TeacherName = "Hudak, Kristen",
                TeacherEmail = "hudakk@eastonsd.org"
            });
            vm.TeachersList.Add(new Models.Movie
            {
                TeacherName = "Kazan, Brandon",
                TeacherEmail = "kazanb@eastonsd.org"
            });
            vm.TeachersList.Add(new Models.Movie
            {
                TeacherName = "Klein, Beverly",
                TeacherEmail = "kazanb@eastonsd.org"
            });
            vm.TeachersList.Add(new Models.Movie
            {
                TeacherName = "Tanczos, Michael",
                TeacherEmail = "tanczosm@eastonsd.org"
            });
            vm.TeachersList.Add(new Models.Movie
            {
                TeacherName = "Uhler, Richard",
                TeacherEmail = "uhlerr@eastonsd.org"
            });

            return vm;
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

        #endregion
    }
}
