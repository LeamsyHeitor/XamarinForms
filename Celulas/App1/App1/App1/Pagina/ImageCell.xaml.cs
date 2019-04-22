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
	public partial class ImageCell : ContentPage
	{
		public ImageCell ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Foto= "perfil.png", Nome = "Leamsy", Cargo = "Presidente da Empresa" });
            Lista.Add(new Funcionario() { Foto = "perfil.png", Nome = "Maria", Cargo = "Gerente de Vendas" });
            Lista.Add(new Funcionario() { Foto = "perfil.png", Nome = "José", Cargo = "Gerente de Marketing" });
            Lista.Add(new Funcionario() { Foto = "perfil.png", Nome = "Mateus", Cargo = "Entregador" });
            Lista.Add(new Funcionario() { Foto = "perfil.png", Nome = "Felipe", Cargo = "Vendedor" });

            ListaFuncionario.ItemsSource = Lista;
        }
	}
}