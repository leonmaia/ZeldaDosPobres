﻿using System;

namespace ZeldaDosProbres.Core.Personagens.Inimigos
{
    public abstract class Inimigo : Personagem
    {
        protected Inimigo(Jogo jogo, int forca, int velocidade)
            : base(jogo, forca, velocidade)
        {

        }

        public override bool EstaProximo()
        {
            throw new NotImplementedException();
        }
    }
}