
using IOC.Interface;

namespace IOC.lib
{
    public class Maradona: IJogador
    {
        private readonly string _nome;

        public Maradona(string nome)
        {
            this._nome = nome;
        }

        public string chuta() { return $"o jogador {this._nome} estás biem agorinha chutiando \n"; }
        public string corre() { return $"o jogador {this._nome} estás biem agorinha corriendo \n"; }
        public string passa() { return $"o jogador {this._nome} estás biem agorinha passiando \n"; }
        public string marca() { return $"o jogador {this._nome} estás biem agorinha marciando \n"; }

    }

}
