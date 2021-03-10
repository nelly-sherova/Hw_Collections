using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            MyList<int> list = new MyList<int>();
            Console.WriteLine("List");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Добавление"); 
            Console.ResetColor();
            list.Add(5);
            list.Add(12);
            list.Add(13);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Поиск по индексу");
            Console.ResetColor();

            Console.WriteLine(list.FindByIndex(0));

            // AddRange
            int[] arr = {1, 2, 3, 4, 5};
            Console.ResetColor();

            list.AddRange(arr);
            // Insert
            list.Insert(1, 1111);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Все элементы");
            Console.ResetColor();
            list.ShowAllElements();
            


            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nDictionary");
            Console.ResetColor();
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Добавление");
            Console.ResetColor();

            dictionary.Add("Person", "Nilufar");

            dictionary.Add("Zoo", "Crokodile");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Поиск по ключу");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine(dictionary.FindElementByKey("Person"));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Все элементы!");
            Console.ResetColor();
            dictionary.ShowAllElements();
        }
    }
}   
