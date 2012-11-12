using System.Drawing;
using NUnit.Framework;
using ZeldaDosProbres.Core;
using ZeldaDosProbres.Core.Personagens;

namespace ZeldaDosPobres.Test
{
    [TestFixture]
    public class QuandoUmPersonagemSeMovimenta
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
        public void MoveParaBaixo()
        {
            Point localizacaoAntiga = jogo.Jogador.Localizacao;
            jogo.Jogador.Move(Direcao.Baixo);

            Assert.That(jogo.Jogador.Localizacao.Y, Is.EqualTo(localizacaoAntiga.Y + jogo.Jogador.TamanhoDoPasso));
            Assert.That(jogo.Jogador.Localizacao.X, Is.EqualTo(localizacaoAntiga.X));
        }

        [Test]
        public void MoveParaCima()
        {
            Point localizacaoAntiga = jogo.Jogador.Localizacao;
            jogo.Jogador.Move(Direcao.Cima);

            Assert.That(jogo.Jogador.Localizacao.Y, Is.EqualTo(localizacaoAntiga.Y - jogo.Jogador.TamanhoDoPasso));
            Assert.That(jogo.Jogador.Localizacao.X, Is.EqualTo(localizacaoAntiga.X));
        }

        [Test]
        public void MoveParaDireita()
        {
            Point localizacaoAntiga = jogo.Jogador.Localizacao;
            jogo.Jogador.Move(Direcao.Direita);

            Assert.That(jogo.Jogador.Localizacao.X, Is.EqualTo(localizacaoAntiga.X + jogo.Jogador.TamanhoDoPasso));
            Assert.That(jogo.Jogador.Localizacao.Y, Is.EqualTo(localizacaoAntiga.Y));
        }

        [Test]
        public void MoveParaEsquerda()
        {
            jogo.Jogador.MovePara(new Point(jogo.Jogador.Velocidade, 0));
            Point localizacaoAntiga = jogo.Jogador.Localizacao;
            jogo.Jogador.Move(Direcao.Esquerda);

            Assert.That(jogo.Jogador.Localizacao.X, Is.EqualTo(localizacaoAntiga.X - jogo.Jogador.TamanhoDoPasso));
            Assert.That(jogo.Jogador.Localizacao.Y, Is.EqualTo(localizacaoAntiga.Y));
        }

        [Test]
        public void NaoPassaDaExtremidadeDireita()
        {
            Personagem jogador = jogo.Jogador;
            var extremidadeDireita = new Point(418, 0);

            jogador.MovePara(extremidadeDireita);
            jogador.Move(Direcao.Direita);

            Assert.That(jogador.Localizacao, Is.EqualTo(extremidadeDireita));
        }

        [Test]
        public void NaoPassaDaExtremidadeEsquerda()
        {
            Personagem jogador = jogo.Jogador;
            var extremidadeEsquerda = new Point(0, 0);

            jogador.MovePara(extremidadeEsquerda);
            jogador.Move(Direcao.Esquerda);

            Assert.That(jogador.Localizacao, Is.EqualTo(extremidadeEsquerda));
        }

        [Test]
        public void NaoPassaDaExtremidadeInferior()
        {
            Personagem jogador = jogo.Jogador;
            var extremidadeInferior = new Point(0, 156);

            jogador.MovePara(extremidadeInferior);
            jogador.Move(Direcao.Baixo);

            Assert.That(jogador.Localizacao, Is.EqualTo(extremidadeInferior));
        }

        [Test]
        public void NaoPassaDaExtremidadeSuperior()
        {
            Personagem jogador = jogo.Jogador;
            var extremidadeSuperior = new Point(0, 0);

            jogador.MovePara(extremidadeSuperior);
            jogador.Move(Direcao.Cima);

            Assert.That(jogador.Localizacao, Is.EqualTo(extremidadeSuperior));
        }
    }
}