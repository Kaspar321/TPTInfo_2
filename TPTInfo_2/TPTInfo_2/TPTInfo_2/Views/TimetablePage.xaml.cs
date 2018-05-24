using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TPTInfo_2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TimetablePage : ContentPage
	{
		public TimetablePage ()
		{
			InitializeComponent();
            Timetable.Source = "https://tpt.siseveeb.ee/veebivormid/tunniplaan";
        }
	}
}