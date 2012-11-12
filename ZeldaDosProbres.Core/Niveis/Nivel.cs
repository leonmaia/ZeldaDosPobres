using System.Collections.Generic;
using ZeldaDosProbres.Core.Itens.Armas;
using ZeldaDosProbres.Core.Personagens.Inimigos;

namespace ZeldaDosProbres.Core.Niveis
{
    public abstract class Nivel
    {
        protected Nivel(Jogo jogo)
        {
            Jogo = jogo;
        }

        public Jogo Jogo { get; protected set; }
        public string Nome { get; protected set; }
        public List<Inimigo> Inimigos { get; protected set; }
        public Arma ArmaNoRecinto { get; protected set; }

        public void Inicia()
        {
            Jogo.Jogador.Inicia();

            Inimigos.ForEach(i => i.Inicia());
        }
    }
}