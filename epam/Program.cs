using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Arrays arr = new Arrays(20, 1, 100);
            Console.Write("Введите число:");
            int number=int.Parse(Console.ReadLine());
            Console.WriteLine("Введённое число найдено в следующих индексах массива:");
            arr.Index(number);
            Console.ReadLine(); 
        }
    }
}
