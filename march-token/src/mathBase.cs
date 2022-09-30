using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace march_token.src
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
