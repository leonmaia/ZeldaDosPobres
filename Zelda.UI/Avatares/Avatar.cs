using System;
using System.Drawing;
using System.Windows.Forms;
using ZeldaDosProbres.Core.Personagens;

namespace ZeldaDosPobres.UI.Avatares
{
    public abstract class Avatar
    {
        private readonly Personagem personagem;

        protected Avatar(Personagem personagem)
        {
            this.personagem = personagem;

            personagem.PropertyChanged += (sender, args) =>
            {
                Action atualizaLocalizacao = () => Imagem.Location = new Point(Personagem.Localizacao.X + 76
                    , Personagem.Localizacao.Y + 58);

                Imagem.BeginInvoke(atualizaLocalizacao);
            };
        }

        public PictureBox Imagem { get; protected set; }

        protected Personagem Personagem
        {
            get { return personagem; }
        }

        public void MoveParaCima()
        {
            personagem.Move(Direcao.Cima);
        }

        public void MoveParaBaixo()
        {
            personagem.Move(Direcao.Baixo);
        }

        public void MoveParaEsquerda()
        {
            personagem.Move(Direcao.Esquerda);
        }

        public void MoveParaDireita()
        {
            personagem.Move(Direcao.Direita);
        }

        public void Ataca()
        {
            personagem.Ataca();
        }

    }
}