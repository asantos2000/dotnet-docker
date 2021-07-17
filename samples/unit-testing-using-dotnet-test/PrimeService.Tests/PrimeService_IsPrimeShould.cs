using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(12)]
        [InlineData(14)]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(18)]
        [InlineData(100)]
        [InlineData(1000)]
        public void IsNotPrime_ReturnFalse(int value)
        {
            var _primeService = new PrimeService();
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(17)]
        [InlineData(19)]
        [InlineData(23)]
        [InlineData(29)]
        [InlineData(31)]
        [InlineData(97)]
        public void IsPrime_ReturnTrue(int value)
        {
            var _primeService = new PrimeService();
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }
    }
}