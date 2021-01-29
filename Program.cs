using System;


namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(2, "fatih");





            MyDictionary<string, string> myDictionary2 = new MyDictionary<string, string>();

            myDictionary2.Add("car", "araba");

        }
    }
}
