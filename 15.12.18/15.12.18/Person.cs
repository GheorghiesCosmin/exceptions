using System;
using System.Collections.Generic;
using System.Text;


    public class Person
{
    private int age;

    public int Age
    {

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Can't be negative!", "Age");
            }
            if (value == 2 || value > 80)
            {
                throw new DressCodeExceptions();
            }

            this.age = value;
        }
    }

    public Person(int age)
    {
        this.Age = age;
    }
}
