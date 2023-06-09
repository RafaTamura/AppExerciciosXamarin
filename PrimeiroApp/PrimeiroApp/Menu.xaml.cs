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


        public async Task btnImc_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IMC());

        }

        public async Task btnEmail_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Email());

        }
    }
}