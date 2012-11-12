using System;
using System.Collections.Generic;
using ZeldaDosProbres.Core.Itens.Armas;
using ZeldaDosProbres.Core.Itens.Pocoes;
using ZeldaDosProbres.Core.Niveis;
using ZeldaDosProbres.Core.Personagens;

namespace ZeldaDosProbres.Core
{
    public class Jogo
    {
        public Random Random;

        public Jogo()
        {
            Jogador = new Jogador(this);
            Masmorra = new Masmorra();
            Random = new Random();
            Nivel = new Nivel1(this);
            Armas = new List<Arma> { new Espada(), new Arco(), new Bastao() };
            Pocoes = new List<Pocao> { new PocaoAzul(), new PocaoVermelha() };
        }

        public Nivel Nivel { get; private set; }
        public Jogador Jogador { get; private set; }
        public List<Arma> Armas { get; private set; }
        public List<Pocao> Pocoes { get; private set; }
        public Masmorra Masmorra { get; private set; }

        public void Inicia()
        {
            Nivel.Inicia();
        }
    }
}