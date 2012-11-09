using System.Collections.Generic;
using ZeldaDosProbres.Core.Armas;
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
            Inimigos = new List<Inimigo> { new Morcego(jogo) };
        }
    }
}