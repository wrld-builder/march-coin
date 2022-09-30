using System.Runtime.CompilerServices;

namespace march_token.src
{
    internal class MainClass
    {
        public static void Main()
        {
            var a = new FieldElement(0, 223);
            var b = new FieldElement(7, 223);

            var p = new Point(new FieldElement(15, 223), new FieldElement(86, 223), a, b);
            var inf = new Point(null, null, a, b);

            var product = p;
            int count = 0;
            while(product != inf)
            {
                product += p;
                count++;
            }

            System.Console.WriteLine(count);
        }
    }
}
