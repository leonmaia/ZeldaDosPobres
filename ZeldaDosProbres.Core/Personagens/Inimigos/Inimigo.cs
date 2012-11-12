using System;
using System.Drawing;
using System.Timers;

namespace ZeldaDosProbres.Core.Personagens.Inimigos
{
    public abstract class Inimigo : Personagem
    {
        protected Inimigo(Jogo jogo, int forca, int velocidade, int chanceIrEmDirecaoAoJogador, int saude)
            : base(jogo, forca, velocidade, saude)
        {
            Random = new Random();
            ChanceIrEmDirecaoAoJogador = chanceIrEmDirecaoAoJogador;
        }

        public int ChanceIrEmDirecaoAoJogador { get; set; }
        public Random Random { get; set; }

        public override void Inicia()
        {
            MovePara(Aleatorio.RandomizaLocalizacao());

            var checkForTime = new Timer(Velocidade);
            checkForTime.Elapsed += ExecutaMovimentacao;
            checkForTime.Enabled = true;
        }

        private void ExecutaMovimentacao(object sender, ElapsedEventArgs e)
        {
            Move(Random.Next(1, 10) <= ChanceIrEmDirecaoAoJogador
                     ? EncontrarDirecaoDoJogador()
                     : Aleatorio.RandomizaDirecao());
        }

        protected Direcao EncontrarDirecaoDoJogador()
        {
            Direcao direcaoParaSeMovimentar;

            if (Jogo.Jogador.Localizacao.X > Localizacao.X + 10)
                direcaoParaSeMovimentar = Direcao.Direita;
            else if (Jogo.Jogador.Localizacao.X < Localizacao.X - 10)
                direcaoParaSeMovimentar = Direcao.Esquerda;
            else if (Jogo.Jogador.Localizacao.Y < Localizacao.Y - 10)
                direcaoParaSeMovimentar = Direcao.Cima;
            else
                direcaoParaSeMovimentar = Direcao.Baixo;

            return direcaoParaSeMovimentar;
        }

        public override void Ataca()
        {

        }

        public override bool EstaProximo(Point localizacao)
        {
            var quadradoJogador = new Rectangle(localizacao.X, localizacao.Y, 30, 30);
            var quadradoInimigo = new Rectangle(Localizacao.X, Localizacao.Y, 50, 50);

            return quadradoInimigo.IntersectsWith(quadradoJogador);
        }
    }
}