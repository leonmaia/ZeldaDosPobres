using System.Drawing;
using System.Windows.Forms;
using ZeldaDosPobres.UI.Properties;
using ZeldaDosProbres.Core.Personagens;

namespace ZeldaDosPobres.UI
{
    public class Avatar
    {
        private readonly Personagem personagem;

        public Avatar(Personagem personagem)
        {
            if (personagem is Jogador)
            {
                Imagem = new PictureBox
                {
                    Image = Resources.link,
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    BackColor = Color.Transparent
                };
            }
            else
            {
                Imagem = new PictureBox
                {
                    Image = Resources.bat,
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    BackColor = Color.Transparent
                };
            }


            this.personagem = personagem;

            AtualizaLocalizacao();
        }

        public PictureBox Imagem { get; private set; }

        private void AtualizaLocalizacao()
        {
            if (personagem is Jogador)
                Imagem.Location = new Point(personagem.Localizacao.X + 76, personagem.Localizacao.Y + 58);
            else
                Imagem.Location = new Point(personagem.Localizacao.X + 76, personagem.Localizacao.Y + 58);
        }

        public void MoveParaCima()
        {
            personagem.Move(Direcao.Cima);
            AtualizaLocalizacao();
        }

        public void MoveParaBaixo()
        {
            personagem.Move(Direcao.Baixo);
            AtualizaLocalizacao();
        }

        public void MoveParaEsquerda()
        {
            personagem.Move(Direcao.Esquerda);
            AtualizaLocalizacao();
        }

        public void MoveParaDireita()
        {
            personagem.Move(Direcao.Direita);
            AtualizaLocalizacao();
        }
    }
}
