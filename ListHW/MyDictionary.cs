using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ListHW
{
  public class MyDictionary<TKey, TValue>
  {

      static TKey[] keysList = new TKey[0];
      static TValue[] valuesList = new TValue[0];
      public int Count { get { return keysList.Length; } }
      public TValue this[int index]
      {
          get
          {
              return valuesList[index];
          }
          set
          {
              valuesList[index] = value;
          }
      }

      public TValue this[TKey index]
      {
          get
          {
              int findedIndex = FindElementIndex(index);
              return valuesList[findedIndex];
          }
          set
          {
              int findedIndex = FindElementIndex(index);
              valuesList[findedIndex] = value;
          }
      }

      public void Add(TKey key, TValue value)
      {
          Array.Resize(ref keysList, keysList.Length + 1);
          keysList[keysList.Length - 1] = key;

          Array.Resize(ref valuesList, valuesList.Length + 1);
          valuesList[valuesList.Length - 1] = value;

           Console.WriteLine("Добавлен ключ: " + key  + "Добавлено значение:  " + value);
      }

      public TValue FindElementByKey(TKey item)
      {
          TValue value = valuesList[0];
          for(int i = 0; i < keysList.Length; i++)
          {
              if ((object)item == (object)keysList[i])
              {
                  value = valuesList[i];
              }
          }
          return value;
      }
      private int FindElementIndex(TKey item)
        {
            for(int i = 0; i < keysList.Length; i++)
            {
                if((object)item == (object)keysList[i])
                {
                    return i;
                }
            }
            return 0;
        }
      public void ShowAllElements()
      {
        for (int i = 0; i < keysList.Length; i++)
        {
          Console.WriteLine($"Key: {keysList[i]}; Value: {valuesList[i]}");
        }
      }
      
    
  }
}