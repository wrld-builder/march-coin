using System.Runtime.CompilerServices;

namespace march_token.src
{
    internal class MainClass
    {
        public static void Main()
        {
            var a = new FieldElement(0, 223);
            var b = new FieldElement(7, 223);

            var p = new Point(new FieldElement(47, 223), new FieldElement(71, 223), a, b);
            var c = p * 4;
            System.Console.WriteLine(c.getX().getNumber().ToString() + ' ' + c.getY().getNumber().ToString());
        }
    }
}
