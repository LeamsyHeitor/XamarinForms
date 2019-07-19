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
	public partial class CadastroVaga : ContentPage
	{
		public CadastroVaga (Vaga vaga)
		{
			InitializeComponent ();
		}

        public void Salvar(object sender, EventArgs args)
        {
            //TODO - obter dados da tela

            Vaga vaga = new Vaga();
            vaga.NomeVaga = NomeVaga.Text;
            vaga.Empresa = Empresa.Text;
            vaga.Quantidade = short.Parse(Quantidade.Text);
            vaga.Cidade = Cidade.Text;
            vaga.Salario = short.Parse(Salario.Text);
            vaga.Descricao = Descricao.Text;
            vaga.TipoContratacao = (TipoContratacao.IsToggled) ? "CLT" : "PJ";
            vaga.Telefone = Telefone.Text;
            vaga.Email = Email.Text;

            //TODO - salvar informções no banco
            Database database = new Database();
            database.Cadastro(vaga);

            //Dessa maneira a pagia é carregada, trazendo as vagas cadastradas
            App.Current.MainPage = new NavigationPage(new ConsultaVagas());
        }
    }
}