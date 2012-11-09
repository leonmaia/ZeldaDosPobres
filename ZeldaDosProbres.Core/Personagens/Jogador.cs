using System.Drawing;

namespace ZeldaDosProbres.Core.Personagens
{
    public class Jogador : Personagem
    {
        public Jogador(Jogo jogo)
            : base(jogo, 0, 10)
        {

        }

        public override void Inicia()
        {
            var localizacao = new Point(0, 75);
            Jogo.Jogador.MovePara(localizacao);
        }
    }
}