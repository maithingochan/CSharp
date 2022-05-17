using System;

namespace BookManaging_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            BookList b1 = new BookList();
            b1.InputList();
            b1.showList();
            Console.ReadLine();
        }
    }
}
