using System.Collections.Generic;

namespace ZeldaDosProbres.Core
{
    public abstract class Nivel
    {
        protected Nivel(Jogo jogo)
        {
            Jogo = jogo;
        }

        public Jogo Jogo { get; protected set; }
        public string Nome { get; protected set; }
        public List<Personagem> Inimigos { get; protected set; }
        public Arma ArmaNoRecinto { get; protected set; }
    }
}