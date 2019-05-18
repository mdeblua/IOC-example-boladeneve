using System;
using IOC.Interface;

namespace IOC
{
    public class Jogo
    {
        private readonly IJogador _jogador;

        public Jogo(IJogador jogador) => this._jogador = jogador ?? throw new ArgumentNullException(nameof(jogador));

        public void iniciarJogo()
        {
            Console.Write( _jogador.chuta());
            Console.Write( _jogador.corre());
            Console.Write( _jogador.marca());
            Console.Write( _jogador.passa());
        }
    }
}