using System.Windows.Forms;
using ZeldaDosPobres.UI.Avatares;
using ZeldaDosProbres.Core;
using ZeldaDosProbres.Core.Personagens.Inimigos;
using Morcego = ZeldaDosPobres.UI.Avatares.Morcego;

namespace ZeldaDosPobres.UI
{
    public partial class Form1 : Form
    {
        private Jogador jogador;
        private Jogo jogo;

        public Form1()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();

            Load += (sender, args) =>
                        {
                            jogo = new Jogo();
                            jogador = new Jogador(jogo.Jogador);
                            
                            masmorra.Controls.Add(jogador.Imagem);

                            foreach (Inimigo inimigo in jogo.Nivel.Inimigos)
                                masmorra.Controls.Add(new Morcego(inimigo).Imagem);

                            masmorra.Controls.Add(new Espada(jogo.Nivel.ArmaNoRecinto).Imagem);
                            jogo.Inicia();
                        };
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    jogador.MoveParaCima();
                    break;
                case Keys.Down:
                    jogador.MoveParaBaixo();
                    break;
                case Keys.Left:
                    jogador.MoveParaEsquerda();
                    break;
                case Keys.Right:
                    jogador.MoveParaDireita();
                    break;
                case Keys.Space:
                    jogador.Ataca();
                    break;
            }
        }
    }
}