using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeldaDosProbres.Core
{
    public abstract class Inimigo : Personagem
    {
        protected Inimigo(Jogo jogo, int forca)
            : base(jogo, forca)
        {

        }

        public override bool EstaProximo()
        {
            //return Localizacao.X - 
            return true;
        }

    }
}
