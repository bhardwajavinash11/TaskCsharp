using System;

namespace HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            //Hello World
            Console.WriteLine("Hello World");
            Console.WriteLine("\n");
            Console.WriteLine("Boxing");

            int numBoxing = 2024;

            //Boxing
            object objBoxing = numBoxing;

            numBoxing = 200;

            System.Console.WriteLine("Value - type value of num is : {0}", numBoxing);
            System.Console.WriteLine("Object - type value of obj is : {0}", objBoxing);


            Console.WriteLine("\n");
            Console.WriteLine("Unboxing");

            int numUnboxing = 2024;

            // boxing
            object objUnboxing = numUnboxing;

            // unboxing
            int i = (int)objUnboxing;

            // Display result
            Console.WriteLine("Value of ob object is : " + objUnboxing);
            Console.WriteLine("Value of i is : " + i);

        }
    }
}