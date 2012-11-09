using System.Drawing;
using System.Windows.Forms;
using ZeldaDosPobres.UI.Properties;
using ZeldaDosProbres.Core.Personagens;

namespace ZeldaDosPobres.UI.Avatares
{
    class Morcego : Avatar
    {
        public Morcego(Personagem personagem)
            : base(personagem)
        {
            Imagem = new PictureBox
            {
                Image = Resources.bat,
                SizeMode = PictureBoxSizeMode.AutoSize,
                BackColor = Color.Transparent
            };
        }

        
    }
}
