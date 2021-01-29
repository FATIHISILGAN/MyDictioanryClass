using System;

namespace MyGeneric
{
    class Program
    {
        static void Main(string[] args)
        {




            MyDictionaryClass<string> myGeneric = new  MyDictionaryClass<string>();

            myGeneric.Add("string değer");



             MyDictionaryClass<int> myGeneric1 = new  MyDictionaryClass<int>();

            int deger = 2;
            myGeneric1.Add(deger);

        }
    }
}
