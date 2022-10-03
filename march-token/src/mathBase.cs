using System;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;

namespace math.src
{
    internal class MathBase
    {
        public static int modexp(int x, int y, int N)
        {
            if (y == 0) return 1;
            int z = modexp(x, y / 2, N);
            if (y % 2 == 0)
                return (z * z) % N;
            else
                return (x * z * z) % N;
        }
    }
}
