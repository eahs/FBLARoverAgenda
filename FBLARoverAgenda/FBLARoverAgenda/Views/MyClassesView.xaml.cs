using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FBLARoverAgenda.Views
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyOrdersView : ContentView
    {
        public MyOrdersView()
        {
            this.InitializeComponent();
        }
    }
}