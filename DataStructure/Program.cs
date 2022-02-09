using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Data Structure Programs==========");

            Console.WriteLine("Search Operations !");
            LinkedList list = new LinkedList();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);

            // list.AddReverse(70);
            //list.AddReverse(30);
            //list.AddReverse(56);
            //list.Appending(56);
            //list.Appending(30);
            //list.Appending(70);
            list.Add(56);
            list.Add(30);
            list.Add(70);
            int searchData = list.Search(30);
            if (searchData != 0)
                Console.WriteLine("\n{0} is present in the LinkedList ", searchData);

        }
    }
}