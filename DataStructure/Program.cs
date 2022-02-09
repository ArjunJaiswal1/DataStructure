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
            list.Add(40);
            list.Add(70);
            int position = list.Search(40);
            list.DeleteNodeAtParticularPosition(position);
            Console.WriteLine("\nAfter deleting 40 then Size and final sequence is: ");
            list.Size();
            list.Display();

        }
    }
}