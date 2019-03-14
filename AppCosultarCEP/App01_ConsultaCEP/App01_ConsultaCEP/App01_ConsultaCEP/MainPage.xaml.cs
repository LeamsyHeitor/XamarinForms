using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultaCEP.Servico.Modelo;
using App01_ConsultaCEP.Servico;

namespace App01_ConsultaCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;
        }

        private void BuscarCEP(Object sender, EventArgs args)
        {
            // TODO - Lógica do programa.

            //TODO - Validações.
            string cep = CEP.Text.Trim();

            if (isValidCEP(cep)) {
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

                    if (end != null)
                    {

                        RESULTADO.Text = string.Format("Endereço: {2},{3},{0},{1}", end.localidade, end.uf, end.logradouro, end.bairro);
                    }
                    else
                    {
                        DisplayAlert("ERROR", "Não foi possivel encontrar o cep informado: " + cep, "OK");
                    }
                    } catch (Exception ex)
                    {
                        DisplayAlert("ERROR CRÍTICO", ex.Message, "OK");
                }
            }
        }
        private bool isValidCEP(string cep)
        {
            bool valido = true;
            if (cep.Length != 8)
            {
                DisplayAlert("ERRO", "CEP inválido! O CEP deve conter 8 caracters.", "Ok");
                valido = false;
            }
            int NovoCEP = 0;

            if (!int.TryParse(cep, out NovoCEP))
            {
                DisplayAlert("ERRO", "CEP inválido! O CEP deve conter apenas números", "Ok");
                valido = false;
            }

            return true;

        }
    }
}
