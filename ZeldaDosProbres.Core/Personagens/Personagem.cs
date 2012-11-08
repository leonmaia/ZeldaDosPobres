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
                    if (Localizacao.Y - Velocidade >= 0)
                        Localizacao = new Point(Localizacao.X, Localizacao.Y - Velocidade);
                    else
                        Localizacao = new Point(Localizacao.X, 0);
                    break;

                case Direcao.Baixo:
                    if (Localizacao.Y + Velocidade <= 156)
                        Localizacao = new Point(Localizacao.X, Localizacao.Y + Velocidade);
                    else
                        Localizacao = new Point(Localizacao.X, 156);
                    break;

                case Direcao.Direita:
                    if (Localizacao.X + Velocidade <= 418)
                        Localizacao = new Point(Localizacao.X + Velocidade, Localizacao.Y);
                    else
                        Localizacao = new Point(418, Localizacao.Y);
                    break;

                case Direcao.Esquerda:
                    if (Localizacao.X - Velocidade >= 0)
                        Localizacao = new Point(Localizacao.X - Velocidade, Localizacao.Y);
                    else
                        Localizacao = new Point(0, Localizacao.Y);
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
