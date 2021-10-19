using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FBLARoverAgenda.Views
{
    /// <summary>
    /// Page to show chat profile page
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyProfilePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyProfilePage" /> class.
        /// </summary>
        public MyProfilePage()
        {
            this.InitializeComponent();
            this.ProfileImage.Source = App.ImageServerPath + "ProfileImage11.png";
        }
    }
}