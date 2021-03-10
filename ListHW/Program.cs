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

            list.Add(5);
            list.Add(12);

           
            Console.WriteLine(list.FindByIndex(0));

            list.ShowAllElements();

            Console.WriteLine("\n" + list.AllElements());
        }
    }
}   
