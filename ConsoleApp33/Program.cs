using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLenght = 10;
            int[] numbers = new int[arrayLenght];
            Random random = new Random();
            int minNumberInArray = 0;
            int maxNumberInArray = 10;
            int tempNumber;

            Console.WriteLine("\nСгенерированный массив:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minNumberInArray, maxNumberInArray);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\n\nОтсортированные числа, от меньшего к большему:");

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        tempNumber = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = tempNumber;
                    }
                }
                Console.Write(numbers[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
