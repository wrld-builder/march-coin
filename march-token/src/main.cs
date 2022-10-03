using System;
using System.Diagnostics.Eventing.Reader;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using ecc.src;
using math.src;

namespace march_token.src
{
    internal class MainClass
    {
        public static void Main()
        {
            var gx = BigInteger.Parse("79be667ef9dcbbac55a06295ce870b07029bfcdb2dce28d959f2815b16f81798", System.Globalization.NumberStyles.AllowHexSpecifier);
            var gy = BigInteger.Parse("483ada7726a3c4655da4fbfc0e1108a8fd17b448a68554199c47d08ffb10d4b8", System.Globalization.NumberStyles.AllowHexSpecifier);
            var p = BigInteger.Pow(2, 256) - BigInteger.Pow(2, 32) - 977;
            System.Console.WriteLine(((BigInteger.Pow(gy, 2) % p) == ((BigInteger.Pow(gx, 3) + 7) % p)).ToString());
        }
    }
}
