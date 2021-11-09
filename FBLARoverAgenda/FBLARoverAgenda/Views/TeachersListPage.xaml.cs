using FBLARoverAgenda.DataService;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FBLARoverAgenda.Views
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeachersListPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeachersListPage" /> class.
        /// </summary>
        public TeachersListPage()
        {
            this.InitializeComponent();
            this.BindingContext = TeachersListPageDataService.Instance.TeachersListPageViewModel;
        }
    }
}