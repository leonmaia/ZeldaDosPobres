using System.Drawing;
using NUnit.Framework;
using ZeldaDosProbres.Core;
using ZeldaDosProbres.Core.Itens.Armas;

namespace ZeldaDosPobres.Test
{
    [TestFixture]
    internal class QuandoJogadorAtaca
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

        //[Test]
        //public void CancelaAtaqueSeNaoTiverInimigoPorPerto()
        //{
        //    Assert.Throws<NaoHaInimigoPerto>(() => jogo.Jogador.Ataca());
        //}

        [Test]
        public void VerificaSeInimigoEstaProximoADireitaComMesmoY()
        {
            jogo.Jogador.MovePara(new Point(100, 100));
            jogo.Jogador.ArmaEquipada = new Espada();
            jogo.Nivel.Inimigos[0].MovePara(new Point(110, 100));

            Assert.That(jogo.Jogador.EstaProximo(jogo.Nivel.Inimigos[0].Localizacao), Is.True);
        }

        [Test]
        public void VerificaSeInimigoEstaProximoAEsquerdaComMesmoY()
        {
            jogo.Jogador.MovePara(new Point(100, 100));
            jogo.Jogador.ArmaEquipada = new Espada();
            jogo.Nivel.Inimigos[0].MovePara(new Point(90, 100));

            Assert.That(jogo.Jogador.EstaProximo(jogo.Nivel.Inimigos[0].Localizacao), Is.True);
        }

        [Test]
        public void VerificaSeInimigoEstaProximoADireitaComYDiferente()
        {
            jogo.Jogador.MovePara(new Point(100, 100));
            jogo.Jogador.ArmaEquipada = new Espada();
            jogo.Nivel.Inimigos[0].MovePara(new Point(100, 110));

            Assert.That(jogo.Jogador.EstaProximo(jogo.Nivel.Inimigos[0].Localizacao), Is.True);
        }

        [Test]
        public void VerificaSeInimigoEstaProximoAEsquerdaComYDiferente()
        {
            jogo.Jogador.MovePara(new Point(100, 110));
            jogo.Jogador.ArmaEquipada = new Espada();
            jogo.Nivel.Inimigos[0].MovePara(new Point(100, 100));

            Assert.That(jogo.Jogador.EstaProximo(jogo.Nivel.Inimigos[0].Localizacao), Is.True);
        }

        [Test]
        public void VerificaSeInimigoLevouDano()
        {
            jogo.Jogador.MovePara(new Point(100, 110));
            jogo.Jogador.ArmaEquipada = new Espada();
            jogo.Nivel.Inimigos[0].MovePara(new Point(100, 100));
            var vida = jogo.Nivel.Inimigos[0].Saude;
            jogo.Jogador.Ataca();

            Assert.That((jogo.Nivel.Inimigos[0].Saude), Is.EqualTo(vida - jogo.Jogador.ArmaEquipada.Dano));
        }
    }
}