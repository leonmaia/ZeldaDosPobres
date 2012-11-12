using NUnit.Framework;
using ZeldaDosProbres.Core;
using ZeldaDosProbres.Core.Itens.Armas;
using ZeldaDosProbres.Core.Niveis;

namespace ZeldaDosPobres.Test
{
    [TestFixture]
    public class QuandoEstiverNoNivel1
    {
        #region Setup/Teardown

        [SetUp]
        public void Cenario()
        {
            jogo = new Jogo();
            jogo.Inicia();
            nivel1 = new Nivel1(jogo);
        }

        #endregion

        private Nivel1 nivel1;
        private Jogo jogo;

        [Test]
        public void DeveTerArmaNoRecinto()
        {
            Assert.That(nivel1.ArmaNoRecinto, Is.InstanceOf<Espada>());
        }

        [Test]
        public void DeveTerUmInimigo()
        {
            Assert.That(nivel1.Inimigos.Count, Is.EqualTo(1));
        }
    }
}