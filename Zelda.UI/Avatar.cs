using System.Drawing;
using System.Windows.Forms;
using ZeldaDosPobres.UI.Properties;
using ZeldaDosProbres.Core.Personagens;

namespace ZeldaDosPobres.UI
{
    public class Avatar
    {
        private readonly Jogador jogador;

        public Avatar(Jogador jogador)
        {
            Imagem = new PictureBox
            {
                Image     = Resources.player, 
                SizeMode  = PictureBoxSizeMode.AutoSize, 
                BackColor = Color.Transparent
            };
            
            this.jogador = jogador;

            AtualizaLocalizacao();
        }

        public PictureBox Imagem { get; private set; }

        private void AtualizaLocalizacao()
        {
            Imagem.Location = new Point(jogador.Localizacao.X + 76, jogador.Localizacao.Y + 58);
        }

        public void MoveParaCima()
        {
            jogador.Move(Direcao.Cima);
            AtualizaLocalizacao();
        }

        public void MoveParaBaixo()
        {
            jogador.Move(Direcao.Baixo);
            AtualizaLocalizacao();
        }

        public void MoveParaEsquerda()
        {
            jogador.Move(Direcao.Esquerda);
            AtualizaLocalizacao();
        }

        public void MoveParaDireita()
        {
            jogador.Move(Direcao.Direita);
            AtualizaLocalizacao();
        }
    }
}
