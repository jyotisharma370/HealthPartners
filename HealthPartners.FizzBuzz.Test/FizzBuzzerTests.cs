using HealthPartners.FizzBuzz.Interface;

namespace HealthPartners.FizzBuzz.Test
{
    public class FizzBuzzerTests
    {
        private IFizzBuzzer _fizzBuzzer;

        [SetUp]
        public void Setup()
        {
            _fizzBuzzer = new FizzBuzzer();
        }

        [Test]
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void FizzBuzzer_GetOutput_Method_Returns_Fizz_When_Number_Is_Divisible_By_Only_3(int number)
        {
            Assert.That(_fizzBuzzer.ConvertNumber(number), Is.EqualTo("Fizz"));
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(25)]
        public void FizzBuzzer_GetOutput_Method_Returns_Buzz_When_Number_Is_Divisible_By_Only_5(int number)
        {
            Assert.That(_fizzBuzzer.ConvertNumber(number), Is.EqualTo("Buzz"));
        }

        [Test]
        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void FizzBuzzer_GetOutput_Method_Returns_FizzBuzz_When_Number_Is_Divisible_By_3_And_5(int number)
        {
            Assert.That(_fizzBuzzer.ConvertNumber(number), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        [TestCase(7)]
        [TestCase(17)]
        [TestCase(1)]
        public void FizzBuzzer_GetOutput_Method_Returns_Number_When_Number_Is_Not_Divisible_By_3_Or_5(int number)
        {
            Assert.That(_fizzBuzzer.ConvertNumber(number), Is.EqualTo(number.ToString()));
        }
    }
}