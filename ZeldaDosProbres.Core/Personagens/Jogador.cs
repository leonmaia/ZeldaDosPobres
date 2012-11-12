using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using ZeldaDosProbres.Core.Itens;
using ZeldaDosProbres.Core.Itens.Armas;
using ZeldaDosProbres.Core.Personagens.Inimigos;

namespace ZeldaDosProbres.Core.Personagens
{
    public class Jogador : Personagem
    {
        private List<Item> inventario; 

        public Jogador(Jogo jogo)
            : base(jogo, 0, 10, 100)
        {
            Inventario = new List<Item>();
        }

        public List<Item> Inventario
        {
            get { return inventario; }
            set
            {
                inventario = value;
                OnPropertyChanged("Inventario");
            }
        }

        public override void Inicia()
        {
            var localizacao = new Point(0, 75);
            MovePara(localizacao);
        }

        public Arma ArmaEquipada { get; set; }

        public override void Atacar()
        {
            var inimigosMortos = new List<Inimigo>();
            ArmaEquipada = new Espada();
            foreach (var inimigo in Jogo.Nivel.Inimigos.Where(inimigo => EstaProximo(inimigo.Localizacao)))
            {
                inimigo.AplicaDano(ArmaEquipada.Dano);

                if (inimigo.EstaMorto)
                    inimigosMortos.Add(inimigo);
            }

            foreach (var inimigoMorto in inimigosMortos)
                Jogo.Nivel.Inimigos.Remove(inimigoMorto);
        }

        public void ColetarArma()
        {
            Inventario.Add(Jogo.Nivel.ArmaNoRecinto);
        }

        public bool ArmaNaProximidade(Point localizacao)
        {
            var quadradoJogador = new Rectangle(Localizacao.X, Localizacao.Y, 30, 30);
            var quadradoArma = new Rectangle(localizacao.X, localizacao.Y, 50, 50);

            return quadradoJogador.IntersectsWith(quadradoArma);
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