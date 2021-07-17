using System;

namespace Prime.Services
{
    public class PrimeService
    {
        // A number is classified as a prime if it is greater than one and is divisible only by one and by itself.
        public bool IsPrime(int candidate)
        {
            // if candidate is less than 2, it's not prime
            if (candidate < 2) {
                return false;
            }

            // if candidate is 2, it's prime
            if (candidate == 2) {
                return true;
            }

            // if candidate is even, it's not prime
            if (candidate % 2 == 0) {
               return false;
            }

            // check odd numbers up to square root of candidate
            for (int i = 3; i <= Math.Sqrt(candidate); i += 2) {
                if (candidate % i == 0) {
                    return false;
                }
            }

            // candidate is prime
            return true;
        }
    }
}