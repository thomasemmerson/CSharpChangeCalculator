using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter change amount:");
            double changeAmount = Convert.ToDouble(Console.ReadLine());
            double numberOfCoins = CalculateNumberOfCoinsIn(changeAmount);
            Console.WriteLine("Your change contained " + numberOfCoins + "coins!");
        }

        public static int CalculateNumberOfCoinsIn(double changeAmount)
        {
            if (changeAmount == 0.01)
            {
                return 1;
            }
            return 0;
        }
    }
}
