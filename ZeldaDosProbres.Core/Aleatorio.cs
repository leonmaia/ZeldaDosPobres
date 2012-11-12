using System;
using System.Drawing;
using ZeldaDosProbres.Core.Personagens;

namespace ZeldaDosProbres.Core
{
    public static class Aleatorio
    {
        private static readonly Random Random;

        static Aleatorio()
        {
            Random = new Random();
        }

        public static Direcao RandomizaDirecao()
        {
            return (Direcao) Random.Next(4);
        }

        public static Point RandomizaLocalizacao()
        {
            return new Point(Random.Next(1, 418), Random.Next(1, 156));
        }
    }
}