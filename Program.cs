using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            fruit f1 = new fruit("red", "sweet");
            f1.buy(5);

            apple app = new apple("yellow", "sour", 12, "small");

        }
    }
}
