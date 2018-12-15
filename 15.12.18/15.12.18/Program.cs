using System;

namespace _15._12._18
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Person person = new Person(15);
                // Person person1 = new Person(-1);
                // Person person2 = new Person(2);
                Person person3 = new Person(81);
            }
            catch (ArgumentException e)
            {
                // this will show all error
                // Console.Writeline(e);
                Console.WriteLine(e.Message);
                // throw;
            }



            //try
            //{
            //    int b = 100;
            //    int a = b / 0;

            //    Console.WriteLine(a);
            //}
            //catch (DivideByZeroException exception)
            //{
            //    Console.WriteLine("Ups, something happened");
            //    Console.WriteLine(exception.Message);
            //    Console.WriteLine(exception.StackTrace);
            //}
        }
    }
}
