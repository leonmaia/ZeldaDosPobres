using System.Drawing;

namespace ZeldaDosProbres.Core.Itens.Armas
{
    public class Arma : Item
    {
        public int Alcance { get; protected set; }
        public int Dano { get; protected set; }

        public Arma(int alcance, int dano)
        {
            Alcance = alcance;
            Dano = dano;
        }
        public void MovePara(Point novaLocalizacao)
        {
            Localizacao = novaLocalizacao;
        }
    }
}