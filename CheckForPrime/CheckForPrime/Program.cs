using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers=new int[10];
            Console.WriteLine("Please enter ten Numbers");
            for (int iterator = 0; iterator < 10; iterator++)
            {
                numbers[iterator] = int.Parse(Console.ReadLine());
            }
            int count = PrimeCount(numbers);
            Console.WriteLine("Number of prime values are={0}",count);
            Console.ReadKey();
        }

        private static int PrimeCount(int[] numbers)
        {
            int count=0;
            bool flag=false;
            foreach (var number in numbers)
            {
                int iterator;
                for (iterator = 2; iterator <= number - 1; iterator++)
                {
                    if (number % iterator == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (iterator == number)
                {
                    flag = true;
                }
                if (flag)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
