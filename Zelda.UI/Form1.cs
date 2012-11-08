using System.Windows.Forms;
using ZeldaDosProbres.Core;
using ZeldaDosProbres.Core.Personagens;
using ZeldaDosProbres.Core.Personagens.Inimigos;

namespace ZeldaDosPobres.UI
{
    public partial class Form1 : Form
    {
        private readonly Jogo jogo;
        private readonly Avatar avatar;
        private readonly Avatar inimigo;


        public Form1()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();

            jogo = new Jogo();
            jogo.Inicia();

            avatar = new Avatar(jogo.Personagem);
            inimigo = new Avatar(jogo.Nivel.Inimigos[0]);

            masmorra.Controls.Add(avatar.Imagem);
            masmorra.Controls.Add(inimigo.Imagem);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
                avatar.MoveParaCima();
            else if(e.KeyCode == Keys.Down)
                avatar.MoveParaBaixo();
            else if (e.KeyCode == Keys.Left)
                avatar.MoveParaEsquerda();
            else if (e.KeyCode == Keys.Right)
                avatar.MoveParaDireita();



        }
    }
}
