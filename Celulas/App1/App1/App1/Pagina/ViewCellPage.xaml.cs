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
	public partial class ViewCellPage : ContentPage
	{
		public ViewCellPage ()
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
	}
}