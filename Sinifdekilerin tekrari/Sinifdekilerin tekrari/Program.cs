using System;
using System.ComponentModel;

namespace Sinifdekilerin_tekrari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task-1  Verilmiş ədədin verilmiş qüvvətini tapan main
            Console.WriteLine("Birinci ededi daxil edin!");
            var xStr = Console.ReadLine();
            var x = Convert.ToInt32(xStr);
            Console.WriteLine("Ikinci ededi daxil edin!");
            var yStr = Console.ReadLine();
            var y = Convert.ToInt32(yStr);
            var resultpow = Pow(x, y);
            Console.WriteLine(resultpow);

            // Task-2  Verilmiş 3 ədəddən ən böyüyünü tapan main
            Console.WriteLine("Birinci ededi daxil edin!");
            var firstStr = Console.ReadLine();
            var first = Convert.ToInt32(firstStr);
            Console.WriteLine("Ikinci ededi daxil edin!");
            var secondStr = Console.ReadLine();
            var second = Convert.ToInt32(secondStr);
            Console.WriteLine("Birinci ededi daxil edin!");
            var thirdStr = Console.ReadLine();
            var third = Convert.ToInt32(thirdStr);
            var resultBiggest=Biggest(first,second, third);
            Console.WriteLine(resultBiggest);

            // Task-3  Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan main
            Console.WriteLine("Ededleri daxil edin");
            var list = Console.ReadLine();
            string resultSumDigits = SumOfDigits(list);
            Console.WriteLine(resultSumDigits);

            //  Task-4  Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan main
            Console.WriteLine("Nece eded daxil edeceksen?");
            var counterStr = Console.ReadLine();
            var counter = Convert.ToInt32(counterStr);
            int[] numbers = new int[counter];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i}. ededi daxil edin:");
                var numberStr = Console.ReadLine();
                var number = Convert.ToInt32(numberStr);
                numbers[i] = number;

            }
            var result = Bigger(numbers);
            Console.WriteLine(result);

        }

        // Task-1 (Method) (Verilmiş ədədin verilmiş qüvvətini tapan metod)
        static int Pow(int x, int y)
        {
            int resultPow = 1;
            for (int i = 0; i < y; i++)
            {
                resultPow *= x;
            }
            return resultPow;
        }

        // Task-2 (Method) (Verilmiş 3 ədəddən ən böyüyünü tapan metod)
        static int Biggest(int x, int y, int z)
        {
            if (x > y)
            {
                if (x > z)
                {
                    return x;
                }
                else
                {
                    return z;
                }
            }
            else if (y > z)
            {
                return y;
            }
            else
            {
                return z;
            }
        }

        // Task-3 (Method) (Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan metod)
        static int SumOfDigits(int[] numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        // Task-4 (Method) (Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan metod)
        static int Bigger(int[] nums)
        {
            int biggest = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > biggest)
                {
                    biggest = nums[i];
                }
            }

            return biggest;
        }
    }
}
