using FBLARoverAgenda.DataService;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FBLARoverAgenda.Views
{
    /// <summary>
    /// Page showing the list of names with grouping.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllTeachersListPage
    {
        public AllTeachersListPage()
        {
            this.InitializeComponent();
            this.BindingContext = NamesListDataService.Instance.AllTeachersListPageViewModel;
        }
    }
}