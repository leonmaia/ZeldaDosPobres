
using System.Drawing;

namespace ZeldaDosProbres.Core
{
    public class Masmorra
    {
        public Masmorra()
        {
            Altura = 186;
            Largura = 448;
            Piso = new Rectangle(0, 0, Altura, Largura);
        }

        public Rectangle Piso { get; private set; }
        public int Altura { get; private set; }
        public int Largura { get; private set; }
    }
}