using System;
using System.ComponentModel;
using System.Drawing;
using ZeldaDosProbres.Core.Personagens.Inimigos;

namespace ZeldaDosProbres.Core.Personagens
{
    public abstract class Personagem : INotifyPropertyChanged
    {
        private Point localizacao;
        private bool vivo;

        protected Personagem(Jogo jogo, int forca, int velocidade, int saude)
        {
            Jogo = jogo;
            Forca = forca;
            Velocidade = velocidade;
            TamanhoDoPasso = 5;
            Saude = saude;
            Vivo = true;
        }

        public int TamanhoDoPasso { get; protected set; }
        public int Forca { get; protected set; }
        public int Saude { get; protected set; }
        public int Velocidade { get; protected set; }
        public bool Vivo
        {
            get { return vivo; }
            private set
            {
                vivo = value;
                OnPropertyChanged("Vivo");
            }
        }
        public bool EstaMorto { get { return !Vivo; } }

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

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

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

            if (Jogo.Jogador.ArmaNaProximidade(Jogo.Nivel.ArmaNoRecinto.Localizacao))
                Jogo.Jogador.ColetarArma();
        }

        public abstract void Inicia();

        public void MovePara(Point novaLocalizacao)
        {
            Localizacao = novaLocalizacao;
        }

        public abstract void Atacar();

        public void AplicaDano(int dano)
        {
            Saude -= dano;

            if (Saude <= 0)
                Vivo = false;
        }

        public abstract bool EstaProximo(Point localizacao);

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}