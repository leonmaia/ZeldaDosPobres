using System.Drawing;
using System.Windows.Forms;
using ZeldaDosPobres.UI.Properties;
using ZeldaDosProbres.Core.Personagens;

namespace ZeldaDosPobres.UI.Avatares
{
    internal class Jogador : Avatar
    {
        public Jogador(Personagem personagem)
            : base(personagem)
        {
            Imagem = new PictureBox
                         {
                             Image = Resources.link,
                             SizeMode = PictureBoxSizeMode.AutoSize,
                             BackColor = Color.Transparent
                         };
            Centraliza();
        }

        private void Centraliza()
        {
            Imagem.Location = new Point(Personagem.Localizacao.X + 76, Personagem.Localizacao.Y + 58);
        }
    }
}