
using interfaceAppConsole;

namespace libAppConsole
{
    public class Jogador2 : interfaceJogador
    {
        public string nome { get; set; }    

        public string chutar()
        {
            return $"{this.nome} estas pateando";
        }

        public string correr()
        {
            return $"{this.nome} estas corriendo";
        }

        public string passar()
        {
            return $"{this.nome} estas passando";
        }
    }
}