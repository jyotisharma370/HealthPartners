using FluentAssertions;
using HealthPartners.FizzBuzz;
using HealthPartners.FizzBuzz.Interface;
using Xunit;

namespace HealthPartners.Tests
{
    public class FizzBuzzerTests
    {
        private readonly IFizzBuzzer _fizzBuzzer;

        public FizzBuzzerTests()
        {
            _fizzBuzzer = new FizzBuzzer();
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(33)]
        public void ReturnsFizzForNumberDivisibleByThree(int value)
        {
            var result = _fizzBuzzer?.ConvertNumber(value);

            result.Should().Be("fizz");
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(100)]
        public void ReturnsBuzzForNumberDivisibleByFive(int value)
        {
            var result = _fizzBuzzer?.ConvertNumber(value);

            result.Should().Be("buzz");
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        [InlineData(150)]
        public void ReturnsFizzBuzzForNumberDivisibleByThreeAndFive(int value)
        {
            var result = _fizzBuzzer?.ConvertNumber(value);

            result.Should().Be("fizzbuzz");
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(22)]
        public void ReturnsNumberForNumberNotDivisibleByThreeOrFive(int value)
        {
            var result = _fizzBuzzer?.ConvertNumber(value);

            result.Should().Be(value.ToString());
        }

    }
}
