using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Modelo;

namespace App1.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "Leamsy", Cargo = "Presidente da Empresa" });
            Lista.Add(new Funcionario() { Nome = "Maria", Cargo = "Gerente de Vendas" });
            Lista.Add(new Funcionario() { Nome = "José", Cargo = "Gerente de Marketing" });
            Lista.Add(new Funcionario() { Nome = "Mateus", Cargo = "Entregador" });
            Lista.Add(new Funcionario() { Nome = "Felipe", Cargo = "Vendedor" });

            ListaFuncionario.ItemsSource = Lista;
        }

        private void ItemSelectAction(object sender, SelectedItemChangedEventArgs args)
        {
            Funcionario func = (Funcionario) args.SelectedItem;
            Navigation.PushAsync(new Detalhes.DetailPage(func));
        }

        private void FeriasAction(object sender, EventArgs args)
        {
            MenuItem botao = (MenuItem)sender;
            Funcionario func = (Funcionario)botao.CommandParameter;

            DisplayAlert("Titulo: " + func.Nome, "Mensagem: " + func.Nome + " - " + func.Cargo,"OK");

        }

        private void AbonoActions(object sender, EventArgs args)
        {

        }
    }
}