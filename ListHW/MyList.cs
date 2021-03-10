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
        public int Count { get { return myList.Length; } }
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
            Console.WriteLine("Добавлен эленмент: " + element);
        }
        public Type FindByIndex(int index)
        {
            return myList[index];
        }
        public void AddRange(Type[] arr)
        {
            int j = myList.Length;
            Array.Resize(ref myList, arr.Length + myList.Length);
            
            for (int i = 0; i < arr.Length; i++)
            {
                myList[j] = arr[i];
                j++;
            }
        }
        public void Insert(int index, Type element)
        {
            Array.Resize(ref myList, myList.Length + 1);
            for (int i = myList.Length-1; i >= index + 1; i--)
                myList[i] = myList[i - 1];
            myList[index] = element;
        }
        public void ShowAllElements()
        {
            foreach(Type element in myList)
            {
                Console.Write(element + " ");
            }
        }
    }
}