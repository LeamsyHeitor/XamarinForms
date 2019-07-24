﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App3_JogoMimica.Model;

namespace App3_JogoMimica.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Jogo : ContentPage
    {
        public Jogo(Grupo grupo)
        {
            InitializeComponent();

            BindingContext = new ViewlModel.JogoViewModel(grupo);
        }
    }
}