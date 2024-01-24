using HealthPartners.FizzBuzz;
using HealthPartners.FizzBuzz.Interface;

namespace HealthPartners
{
    internal class Program
    {
        private static readonly IFizzBuzzer? _fizzBuzzer;

        static Program()
        {
            _fizzBuzzer = (FizzBuzzer?)Activator.CreateInstance(typeof(FizzBuzzer));
        }

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var str = _fizzBuzzer?.ConvertNumber(i);
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }
    }
}
