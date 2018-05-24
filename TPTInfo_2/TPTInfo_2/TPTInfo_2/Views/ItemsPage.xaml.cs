using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TPTInfo_2.Models;
using TPTInfo_2.Views;
using TPTInfo_2.ViewModels;

namespace TPTInfo_2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemsPage : ContentPage
	{

        public ItemsPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://tpt.siseveeb.ee/"));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.tptlive.ee/opilasele/opilasesindus/"));
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://tpt.siseveeb.ee/veebivormid/konsultatsioonid"));
        }
    }
}