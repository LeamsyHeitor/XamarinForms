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
        }

        public void GoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastroVaga());
        }
        public void GoMinhasVagas(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MinhasVagasCadastradas());
        }

        public void MaisDetalhe(object sender, EventArgs args)
        {
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer tapGest = ((TapGestureRecognizer)lblDetalhe.GestureRecognizers[0]);
            Vaga vaga = tapGest.CommandParameter as Vaga;

            Navigation.PushAsync(new DetalheVaga(vaga));
        }

        public void Pesquisar(object sender, TextChangedEventArgs args)
        {
            Lista.Where(a => a.NomeVaga.Contains(args.NewTextValue)).ToList();
        }
    }
}