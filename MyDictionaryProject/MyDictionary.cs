using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryProject
{
    class MyDictionary<T, D>
    {
        D[] values;
        T[] keys;
        T[] tempKeys;
        D[] tempValues;

        public MyDictionary()
        {
            keys = new T[0];
            values = new D[0];
        }

        public void Add(T key, D value)
        {
            tempKeys = keys;
            tempValues = values;
            keys = new T[keys.Length + 1];
            values = new D[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            for (int a = 0; a < tempValues.Length; a++)
            {
                values[a] = tempValues[a];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        public int Count
        {
            get { return keys.Length; }
        }
        public  void Listele()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] +" "+ values[i]);
            }
        }
    }
}
        

