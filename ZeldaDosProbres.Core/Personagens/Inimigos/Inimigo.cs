using System;
using System.Timers;

namespace ZeldaDosProbres.Core.Personagens.Inimigos
{
    public abstract class Inimigo : Personagem
    {
        protected Inimigo(Jogo jogo, int forca, int velocidade)
            : base(jogo, forca, velocidade)
        {
            
        }

        public override void Inicia()
        {
            MovePara(Aleatorio.RandomizaLocalizacao());

            var checkForTime = new Timer(Velocidade);
            checkForTime.Elapsed += ExecutaMovimentacao;
            checkForTime.Enabled = true;
        }

        private void ExecutaMovimentacao(object sender, ElapsedEventArgs e)
        {
            Move(Aleatorio.RandomizaDirecao());
        }

        public override bool EstaProximo()
        {
            throw new NotImplementedException();
        }
    }
}