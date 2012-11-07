
using System;
using System.Drawing;

namespace ZeldaDosProbres.Core
{
    public abstract class Personagem
    {
        protected Personagem(Jogo jogo,int forca)
        {
            Jogo = jogo;
            Forca = forca;
        }

        public int Forca { get; protected set; }
        public int Saude { get; protected set; }
        public Point Localizacao { get; protected set; }
        public Jogo Jogo { get; protected set; }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Ataca()
        {
            throw new NotImplementedException();
        }

        public virtual bool EstaProximo()
        {
            throw new NotImplementedException();
        }
    }
}
