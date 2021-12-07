using FBLARoverAgenda.DataService;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FBLARoverAgenda.Views
{
    /// <summary>
    /// Page to show the my order list. 
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MySchedulePage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MySchedulePage" /> class.
        /// </summary>
        public MySchedulePage()
        {
            this.InitializeComponent();
            this.BindingContext = MyClassesDataService.Instance.MySchedulePageViewModel;
        }
    }
}