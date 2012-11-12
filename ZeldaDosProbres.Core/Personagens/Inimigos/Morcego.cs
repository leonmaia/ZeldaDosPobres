using System.Drawing;

namespace ZeldaDosProbres.Core.Personagens.Inimigos
{
    public class Morcego : Inimigo
    {
        public Morcego(Jogo jogo)
            : base(jogo, 2, 100, 5, 50)
        {
        }

        public override bool EstaProximo(Point localizacao)
        {
            throw new System.NotImplementedException();
        }
    }
}