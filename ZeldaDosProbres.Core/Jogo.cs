using System.Collections.Generic;
using ZeldaDosProbres.Core.Armas;
using ZeldaDosProbres.Core.Niveis;
using ZeldaDosProbres.Core.Personagens;
using ZeldaDosProbres.Core.Pocoes;

namespace ZeldaDosProbres.Core
{
    public class Jogo
    {
        public Nivel Nivel { get; private set; }
        public Jogador Jogador { get; private set; }
        public List<Arma> Armas { get; private set; }
        public List<Pocao> Pocoes { get; private set; }
        public Masmorra Masmorra { get; private set; }

        public void Inicia()
        {
            Jogador = new Jogador(this);
            Masmorra = new Masmorra();
            Nivel = new Nivel1(this);
            Armas = new List<Arma> { new Espada(), new Arco(), new Bastao() };
            Pocoes = new List<Pocao> { new PocaoAzul(), new PocaoVermelha() };
        }
    }
}