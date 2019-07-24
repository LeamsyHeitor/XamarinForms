using System;
using System.Collections.Generic;
using System.Text;
using App3_JogoMimica.Model;

namespace App3_JogoMimica.Armazenamento
{
    public class Armazenamento
    {
        public static Jogo Jogo { get; set; }
        public static short RodadaAtual { get; set; }

        public static string[][] Palavras = {
         //nivel Facil Pontuação 1
         new string[] {"Olho", "Língua", "Chinelo", "Milho", "Penalti", "Bola", "Ping-pong","BÊBADO","SENTIR FRIO","BAILARINA","MACACO","TOMAR UM TIRO","REZANDO",
             "IDOSO","CANGURU","CEGO","SANFONA","MOTOCICLETA","JOGAR SINUCA","SERROTE","VIOLINO","SURFISTA","PAPAI NOEL","SERPENTE","PESCADOR","BEBÊ CHORANDO","PINGUIM",
             "SENTIR RAIVA","FAZER BARBA"},

        //nivel Medio Pontuação 3
        new string[]{"Carpiteiro","Amarelo","Limão", "Abelha","ASTRONAUTA","TOP MODEL","COBRAR UM PÊNALTI","PINTOR DE PAREDE","SENTIR DOR","TOMAR SORVETE","CANTOR",
        "TOURO BRAVO","JOGAR GOLF","JOGAR PIÃO","LOUCO","ESTILINGUE","COMER MACARRÃO","TOMAR CHOQUE","TRISTEZA","CHICOTE","JOGAR CAPOEIRA"},

        //nivel Dificil Pontuação 4
        new string[]{"Notebook","ESTÁTUA","ADMIRAÇÃO","PIANISTA","JOGAR BASQUETE","ARCO E FLECHA","SENTIR MEDO","CHAVE DE FENDA","SOLTAR BOMBINHA","LUNETA","ALEIJADO"},

        //Filmes Pontuação 5
        new string []{"Filme: Batman vs Super Man","Filme: O Poderoso Chefão","Filme: Pulp Fiction","Filme: 2001: Uma Odisseia no Espaço","Filme: Guerra nas Estrelas","Filme: Forrest Gump","Filme: Beleza Americana",
            "Filme: Laranja Mecânica","Filme: O Iluminado","Filme: Clube da Luta","Filme: Psicose","Filme: Jurassic Park","Filme: Taxi Driver","Filme: Batman – O Cavaleiro das Trevas","Filme: Crepúsculo","Filme: O Rei Leão","Filme: Matrix",
            "Filme: A Bela Adormecida","Filme: Os Caça-Fantasmas","Filme: Dumbo","Filme: Rocky","Filme: Cães de Aluguel","Filme: A Dama e o Vagabundo","Filme: O Amor É Cego","Filme: E.T."},

        };
    }

}
