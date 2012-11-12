using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeldaDosPobres.UI.Properties;
using ZeldaDosProbres.Core.Itens.Armas;

namespace ZeldaDosPobres.UI.Avatares
{
    class Espada
    {
        private readonly Arma arma;

        public Espada(Arma arma)
        {
            this.arma = arma;
            Imagem = new PictureBox
            {
                Image = Resources.sword,
                SizeMode = PictureBoxSizeMode.AutoSize,
                BackColor = Color.Transparent,
                Location = new Point(arma.Localizacao.X + 76, arma.Localizacao.Y + 58)
            };
        }

        public PictureBox Imagem { get; protected set; }
        protected Arma Arma { get { return arma; } }

    }
}
