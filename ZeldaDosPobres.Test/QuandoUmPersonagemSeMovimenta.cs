using System.Drawing;
using NUnit.Framework;
using ZeldaDosProbres.Core;

namespace ZeldaDosPobres.Test
{
    [TestFixture]
    public class QuandoUmPersonagemSeMovimenta
    {
        private Jogo jogo;

        [SetUp]
        public void Cenario()
        {
            jogo = new Jogo();
            jogo.Inicia();
        }

        [Test]
        public void MoveParaCima()
        {
            var localizacaoAntiga = jogo.Jogador.Localizacao;
            jogo.Jogador.Move(Direcao.Cima);

            Assert.That(jogo.Jogador.Localizacao.Y, Is.EqualTo(localizacaoAntiga.Y - jogo.Jogador.Velocidade));
            Assert.That(jogo.Jogador.Localizacao.X, Is.EqualTo(localizacaoAntiga.X));
        }

        [Test]
        public void MoveParaBaixo()
        {
            var localizacaoAntiga = jogo.Jogador.Localizacao;
            jogo.Jogador.Move(Direcao.Baixo);

            Assert.That(jogo.Jogador.Localizacao.Y, Is.EqualTo(localizacaoAntiga.Y + jogo.Jogador.Velocidade));
            Assert.That(jogo.Jogador.Localizacao.X, Is.EqualTo(localizacaoAntiga.X));
        }

        [Test]
        public void MoveParaDireita()
        {
            var localizacaoAntiga = jogo.Jogador.Localizacao;
            jogo.Jogador.Move(Direcao.Direita);

            Assert.That(jogo.Jogador.Localizacao.X, Is.EqualTo(localizacaoAntiga.X + jogo.Jogador.Velocidade));
            Assert.That(jogo.Jogador.Localizacao.Y, Is.EqualTo(localizacaoAntiga.Y));
        }

        [Test]
        public void MoveParaEsquerda()
        {
            jogo.Jogador.MovePara(new Point(jogo.Jogador.Velocidade, 0));
            var localizacaoAntiga = jogo.Jogador.Localizacao;
            jogo.Jogador.Move(Direcao.Esquerda);

            Assert.That(jogo.Jogador.Localizacao.X, Is.EqualTo(localizacaoAntiga.X - jogo.Jogador.Velocidade));
            Assert.That(jogo.Jogador.Localizacao.Y, Is.EqualTo(localizacaoAntiga.Y));
        }

        [Test]
        public void NaoPassarDaExtremidadeSuperior()
        {
            var jogador = jogo.Jogador;
            var extremidadeSuperior = new Point(0, 0);

            jogador.MovePara(extremidadeSuperior);
            jogador.Move(Direcao.Cima);

            Assert.That(jogador.Localizacao, Is.EqualTo(extremidadeSuperior));
        }

        [Test]
        public void NaoPassarDaExtremidadeInferior()
        {
            var jogador = jogo.Jogador;
            var extremidadeInferior = new Point(0, 136);

            jogador.MovePara(extremidadeInferior);
            jogador.Move(Direcao.Baixo);

            Assert.That(jogador.Localizacao, Is.EqualTo(extremidadeInferior));
        }

        [Test]
        public void NaoPassarDaExtremidadeEsquerda()
        {
            var jogador = jogo.Jogador;
            var extremidadeEsquerda = new Point(0, 0);

            jogador.MovePara(extremidadeEsquerda);
            jogador.Move(Direcao.Esquerda);

            Assert.That(jogador.Localizacao, Is.EqualTo(extremidadeEsquerda));
        }

        [Test]
        public void NaoPassarDaExtremidadeDireita()
        {
            var jogador = jogo.Jogador;
            var extremidadeDireita = new Point(398, 0);

            jogador.MovePara(extremidadeDireita);
            jogador.Move(Direcao.Direita);

            Assert.That(jogador.Localizacao, Is.EqualTo(extremidadeDireita));
        }

    }
}
