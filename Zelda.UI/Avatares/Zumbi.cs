using System.Drawing;
using System.Windows.Forms;
using ZeldaDosPobres.UI.Properties;
using ZeldaDosProbres.Core.Personagens;

namespace ZeldaDosPobres.UI.Avatares
{
    internal class Zumbi : Avatar
    {
        public Zumbi(Personagem personagem)
            : base(personagem)
        {
            Imagem = new PictureBox
                         {
                             Image = Resources.ghoul,
                             SizeMode = PictureBoxSizeMode.AutoSize,
                             BackColor = Color.Transparent
                         };
        }
    }
}