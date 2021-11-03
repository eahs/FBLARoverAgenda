using FBLARoverAgenda.DataService;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FBLARoverAgenda.Views
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurrentTeachersListPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentTeachersListPage" /> class.
        /// </summary>
        public CurrentTeachersListPage()
        {
            this.InitializeComponent();
            //this.BindingContext = CurrentTeachersListPageDataService.Instance.CurrentTeachersListPageViewModel;
        }
    }
}