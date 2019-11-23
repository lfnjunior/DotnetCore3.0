using interfaceAppConsole;

namespace libAppConsole
{
    public class Jogador1 : interfaceJogador
    {
        public string nome { get; set; }    

        public Jogador1(string _nome){
            this.nome = _nome;
        }

        public string correr(){
            return $"{nome} está Correndo";
        }

        public string chutar(){
            return $"{nome} está Chutando";
        }
        public string passar(){
            return $"{nome} está Passando";
        }
    }
}