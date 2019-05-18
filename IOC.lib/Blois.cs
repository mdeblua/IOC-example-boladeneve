
using IOC.Interface;

namespace IOC.lib
{
    public class Blois: IJogador
    {
        private readonly string _nome;

        public Blois(string nome)
        {
            this._nome = nome;
        }

        public string chuta() { return $"o jogador {this._nome} está animalmente chutando \n"; }
        public string corre() { return $"o jogador {this._nome} está animalmente correndo \n"; }
        public string passa() { return $"o jogador {this._nome} está animalmente passando \n"; }
        public string marca() { return $"o jogador {this._nome} está animalmente marcando \n"; }

    }

}
