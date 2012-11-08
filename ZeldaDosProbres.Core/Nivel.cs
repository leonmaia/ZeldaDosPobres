using System.Collections.Generic;
using System.Drawing;

namespace ZeldaDosProbres.Core
{
    public abstract class Nivel
    {
        protected Nivel(Jogo jogo)
        {
            Jogo = jogo;
            Inicia();
        }

        public Jogo Jogo { get; protected set; }
        public string Nome { get; protected set; }
        public List<Personagem> Inimigos { get; protected set; }
        public Arma ArmaNoRecinto { get; protected set; }

        public void Inicia()
        {
            var localizacao = new Point(0,68);
            Jogo.Jogador.MovePara(localizacao);
        }
    }
}