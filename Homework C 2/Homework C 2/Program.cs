using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Reflection.Metadata;

namespace Homework_C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task-1  Verilmiş ədədlər siyahısındaki ən böyük ədədin yerləşdiyi index-i qaytaran (main)
            Console.WriteLine("Ededin sayini de");
            var ededSayiStr = Console.ReadLine();
            var ededSayi = Convert.ToInt32(ededSayiStr);
            int[] listNumber = new int[ededSayi];

            for (int i = 0; i < listNumber.Length; i++)
            {
                Console.WriteLine($"{i}. ededi daxil edin:");
                var numberStr = Console.ReadLine();
                var number = Convert.ToInt32(numberStr);
                listNumber[i] = number;
            }
            var result = biggestNum(listNumber);
            Console.WriteLine(result);


            // Task-2  Verilmiş yazılar siyahısındaki (string array) verilmiş yazının yerləşdiyi indexi
            // qaytaran metod.Əgər verilmiş string array-de verilmiş string dəyər yoxdursa -1 qaytarsın (main)
            Console.WriteLine("Yazini sayini daxil et!");
            var wordsNumStr = Console.ReadLine();
            var wordsNum = Convert.ToInt32(wordsNumStr);
            string[] listWords = new string[wordsNum];
            for (int i = 0; i < listWords.Length; i++)
            {
                Console.WriteLine($"{i}. yazini daxil edin:");
                var numberStr = Console.ReadLine();
                listWords[i] = numberStr;
            }
            var result2 = HasStringArray(listWords);
            Console.WriteLine(result2);

            // Task-3  Verilmiş ədədlər siyahısındaki ədədlərin yalnız müsbət olanlarından ibarət yeni bir
            // array qaytaran metod.Yəni metodu işə salın {4,-5,3,-2,6} ədədlərindən ibarət array göndərsəm
            // metod geriyə {4,3,6} ədədlərindən ibarət array qaytarmalıdır (main)
            Console.WriteLine("Ededin sayini de");
            var ededStr = Console.ReadLine();
            var ededinSayi = Convert.ToInt32(ededStr);
            int[] listsNumber = new int[ededinSayi];
            for (int i = 0; i < ededinSayi; i++)
            {
                Console.WriteLine($"{i}. ededi daxil edin:");
                var numbersStr = Console.ReadLine();
                int numbers = Convert.ToInt32(numbersStr);
                listsNumber[i] = numbers;
            }
            var newArray = positives(listsNumber);
            Console.WriteLine(newArray);

            // Task-4  Verilmiş yazıda rəqəm olub olmadığını qaytaran (main)
            Console.WriteLine("Yazini daxil edin!");
            var HasnumStr = Console.ReadLine();
            var Hasnum = hasNumber(HasnumStr);

            // Task-5 Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran (main)
            Console.WriteLine("Yazini sayini daxil et!");
            var wordsNumStrs = Console.ReadLine();
            var wordsNums = Convert.ToInt32(wordsNumStrs);
            string[] listWordss = new string[wordsNums];
            for (int i = 0; i < listWordss.Length; i++)
            {
                Console.WriteLine($"{i}. yazini daxil edin:");
                var wordStrs = Console.ReadLine();
                listWordss[i] = wordStrs;
            }
            var result22 = howMuchNum();
            Console.WriteLine(result22);



        }

        // Task-1 (Method)
        static int biggestNum(int[] numbers)
        {
            int max = numbers[0];
            int biggest = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    biggest = i;
                }
            }

            return biggest;
        }

        // Task-2 (Method) 
        static int HasStringArray(string[] words)
        {

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "String Array")
                {

                    return i;
                }
                else
                    return -1;
            }
            return -2;

        }

        // Task-3 (Method)
        static Array positives(int[] numbers)
        {
            var j = 0;
            int[] array1 = new int[] { };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    array1[j] = numbers[i];
                    j++;
                }
               
            }
            return array1;
        }
        // Task-4 (Method)
        static bool hasNumber(string word)
        {
            var hasnum = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '1' || word[i] == '2' || word[i] == '3' || word[i] == '4' || word[i] == '5' || word[i] == '6' || word[i] == '7' || word[i] == '8' || word[i] == '9' || word[i] == '0')
                {
                    hasnum = true;
                    break;
                }
            }
            if (hasnum == true)
            {
                Console.WriteLine("Reqem var!");
            }
            else if (hasnum == false)
            {
                Console.WriteLine("Reqem yoxdur!");
            }
            return hasnum;
        }

        // Task-5 (Methods)
        static int howMuchNum(int[] numbers)
        {
            var anything = 0;
            var count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == '1' || numbers[i] == '2' || numbers[i] == '3' || numbers[i] == '4' || numbers[i] == '5' || numbers[i] == '6' || numbers[i] == '7' || numbers[i] == '8' || numbers[i] == '9' || numbers[i] == '0')
                {
                    count++;
                }
                else
                {
                    anything++;
                }
                if (count == 0)
                {
                    return anything;
                }
                else
                    return count;
            }




        }
    }
}