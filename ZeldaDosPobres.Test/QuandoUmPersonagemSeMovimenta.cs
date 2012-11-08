using System.Drawing;
using NUnit.Framework;
using ZeldaDosProbres.Core;
using ZeldaDosProbres.Core.Personagens;

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
            var localizacaoAntiga = jogo.Personagem.Localizacao;
            jogo.Personagem.Move(Direcao.Cima);

            Assert.That(jogo.Personagem.Localizacao.Y, Is.EqualTo(localizacaoAntiga.Y - jogo.Personagem.Velocidade));
            Assert.That(jogo.Personagem.Localizacao.X, Is.EqualTo(localizacaoAntiga.X));
        }

        [Test]
        public void MoveParaBaixo()
        {
            var localizacaoAntiga = jogo.Personagem.Localizacao;
            jogo.Personagem.Move(Direcao.Baixo);

            Assert.That(jogo.Personagem.Localizacao.Y, Is.EqualTo(localizacaoAntiga.Y + jogo.Personagem.Velocidade));
            Assert.That(jogo.Personagem.Localizacao.X, Is.EqualTo(localizacaoAntiga.X));
        }

        [Test]
        public void MoveParaDireita()
        {
            var localizacaoAntiga = jogo.Personagem.Localizacao;
            jogo.Personagem.Move(Direcao.Direita);

            Assert.That(jogo.Personagem.Localizacao.X, Is.EqualTo(localizacaoAntiga.X + jogo.Personagem.Velocidade));
            Assert.That(jogo.Personagem.Localizacao.Y, Is.EqualTo(localizacaoAntiga.Y));
        }

        [Test]
        public void MoveParaEsquerda()
        {
            jogo.Personagem.MovePara(new Point(jogo.Personagem.Velocidade, 0));
            var localizacaoAntiga = jogo.Personagem.Localizacao;
            jogo.Personagem.Move(Direcao.Esquerda);

            Assert.That(jogo.Personagem.Localizacao.X, Is.EqualTo(localizacaoAntiga.X - jogo.Personagem.Velocidade));
            Assert.That(jogo.Personagem.Localizacao.Y, Is.EqualTo(localizacaoAntiga.Y));
        }

        [Test]
        public void NaoPassaDaExtremidadeSuperior()
        {
            var jogador = jogo.Personagem;
            var extremidadeSuperior = new Point(0, 0);

            jogador.MovePara(extremidadeSuperior);
            jogador.Move(Direcao.Cima);

            Assert.That(jogador.Localizacao, Is.EqualTo(extremidadeSuperior));
        }

        [Test]
        public void NaoPassaDaExtremidadeInferior()
        {
            var jogador = jogo.Personagem;
            var extremidadeInferior = new Point(0, 156);

            jogador.MovePara(extremidadeInferior);
            jogador.Move(Direcao.Baixo);

            Assert.That(jogador.Localizacao, Is.EqualTo(extremidadeInferior));
        }

        [Test]
        public void NaoPassaDaExtremidadeEsquerda()
        {
            var jogador = jogo.Personagem;
            var extremidadeEsquerda = new Point(0, 0);

            jogador.MovePara(extremidadeEsquerda);
            jogador.Move(Direcao.Esquerda);

            Assert.That(jogador.Localizacao, Is.EqualTo(extremidadeEsquerda));
        }

        [Test]
        public void NaoPassaDaExtremidadeDireita()
        {
            var jogador = jogo.Personagem;
            var extremidadeDireita = new Point(418, 0);

            jogador.MovePara(extremidadeDireita);
            jogador.Move(Direcao.Direita);

            Assert.That(jogador.Localizacao, Is.EqualTo(extremidadeDireita));
        }
    }
}
