using HealthPartners.FizzBuzz;
using HealthPartners.FizzBuzz.Interface;

namespace HealthPartners
{
    internal class Program
    {
        private static readonly IFizzBuzzer? _fizzBomber;

        static Program()
        {
            _fizzBomber = (FizzBuzzer?)Activator.CreateInstance(typeof(FizzBuzzer));
        }

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var str = _fizzBomber?.ConvertNumber(i);
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }
    }
}
