using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2_Tarefa.Modelos;

namespace App2_Tarefa.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastro : ContentPage
	{
        private byte Prioridade { get; set; }
		public Cadastro ()
		{
			InitializeComponent ();
		}
        public void PrioridadeSelection(object sender, EventArgs Args)
        {
            var Stacks = SLPrioridades.Children;
          
            foreach (var Linha in Stacks)
            {
                Label LblPrioridade = ((StackLayout)Linha).Children[1] as Label;
                LblPrioridade.TextColor = Color.Gray;
            }

            ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;
            FileImageSource Source= ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;

            String Prioridade = Source.File.ToString().Replace(".png", " ");
            this.Prioridade = byte.Parse(Prioridade);
        }

        private void SalvarAction(object sender, EventArgs args)
        {
            bool ErroExiste = false;
            if (!(TxtNome.Text.Trim().Length > 0))
            {
                DisplayAlert("ERRO", "Nome não preenchido!", "OK");
            }
            if (!(this.Prioridade > 0))
            {
                DisplayAlert("ERRO", "Prioridade, não informada!", "OK");

            }
            if (ErroExiste == false)
            {
                Tarefa tarefa = new Tarefa();
                tarefa.Nome = TxtNome.Text.Trim();
                tarefa.Prioridade = this.Prioridade;

                new GerenciadorTarefa().Salvar(tarefa);

                App.Current.MainPage = new NavigationPage(new Inicio());
                
            }
        }
    }
}