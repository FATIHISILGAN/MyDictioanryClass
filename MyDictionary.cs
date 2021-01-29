using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExample
{
    class MyDictionary<TKey,TValue> //Dictioanry class 
    {

        TValue[] values;
        TKey[] keys;

        TKey[] temp_keys;
        TValue[] temp_values;
        public MyDictionary()
        {
            values = new TValue[0];
            keys = new TKey[0];
           
        }
        public void Add(TKey Key, TValue Value)
        {
            temp_keys = keys;
            temp_values = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < temp_keys.Length; i++)
            {
                keys[i] = temp_keys[i];

            }

            for (int i = 0; i < temp_values.Length; i++)
            {
                values[i] = temp_values[i];
            }



            Console.WriteLine(" Anahtarların sayısı: " + keys.Length + " Değerin sayısı: " + values.Length);
            Console.WriteLine("key no: " + Key + " olan " + Value + "  sisteme eklendi");

        }


    }
}
