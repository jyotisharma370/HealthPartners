using HealthPartners.FizzBuzz.Interface;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HealthPartners.FizzBuzz
{
    public class FizzBuzzer : IFizzBuzzer

    {
        public string ConvertNumber(int n)
        {
            if ((n % 3 == 0) && (n % 5 == 0))
                return "fizzbuzz";

            if (n % 3 == 0)
                return "fizz";

            if (n % 5 == 0)
                return "buzz";

            return n.ToString();
        }
    }
}
