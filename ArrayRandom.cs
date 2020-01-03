using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRandom
{
    class Program
    {
        static int[,] GetRandomArray(int rows, int columns) // функция заполнения массива случайными числами
        {
            Random random = new Random();
            var result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = random.Next(100);
                }
            }

            return result;
        }


        static void Main(string[] args)
        {
            int rows = 5;
            int columns = 5;

            var myArr = GetRandomArray(rows, columns); 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{myArr[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
