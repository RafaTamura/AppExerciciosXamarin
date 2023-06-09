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
    public partial class Email : ContentPage
    {
        public Email()
        {
            InitializeComponent();
            btnGerarEmail.Clicked += BtnGerarEmail_Clicked;
        }

        private void BtnGerarEmail_Clicked(object sender, EventArgs e)
        {

            string nomeCompleto = nomeEmail.Text;

            string[] separar = nomeCompleto.Split(' ');
            string sobrenome = separar[separar.Length - 1];
            string nomePrincipal = string.Join(" ", separar, 0, separar.Length - 1 );
            
            if (separar.Length > 2) {
                nomePrincipal = string.Join(" ", separar, 0, separar.Length - 2);
            }

            string email = $"{sobrenome}.{nomePrincipal}@ufn.edu.br";

            lbEmail.Text = email;
        }
    }
}