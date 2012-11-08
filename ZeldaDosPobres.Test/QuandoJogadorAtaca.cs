﻿using NUnit.Framework;
using ZeldaDosProbres.Core;

namespace ZeldaDosPobres.Test
{
    [TestFixture]
    class QuandoJogadorAtaca
    {
        private Jogo jogo;

        [SetUp]
        public void Cenario()
        {
            jogo = new Jogo();
            jogo.Inicia();
        }

        [Test]
        public void CancelaAtaqueSeNaoTiverInimigoPorPerto()
        {
            Assert.Throws<NaoHaInimigoPerto>(() => jogo.Jogador.Ataca());
        }
    }
}
