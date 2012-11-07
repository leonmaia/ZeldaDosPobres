using System.Collections.Generic;

namespace ZeldaDosProbres.Core
{
    public class Jogo
    {
        public Nivel Nivel { get; private set; }
        public Jogador Jogador { get; private set; }
        public List<Arma> Armas { get; private set; }
        public List<Pocao> Pocoes { get; private set; }
        public Masmorra Masmorra; 

        public void Inicia()
        {
            Nivel = new Nivel1(this);
            Jogador = new Jogador(this);
            Masmorra = new Masmorra();
            Armas = new List<Arma> { new Espada(), new Arco(), new Bastao() };
            Pocoes = new List<Pocao> { new PocaoAzul(), new PocaoVermelha() };
        }
    }
}