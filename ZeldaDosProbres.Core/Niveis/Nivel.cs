using System.Collections.Generic;
using System.Drawing;
using ZeldaDosProbres.Core.Armas;
using ZeldaDosProbres.Core.Personagens;

namespace ZeldaDosProbres.Core.Niveis
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
            var localizacao = new Point(0, 75);
            Jogo.Personagem.MovePara(localizacao);
        }
    }
}