using System;
using System.Numerics;
using math.src;

namespace ecc.src
{
    internal class FieldElement : MathBase
    {
        private BigInteger number = 0;

        private BigInteger prime = 0;

        public FieldElement(BigInteger number, BigInteger prime)
        {
            try
            {
                if (number < 0 || number > prime) throw new ArgumentException("Exception: number less than zero, or higher than prime");
            }

            catch(ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                Environment.Exit(1);
            }

            finally
            {
                this.number = number;
                this.prime = prime;
            }
        }

        public BigInteger getNumber() => this.number;

        public BigInteger getPrime() => this.prime;

        public static FieldElement operator+(FieldElement current, FieldElement other)
        {
            BigInteger result = 0;

            try
            {
                if (current.prime != other.prime) throw new ArgumentException("Exception: prime of field elements not equal");
            }

            catch(ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                Environment.Exit(1);
            }

            finally
            {
                result = ((current.number + other.number) % current.prime);
                if (result < 0) result += current.prime;
            }

            return new FieldElement(result, current.prime);
        }

        public static FieldElement operator-(FieldElement current, FieldElement other)
        {
            BigInteger result = 0;

            try
            {
                if (current.prime != other.prime) throw new ArgumentException("Exception: prime of field elements not equal");
            }

            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                Environment.Exit(1);
            }

            finally
            {
                result = (current.number - other.number) % current.prime;
                if (result < 0) result += current.prime;
            }

            return new FieldElement(result, current.prime);
        }

        public static FieldElement operator *(FieldElement current, FieldElement other)
        {
            BigInteger result = 0;

            try
            {
                if (current.prime != other.prime) throw new ArgumentException("Exception: prime of field elements not equal");
            }

            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                Environment.Exit(1);
            }

            finally
            {
                result = (current.number * other.number) % current.prime;
                if (result < 0) result += current.prime;
            }

            return new FieldElement(result, current.prime);
        }

        public static FieldElement operator /(FieldElement current, FieldElement other)
        {
            BigInteger result = 0;

            try
            {
                if (current.prime != other.prime) throw new ArgumentException("Exception: prime of field elements not equal");
            }

            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                Environment.Exit(1);
            }

            finally
            {
                result = current.number * modexp((int)other.number, (int)(current.prime - 2), (int)current.prime) % current.prime;
                if (result < 0) result += current.prime;
            }

            return new FieldElement(result, current.prime);
        }

        public static bool operator ==(FieldElement current, FieldElement other)
        {
            if (other is null) return false;
            return current.number == other.number && current.prime == other.prime;
        }

        public static bool operator !=(FieldElement current, FieldElement other)
        {
            return !(current == other);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            FieldElement fieldElement = (FieldElement)obj;
            return fieldElement.number == this.number && fieldElement.prime == this.prime;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public FieldElement powFieldElement(int exponent)
        {
            BigInteger result = (int)Math.Pow((double)this.number, exponent) % this.prime;
            return new FieldElement(result, this.prime);
        }
    }
}
