using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AppAvantia.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : MasterDetailPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}
    
        public void GoPaginaSilvio(object sender, EventArgs args) {
            Detail = new Pages.Perfil();
        }
        public void GoPaginaEduardo(object sender, EventArgs args)
        {
            Detail = new Pages.Perfil2();
        }
        public void GoPaginaAvantia(object sender, EventArgs args)
        {
            Detail = new Pages.Avantia();
        }
    }
}