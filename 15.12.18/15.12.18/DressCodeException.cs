using System;
using System.Collections.Generic;
using System.Text;


    public class DressCodeExceptions : ApplicationException
    {
        private readonly string message = "You are not wearing an Elf costume, and you are underage";
        public DressCodeExceptions()
        {
            Console.WriteLine(message);
        }
    }
