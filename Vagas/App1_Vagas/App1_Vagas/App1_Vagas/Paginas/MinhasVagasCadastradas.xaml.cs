using App1_Vagas.Modelos;
using App1_Vagas.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MinhasVagasCadastradas : ContentPage
    {
        List<Vaga> Lista {get; set;}
		public MinhasVagasCadastradas (Vaga vaga)
		{
			InitializeComponent ();
            Database database = new Database();
            Lista = database.Consultar();
            ListaVagas.ItemsSource = Lista;

            lblCount.Text = Lista.Count.ToString();
        }
        public void Editar(object sender, EventArgs args)
        {
            Label lblEditar = (Label)sender;
            TapGestureRecognizer tapGest = ((TapGestureRecognizer)lblEditar.GestureRecognizers[0]);
            Vaga vaga = tapGest.CommandParameter as Vaga;

            Navigation.PushAsync(new CadastroVaga(vaga));
        }
        public void Exlcuir(object sender, EventArgs args)
        {
            Label lblExcluir = (Label)sender;
            TapGestureRecognizer tapGest = ((TapGestureRecognizer)lblExcluir.GestureRecognizers[0]);
            Vaga vaga = tapGest.CommandParameter as Vaga;

            Database database = new Database();
            //database.Exclusao(vaga);
        }
    }
}