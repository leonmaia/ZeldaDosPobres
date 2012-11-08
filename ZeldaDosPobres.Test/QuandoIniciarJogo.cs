using System.Linq;
using NUnit.Framework;
using ZeldaDosProbres.Core;
using ZeldaDosProbres.Core.Armas;
using ZeldaDosProbres.Core.Niveis;
using ZeldaDosProbres.Core.Pocoes;

namespace ZeldaDosPobres.Test
{
    [TestFixture]
    public class QuandoIniciarJogo
    {
        private Jogo jogo;

        [SetUp]
        public void Cenario()
        {
            jogo = new Jogo();
            jogo.Inicia();
        }

        [Test]
        public void DeveTerUmaMasmorra()
        {
            Assert.That(jogo.Masmorra, Is.Not.Null);
        }

        [Test]
        public void DeveEstarNoNivel1()
        {
            Assert.That(jogo.Nivel, Is.InstanceOf<Nivel1>());
        }

        [Test]
        public void DeveTerUmJogador()
        {
            Assert.That(jogo.Personagem, Is.Not.Null);
        }

        [Test]
        public void DeveTerUmArco()
        {
            Assert.That(jogo.Armas.Any(arma => arma.GetType() == typeof(Arco)), Is.True);
        }

        [Test]
        public void DeveTerUmaEspada()
        {
            Assert.That(jogo.Armas.Any(arma => arma.GetType() == typeof(Espada)), Is.True);
        }

        [Test]
        public void DeveTerUmBastao()
        {
            Assert.That(jogo.Armas.Any(arma => arma.GetType() == typeof(Bastao)), Is.True);
        }

        [Test]
        public void DeveTerUmaPocaoAzul()
        {
            Assert.That(jogo.Pocoes.Any(pocao => pocao.GetType() == typeof(PocaoAzul)), Is.True);
        }

        [Test]
        public void DeveTerUmaPocaoVermelha()
        {
            Assert.That(jogo.Pocoes.Any(pocao => pocao.GetType() == typeof(PocaoVermelha)), Is.True);
        }

    }
}
