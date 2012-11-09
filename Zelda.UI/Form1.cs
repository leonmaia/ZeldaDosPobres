using System.Windows.Forms;
using ZeldaDosPobres.UI.Avatares;
using ZeldaDosProbres.Core;

namespace ZeldaDosPobres.UI
{
    public partial class Form1 : Form
    {
        private Jogo jogo;
        private Jogador jogador;

        public Form1()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();

            Load += (sender, args) =>
            {
                jogo = new Jogo();
                jogador = new Jogador(jogo.Jogador);

                masmorra.Controls.Add(jogador.Imagem);

                foreach (var inimigo in jogo.Nivel.Inimigos)
                    masmorra.Controls.Add(new Morcego(inimigo).Imagem);

                jogo.Inicia();
            };
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                jogador.MoveParaCima();
            else if (e.KeyCode == Keys.Down)
                jogador.MoveParaBaixo();
            else if (e.KeyCode == Keys.Left)
                jogador.MoveParaEsquerda();
            else if (e.KeyCode == Keys.Right)
                jogador.MoveParaDireita();
        }
    }
}
