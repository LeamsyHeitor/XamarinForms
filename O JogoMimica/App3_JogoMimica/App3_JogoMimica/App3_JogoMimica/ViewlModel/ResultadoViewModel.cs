using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using App3_JogoMimica.Model;
using Xamarin.Forms;

namespace App3_JogoMimica.ViewlModel
{
    class ResultadoViewModel : INotifyPropertyChanged
    {
        public Jogo Jogo { get; set; }
        public Command JogarNovamente { get; set; }

        public ResultadoViewModel()
        {
            Jogo = Armazenamento.Armazenamento.Jogo;
            JogarNovamente = new Command(jogarNovamenteAction);
        }

        private void jogarNovamenteAction()
        {
            App.Current.MainPage = new View.Inicio();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string NameProperty)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NameProperty));
            }
        }
    }


}
