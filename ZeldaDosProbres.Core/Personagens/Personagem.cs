using System;
using System.Drawing;

namespace ZeldaDosProbres.Core.Personagens
{
    public abstract class Personagem
    {
        protected Personagem(Jogo jogo, int forca, int velocidade)
        {
            Jogo = jogo;
            Forca = forca;
            Velocidade = velocidade;
        }

        public int Forca { get; protected set; }
        public int Saude { get; protected set; }
        public Point Localizacao { get; protected set; }
        public Jogo Jogo { get; protected set; }
        public int Velocidade { get; protected set; }

        public void Move(Direcao direcao)
        {
            switch (direcao)
            {
                case Direcao.Cima:
                    Localizacao = Localizacao.Y - Velocidade >= 0
                        ? new Point(Localizacao.X, Localizacao.Y - Velocidade)
                        : new Point(Localizacao.X, 0);
                    break;

                case Direcao.Baixo:
                    Localizacao = Localizacao.Y + Velocidade <= 156
                        ? new Point(Localizacao.X, Localizacao.Y + Velocidade)
                        : new Point(Localizacao.X, 156);
                    break;

                case Direcao.Direita:
                    Localizacao = Localizacao.X + Velocidade <= 418
                        ? new Point(Localizacao.X + Velocidade, Localizacao.Y)
                        : new Point(418, Localizacao.Y);
                    break;

                case Direcao.Esquerda:
                    Localizacao = Localizacao.X - Velocidade >= 0
                        ? new Point(Localizacao.X - Velocidade, Localizacao.Y)
                        : new Point(0, Localizacao.Y);
                    break;
            }
        }

        public void MovePara(Point novaLocalizacao)
        {
            Localizacao = novaLocalizacao;
        }

        public void Ataca()
        {
            throw new NotImplementedException();
        }

        public virtual bool EstaProximo()
        {
            throw new NotImplementedException();
        }
    }
}
