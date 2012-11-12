using System.Drawing;

namespace ZeldaDosProbres.Core.Personagens.Inimigos
{
    public class Zumbi : Inimigo
    {
        public Zumbi(Jogo jogo)
            : base(jogo, 100, 10, 5, 50)
        {
        }

        public override bool EstaProximo(Point localizacao)
        {
            throw new System.NotImplementedException();
        }
    }
}