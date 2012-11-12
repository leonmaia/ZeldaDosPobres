using System.Collections.Generic;
using ZeldaDosProbres.Core.Itens.Armas;
using ZeldaDosProbres.Core.Personagens.Inimigos;

namespace ZeldaDosProbres.Core.Niveis
{
    public class Nivel1 : Nivel
    {
        public Nivel1(Jogo jogo)
            : base(jogo)
        {
            Nome = "Cabana dos mussegu";
            ArmaNoRecinto = new Espada();
            ArmaNoRecinto.MovePara(Aleatorio.RandomizaLocalizacao());
            Inimigos = new List<Inimigo> { new Morcego(jogo) };
        }
    }
}