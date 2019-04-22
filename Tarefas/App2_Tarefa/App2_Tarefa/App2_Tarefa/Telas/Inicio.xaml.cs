using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFGloss;

namespace App2_Tarefa.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Inicio : ContentPage
	{
  
		public Inicio ()
		{
			InitializeComponent ();

            DataHoje.Text = DateTime.Now.DayOfWeek.ToString() + "," + DateTime.Now.ToString("dd/MM");
		}

        private void ActionGoCadastro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cadastro());
        }
    }
}