using System;
using System.ComponentModel;
using System.Drawing;

namespace ZeldaDosProbres.Core.Personagens
{
    public abstract class Personagem : INotifyPropertyChanged
    {
        private Point localizacao;
        private const int TamanhoDoPasso = 5;

        protected Personagem(Jogo jogo, int forca, int velocidade)
        {
            Jogo = jogo;
            Forca = forca;
            Velocidade = velocidade;
        }

        public int Forca { get; protected set; }
        public int Saude { get; protected set; }
        public int Velocidade { get; protected set; }

        public Point Localizacao
        {
            get { return localizacao; }
            protected set
            {
                localizacao = value;

                OnPropertyChanged("Localizacao");
            }
        }

        public Jogo Jogo { get; protected set; }

        public void Move(Direcao direcao)
        {
            switch (direcao)
            {
                case Direcao.Cima:
                    Localizacao = Localizacao.Y - TamanhoDoPasso >= 0
                        ? new Point(Localizacao.X, Localizacao.Y - TamanhoDoPasso)
                        : new Point(Localizacao.X, 0);
                    break;

                case Direcao.Baixo:
                    Localizacao = Localizacao.Y + TamanhoDoPasso <= 156
                        ? new Point(Localizacao.X, Localizacao.Y + TamanhoDoPasso)
                        : new Point(Localizacao.X, 156);
                    break;

                case Direcao.Direita:
                    Localizacao = Localizacao.X + TamanhoDoPasso <= 418
                        ? new Point(Localizacao.X + TamanhoDoPasso, Localizacao.Y)
                        : new Point(418, Localizacao.Y);
                    break;

                case Direcao.Esquerda:
                    Localizacao = Localizacao.X - TamanhoDoPasso >= 0
                        ? new Point(Localizacao.X - TamanhoDoPasso, Localizacao.Y)
                        : new Point(0, Localizacao.Y);
                    break;
            }
        }

        public abstract void Inicia();

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;

            if (handler != null) 
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
