using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Task1();
            //Задание1
            //Задание2
            //Задание3
        }
        internal static void Task1()
        {
            Console.Write("Введите длинну массива: ");
            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите элемент под индексом {0}: ", i);
                string input = Console.ReadLine();
                array[i] = int.Parse(input);
                sum += array[i];
            }

            //Console.ReadKey();

            //int sum = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];  
            //}

            Console.WriteLine("Сумма числе в массиве равна: " + sum);
            Console.ReadKey();

        }

    }
}

