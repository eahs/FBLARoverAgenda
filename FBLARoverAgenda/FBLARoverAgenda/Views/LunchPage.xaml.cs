using FBLARoverAgenda.DataService;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FBLARoverAgenda.Views
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LunchPage : ContentPage
    {
        public LunchPage()
        {
            InitializeComponent();
            this.BindingContext = LunchDataService.Instance.MySchedulePageViewModel;
        }
    }
}