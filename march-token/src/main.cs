using System;
using System.Diagnostics.Eventing.Reader;
using System.Numerics;
using System.Runtime.CompilerServices;
using ecc.src;
using math.src;

namespace march_token.src
{
    internal class MainClass
    {
        public static void Main()
        {
            var a = new FieldElement(0, 223);
            var b = new FieldElement(7, 223);

            var p = new Point(new FieldElement(192, 223), new FieldElement(105, 223), a, b);
            var c = p * 1000000000;

            System.Console.WriteLine(c.getX().getNumber().ToString() + ' ' + c.getY().getNumber().ToString());
        }
    }
}
