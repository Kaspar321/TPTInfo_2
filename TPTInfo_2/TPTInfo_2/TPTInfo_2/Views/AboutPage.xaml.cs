using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TPTInfo_2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage : ContentPage
	{
		public AboutPage ()
		{
			InitializeComponent ();
            SchoolLogo.Source = ImageSource.FromUri(new Uri("https://www.tptlive.ee/wp-content/uploads/2014/07/tpt_logo2.png"));
        }
	}
}