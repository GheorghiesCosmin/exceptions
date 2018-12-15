using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hy");

            List<string> myStringList = new List<string>();

            myStringList.add("C");
            myStringList.Add("Phyton");
            myStringList.Add("javascript");
            myStringList.Add(" java");

            foreach (string item in myStringList)
            {
                Console.WriteLine(item);
            }

            if (myStringList.Contains("java"))
            {
                myStringList.Remove("java");
            }
            foreach (string item in myStringList)
            {
                Console.WriteLine(item);
            }

            Zoo myAwesomeZoo = new Zoo();
            foreach (var animal in myAwesomeZoo.Animals)

            {
                Console.WriteLine($"This is a animal {animal.Name}, and it's a animal{animal.Gender}");
            }
            Console.WriteLine("____________________________ stack");

            Stack<string> mStack = new Stack<string>();
            myStack.Push("C#");
            myStack.Push("Sql");
            myStack.Push("Csharp");
            int count = myStack.Count;

            for (int 1 = 0; i <count; i++)
            {
                Console.WriteLine(myStack.Peek());
            }
        }
    }
}
