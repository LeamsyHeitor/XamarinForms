using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Modelo;

namespace App1.Pagina.Detalhes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
		public DetailPage (Funcionario funcionario)
		{
			InitializeComponent ();

            TxtNome.Text = funcionario.Nome;
		}

	}
}