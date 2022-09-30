using System;

namespace march_token.src
{
    internal class FieldElement : MathBase
    {
        private double number = 0;

        private double prime = 0;

        public FieldElement(double number, double prime)
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

        public double getNumber() => this.number;

        public double getPrime() => this.prime;

        public static FieldElement operator+(FieldElement current, FieldElement other)
        {
            double result = 0;

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
                result = (current.number + other.number) % current.prime;
                if (result < 0) result += current.prime;
            }

            return new FieldElement(result, current.prime);
        }

        public static FieldElement operator-(FieldElement current, FieldElement other)
        {
            double result = 0;

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
            double result = 0;

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
            double result = 0;

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
                result = current.number * modexp(Convert.ToInt32(other.number), Convert.ToInt32(current.prime) - 2, Convert.ToInt32(current.prime)) % current.prime;
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

        public FieldElement powFieldElement(int exponent)
        {
            double result = Math.Pow(this.number, exponent) % this.prime;
            return new FieldElement(result, this.prime);
        }
    }
}
