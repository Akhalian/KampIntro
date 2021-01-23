using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<string, string> myDict = new MyDict<string, string>();
            myDict.Add("1234", "Burak");

            myDict.GetAll();

            Console.WriteLine("Burada bitiyor ilk dict");

            myDict.Add("5678", "Murat");

            myDict.GetAll();




        }
    }
}
