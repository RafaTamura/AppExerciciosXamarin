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
	public partial class IMC : ContentPage
	{
		public IMC ()
		{
			InitializeComponent ();
        btnCalcularImc.Clicked+= BtnCalcularImc_Clicked;
		}

        private void BtnCalcularImc_Clicked(object sender, EventArgs e)
        {
			string nomeImcVar = nomeImc.Text;
			int idadeImcVar = Convert.ToInt32(idadeImc.Text);
			float pesoImcVar = float.Parse(pesoImc.Text);
			float alturaImcVar = float.Parse(alturaImc.Text);
            string imc = "";

			float valor = (pesoImcVar / (alturaImcVar * alturaImcVar));
			
			if (valor < 18.5)
			{
				 imc = "abaixo do peso";

                }
                else if (valor > 18.5 && valor < 24.9)
            {
				 imc = "no peso normal ";
            }
            else if (valor > 25 && valor < 29.9)
            {
                 imc = "na faixa de pré-obesidade ";

                }
                else if (valor > 30 && valor < 39.9)
            {
                 imc = "na faixa de obesidade grau 1 ";

                }
                else if (valor > 40)
            {
                 imc = "na faixa de obesidade grau 3 ";

                }

            string resultado = $"Olá, {nomeImcVar}!\nCom {idadeImcVar} anos, o seu IMC é de {valor:f2}.\nIsso significa que você está {imc}.";
            lblImc.Text = resultado;
        }
        }
}