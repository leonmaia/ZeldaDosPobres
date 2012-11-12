using System.Drawing;
using NUnit.Framework;
using ZeldaDosProbres.Core;

namespace ZeldaDosPobres.Test
{
    [TestFixture]
    public class QuandoIniciarUmNivel
    {
        #region Setup/Teardown

        [SetUp]
        public void Cenario()
        {
            jogo = new Jogo();
            jogo.Inicia();
        }

        #endregion

        private Jogo jogo;

        [Test]
        public void JogadorDeveEstarNaPorta()
        {
            Assert.That(jogo.Jogador.Localizacao, Is.EqualTo(new Point(0, 75)));
        }
    }
}