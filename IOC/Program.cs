using IOC.lib;

namespace IOC
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Jogo(new Maradona("Maradona"));
            jogo.iniciarJogo();
            var jogo1 = new Jogo(new Ronaldo("Ronaldo"));
            jogo1.iniciarJogo();    
            var jogo2 = new Jogo(new Blois("Blois"));
            jogo2.iniciarJogo();  
        }
    }

}
