using FBLARoverAgenda.ViewModels;
using Syncfusion.ListView.XForms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FBLARoverAgenda.Views
{
    /// <summary>
    /// Page to show my address page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllClubsPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllClubsPage" /> class.
        /// </summary>
        public AllClubsPage()
        {
            this.InitializeComponent();
            this.BindingContext = AllClubsPageViewModel.BindingContext;
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width < height)
            {
                if (this.myAddress.LayoutManager is GridLayout)
                {
                    (this.myAddress.LayoutManager as GridLayout).SpanCount = 1;
                }
            }
            else
            {
                if (this.myAddress.LayoutManager is GridLayout)
                {
                    (this.myAddress.LayoutManager as GridLayout).SpanCount = 2;
                }
            }
        }
    }
}