using System;
using libAppConsole;

namespace appConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador1 jogador1 = new Jogador1("CR7");
            Jogador2 jogador2 = new Jogador2();
            jogador2.nome = "Messi";
            Jogo jogo = new Jogo(jogador1, jogador2);
            jogo.iniciarJogo();
        }
    }

}
