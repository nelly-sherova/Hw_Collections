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

            MyList<int> list = new MyList<int>();

            Console.WriteLine("List");
            //добавление
            list.Add(5);
            list.Add(12);
            list.Add(13);
            // поиск по индексу

            Console.WriteLine(list.FindByIndex(0));


            // все элементы 
            list.ShowAllElements();

            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            // добавление 
            dictionary.Add("Person", "Nilufar");

            dictionary.Add("Zoo", "Crokodile");
            // поиск по ключу
            Console.WriteLine();
            Console.WriteLine(dictionary.FindElementByIndex("Person"));
        }
    }
}   
