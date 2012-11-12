using System.Linq;
using NUnit.Framework;
using ZeldaDosProbres.Core;
using ZeldaDosProbres.Core.Itens.Armas;
using ZeldaDosProbres.Core.Itens.Pocoes;
using ZeldaDosProbres.Core.Niveis;

namespace ZeldaDosPobres.Test
{
    [TestFixture]
    public class QuandoIniciarJogo
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
        public void DeveEstarNoNivel1()
        {
            Assert.That(jogo.Nivel, Is.InstanceOf<Nivel1>());
        }

        [Test]
        public void DeveTerUmArco()
        {
            Assert.That(jogo.Armas.Any(arma => arma.GetType() == typeof (Arco)), Is.True);
        }

        [Test]
        public void DeveTerUmBastao()
        {
            Assert.That(jogo.Armas.Any(arma => arma.GetType() == typeof (Bastao)), Is.True);
        }

        [Test]
        public void DeveTerUmJogador()
        {
            Assert.That(jogo.Jogador, Is.Not.Null);
        }

        [Test]
        public void DeveTerUmaEspada()
        {
            Assert.That(jogo.Armas.Any(arma => arma.GetType() == typeof (Espada)), Is.True);
        }

        [Test]
        public void DeveTerUmaMasmorra()
        {
            Assert.That(jogo.Masmorra, Is.Not.Null);
        }

        [Test]
        public void DeveTerUmaPocaoAzul()
        {
            Assert.That(jogo.Pocoes.Any(pocao => pocao.GetType() == typeof (PocaoAzul)), Is.True);
        }

        [Test]
        public void DeveTerUmaPocaoVermelha()
        {
            Assert.That(jogo.Pocoes.Any(pocao => pocao.GetType() == typeof (PocaoVermelha)), Is.True);
        }
    }
}