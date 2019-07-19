using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1_Vagas.Modelos;
using App1_Vagas.Banco;

namespace App1_Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaVagas : ContentPage
    {
        List<Vaga> Lista { get; set; }
        public ConsultaVagas()
        {
            InitializeComponent();

            Database database = new Database();
            Lista = database.Consultar();
            ListaVagas.ItemsSource = Lista;

            lblCount.Text = Lista.Count.ToString();

            var listaTexto = new List<string>
            {

              
                "image.jpg",
                  "Texto 1",
                "Texto 2",

            };

            TextoCarouselView.ItemsSource = listaTexto;

            //var listalink = new List<string>
            //{
               
            //    "https://www.google.com/url?sa=i&source=imgres&cd=&cad=rja&uact=8&ved=2ahUKEwie57Ptu_XiAhWYLLkGHaAiBeUQjRx6BAgBEAU&url=https%3A%2F%2Fcolunaitalo.com.br%2Fcultura-e-lazer%2F663%2Fdeadpool-2-tem-estreia-marcada-no-cine-vip&psig=AOvVaw3KOZulDkgO7FV2DlTlXryX&ust=1561030922297597",
            //};


        }

        public void GoCadastro(object sender, EventArgs args)
        {
            //Navigation.PushAsync(new CadastroVaga());
        }
        public void GoMinhasVagas(object sender, EventArgs args)
        {
            //Navigation.PushAsync(new MinhasVagasCadastradas());
        }

        public void MaisDetalhe(object sender, EventArgs args)
        {
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer tapGest = ((TapGestureRecognizer)lblDetalhe.GestureRecognizers[0]);
            Vaga vaga = tapGest.CommandParameter as Vaga;

            Navigation.PushAsync(new DetalheVaga(vaga));
        }

        public void PesquisarAction(object sender, TextChangedEventArgs args)
        {
            ListaVagas.ItemsSource = Lista.Where(a=>a.NomeVaga.Contains(args.NewTextValue)).ToList();
        }
    }
}