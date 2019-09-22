using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Arrays
    {
        int[] arr;
        public Arrays(int size, int from, int before) //Заполняем массив случайными числами
        {
            arr = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
                arr[i] = rnd.Next(from, before);
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (int i in arr)
            {
                Console.WriteLine($"{i}");
            }
        }
        public void Index(int number) //Ищем индекс
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number) Console.WriteLine(i);
            }
        }
    }
}
