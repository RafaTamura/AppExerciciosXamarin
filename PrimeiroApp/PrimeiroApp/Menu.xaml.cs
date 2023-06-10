using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimeiroApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : ContentPage
	{
		public Menu ()
		{
			InitializeComponent ();
           
		}

        private async void BtnImc_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new IMC());
		
		}

        private async void BtnEmail_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new Email(), true);
			
        }

    }
}