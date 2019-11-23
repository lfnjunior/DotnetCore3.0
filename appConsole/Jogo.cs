using System;
using interfaceAppConsole;

namespace appConsole
{
    public class Jogo
    {
        private readonly interfaceJogador jogador1;

        private readonly interfaceJogador jogador2;

        public Jogo(interfaceJogador _jogador1, interfaceJogador _jogador2){ 
            this.jogador1 = _jogador1;
            this.jogador2 = _jogador2;
        }

        public void iniciarJogo(){
            Console.WriteLine("1º tempo");
            Console.WriteLine(jogador1.correr());
            Console.WriteLine(jogador1.passar());
            Console.WriteLine(jogador1.chutar());

            Console.WriteLine("2º tempo");

            Console.WriteLine(jogador2.correr());
            Console.WriteLine(jogador2.passar());
            Console.WriteLine(jogador2.chutar());
        }
        
    }
}