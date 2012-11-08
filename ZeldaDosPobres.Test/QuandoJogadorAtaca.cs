using NUnit.Framework;
using ZeldaDosProbres.Core;
using ZeldaDosProbres.Core.Excecoes;

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
            Assert.Throws<NaoHaInimigoPerto>(() => jogo.Personagem.Ataca());
        }
    }
}
