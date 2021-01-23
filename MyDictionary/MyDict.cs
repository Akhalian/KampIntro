using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDict<Key, Value>
    {
        Key[] key;
        Value[] value;
        public MyDict()
        {
            key = new Key[0];
            value = new Value[0];
        }

        Key[] tempkey;
        Value[] tempvalue;

        public void Add(Key keys, Value values)
        {
            tempkey = key;
            tempvalue = value;
            key = new Key[key.Length + 1];
            value = new Value[value.Length+1];
            
            for (int i = 0; i < tempkey.Length; i++)
            {
                key[i] = tempkey[i];
            }

            for (int i = 0; i < tempvalue.Length; i++)
            {
                value[i] = tempvalue[i];
            }

            key[key.Length - 1] = keys;
            value[value.Length - 1] = values;


        }

        public void GetAll()
        {
            for (int i = 0; i < key.Length; i++)
            {
                Console.WriteLine("Ad Soyad: " + key[i] + " " + value[i]);
            }
        }
    }
}
