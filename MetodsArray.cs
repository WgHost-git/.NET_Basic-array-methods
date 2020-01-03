using System;
using System.Collections.Generic;
using System.Linq;

namespace MetodsArray
{
    class Program
    {
        static void Main(string[] args)
        {
             

        }

        static void MetodArr()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int index = Array.BinarySearch(arr, 7); // возвращает индекс первого вхождения найденого элемента. Запускает двоичный поиск. Массив должен быть сортирован.

            int[] copy = new int[10];
            Array.Copy(arr, copy, arr.Length); // копирование массива вариант 1

            int[] anotherCopy = new int[10];
            copy.CopyTo(anotherCopy, 0); // копирование массива вариант 2. 0 - индекс начала копирования

            Array.Reverse(copy); // реверс всех элементов

            Array.Sort(copy); // Сортировка массива

            Array.Clear(copy, 0, copy.Length); // Очистка массива

        }
        static void MetodList()
        {
            var intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            intList.Add(10); // Добавить элемент в Лист

            int[] arr = { 1, 2, 3 };

            intList.AddRange(arr); // Добавление массива в лист

            if (intList.Remove(1)) // удаляет элемент и возвращает bool (true если нашел ...). Удаляет только первую 1ку.
            { }

            intList.IndexOf(3); //возвращает индекс первого вхождения элемента в списке
            intList.LastIndexOf(3);  //возвращает индекс последнего вхождения элемента в списке

            intList.RemoveAt(0); // удаление по индексу

            intList.Reverse();
            bool contains = intList.Contains(3);

            int min = intList.Min();
            int max = intList.Max();

            for (int i = 0; i < intList.Count; i++) // Count возвращает кол-во элементов
            {
                Console.Write($"{intList[i]} | ");
            }
        }
        static void DictionaryMetods()
        {
            var people = new Dictionary<int, string>();
            people.Add(1, "John"); // Добавление записи. Если дбавить одинаковый ключ то будет ошибка
            people.Add(2, "Bob");
            people.Add(3, "Alice");

            people = new Dictionary<int, string>()
            {
                { 1, "John" },
                { 2, "Bob" },
                { 3, "Alice" },
            };

            people.TryAdd(2, "Bob"); // Попытка добавления. Возвращает bool

            string name = people[1];
            Console.WriteLine(name);

            Console.WriteLine("Iterating over keys");
            var keys = people.Keys;
            //Dictionary<int, string>.KeyCollection keys = people.Keys;

            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Iterating over values");
            var values = people.Values;
            //Dictionary<int, string>.KeyCollection keys = people.Values;

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Iterating over keys-value pairs"); // прохождение цикла по ключу со значением
            foreach (var pair in people)
            {
                Console.WriteLine($"Key:{pair.Key}. Value:{pair.Value}");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Count = {people.Count}"); //Запросить кол-во элементов 

            bool containsKey = people.ContainsKey(2); // поиск ключа (Клоючи в Dictionary ищются очень быстро)
            bool containsValue = people.ContainsValue("John"); // поиск значения (Значения в Dictionary ищются как обычно не быстро)

            Console.WriteLine($"Contains key: {containsKey}. Contains value: {containsValue}.");

            people.Remove(1); //удаление по ключу (удаляется и значение) возвращает bool

            if (people.TryGetValue(2, out string val)) // Попытаться вытащить значение исп. ключ. 
            {
                Console.WriteLine($"Key 2 val = {val}");
            }
            else
            {
                Console.WriteLine("Failed to get");
            }

            people.Clear(); // Очищает

        }
        static void StacQueue()
        {
            // Стек применение: Пример отмена операции (храненние операций в стеке)
            var stack = new Stack<int>();
            stack.Push(1); // Добавить в стек
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine($"Should print out 3: {stack.Peek()} ");

            stack.Pop(); // Удалить последний добавленный элемент в стек

            Console.WriteLine($"Should print out 3: {stack.Peek()} ");

            Console.WriteLine("Iterate over the stack.");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //--------- Очкредь

            var queue = new Queue<int>(); // Класическая очередь
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4); // и тд
        }
        static void TwoDimensionalArray()
        {
            // ддвумерный массив

            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 1, 2, 3 } }; // строки потом столбцы
            //int[,] arr1 = { {1, 2, 3 }, {1, 2, 3 } }; // эквивалент

            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("\t | ");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} | ");
                }
                Console.WriteLine();
            }
        }
    }
}
