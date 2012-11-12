using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using ZeldaDosProbres.Core.Itens.Armas;

namespace ZeldaDosProbres.Core.Personagens
{
    public class Jogador : Personagem
    {

        public Jogador(Jogo jogo)
            : base(jogo, 0, 10, 50)
        { }

        public override void Inicia()
        {
            var localizacao = new Point(0, 75);
            Jogo.Jogador.MovePara(localizacao);
        }

        public Arma ArmaEquipada { get; set; }

        public override void Ataca()
        {
            foreach (var inimigo in Jogo.Nivel.Inimigos.Where(inimigo => EstaProximo(inimigo.Localizacao)))
                inimigo.AplicaDano(ArmaEquipada.Dano);
        }

        public void Equipa()
        {

        }

        public override bool EstaProximo(Point localizacao)
        {
            var quadradoJogador = new Rectangle(Localizacao.X, Localizacao.Y, 30, 30);
            var quadradoInimigo = new Rectangle(localizacao.X, localizacao.Y, 50, 50);
            var quadradoAlcance = Rectangle.Union(quadradoJogador, new Rectangle(0, 0, ArmaEquipada.Alcance, ArmaEquipada.Alcance));

            return quadradoAlcance.IntersectsWith(quadradoInimigo);
        }
    }
}