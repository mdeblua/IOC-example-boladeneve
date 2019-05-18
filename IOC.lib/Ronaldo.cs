
using IOC.Interface;

namespace IOC.lib
{
    public class Ronaldo: IJogador
    {
        private readonly string _nome;

        public Ronaldo(string nome)
        {
            this._nome = nome;
        }

        public string chuta() { return $"o jogador {this._nome} está bem agorinha chutando \n"; }
        public string corre() { return $"o jogador {this._nome} está bem agorinha correndo \n"; }
        public string passa() { return $"o jogador {this._nome} está bem agorinha passando \n"; }
        public string marca() { return $"o jogador {this._nome} está bem agorinha marcando \n"; }

    }

}
