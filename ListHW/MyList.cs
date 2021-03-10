using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ListHW
{
  class MyList<Type>
    {
        static Type[] myList = new Type[0];
        public Type this[int index]
        {
            get
            {
                return myList[index];
            }
            set
            {
                myList[index] = value;
            }
        }

        public void Add(Type element)
        {
            Array.Resize(ref myList, myList.Length + 1);
            myList[myList.Length - 1] = element;
        }
        public Type FindByIndex(int index)
        {
            return myList[index];
        }

        public void ShowAllElements()
        {
            foreach(Type element in myList)
            {
                Console.Write(element + " ");
            }
        }

        public int AllElements()
        {
          return myList.Length;
        }
    }
}