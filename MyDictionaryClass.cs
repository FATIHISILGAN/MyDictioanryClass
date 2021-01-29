using System;
using System.Collections.Generic;
using System.Text;

namespace MyGeneric
{
    class MyDictionaryClass<T>
    {

        T[] _values;


        public MyDictionaryClass()
        {
            _values = new T[0];

        }
        public void Add(T value)
        {
            T[] temp = _values;
            _values = new T[_values.Length + 1];

            for (int i = 0; i < temp.Length; i++)
            {
                _values[i] = _values[i];
            }

            _values[_values.Length - 1] = value;

            Console.WriteLine(value + " değer eklenmiştir");
        }
    }
}
