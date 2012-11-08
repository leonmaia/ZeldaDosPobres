using System.Drawing;
using NUnit.Framework;
using ZeldaDosProbres.Core;

namespace ZeldaDosPobres.Test
{
    [TestFixture]
    public class QuandoIniciarUmNivel
    {
        private Jogo jogo;

        [SetUp]
        public void Cenario()
        {
            jogo = new Jogo();
            jogo.Inicia();
        }

        [Test]
        public void JogadorDeveEstarNaPorta()
        {
            Assert.That(jogo.Jogador.Localizacao, Is.EqualTo(new Point(0, 68)));
        }
    }
}
