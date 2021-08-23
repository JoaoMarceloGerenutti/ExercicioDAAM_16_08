using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercicio_DAAM_16_08
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Convertendo os campos recebidos pelo usuario.
            string nome = etNome.Text;
            string dataNascimento = dtNascimento.Date.ToString("d");

            // Verificando se o nome digitado é válido e mostrando uma mensagem para o usuario.
            bool nomeInvalido = string.IsNullOrEmpty(nome);
            if (nomeInvalido == true)
            {
                DisplayAlert("Campo não preenchido!", "O campo nome não foi preenchido.", "PREENCHER CAMPO");
            }
            else
            {
                DisplayAlert($"Olá {nome}", $"Sua data de nascimento é: {dataNascimento}", "OK");
            }
        }
    }
}
