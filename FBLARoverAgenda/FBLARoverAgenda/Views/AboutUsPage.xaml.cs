﻿using FBLARoverAgenda.ViewModels.About;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FBLARoverAgenda.Views
{
    /// <summary>
    /// About us with parallax scroll page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutUsWithScrollPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:FBLARoverAgenda.Views.AboutUsWithParallaxScrollPage"/> class.
        /// </summary>
        public AboutUsWithScrollPage()
        {
            this.InitializeComponent();
            this.BindingContext = AboutUsViewModel.BindingContext;
        }
    }
}