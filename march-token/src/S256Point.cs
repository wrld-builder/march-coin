using ecc.src;

namespace march_token.src
{
    internal class S256Point : Point
    {
        public S256Point(FieldElement x, FieldElement y, FieldElement a, FieldElement b) : base(x, y, a, b)
        {

        }
    }
}
