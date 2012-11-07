using System.Collections.Generic;

namespace ZeldaDosProbres.Core
{
    public class Nivel1 : Nivel
    {
        public Nivel1(Jogo jogo)
            : base(jogo)
        {
            Nome = "Cabana dos mussegu";
            ArmaNoRecinto = new Espada();
            Inimigos = new List<Personagem> { new Morcego(jogo) };
        }
    }
}
