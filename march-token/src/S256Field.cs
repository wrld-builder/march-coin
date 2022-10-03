using ecc.src;
using System.Numerics;

namespace march_token.src
{
    internal class S256Field : FieldElement
    {
        public S256Field(BigInteger number, BigInteger prime) : base(number, prime) { }


    }
}
