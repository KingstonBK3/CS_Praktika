using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");//Input on screen

            /*
            muliline comments
            */

            var str = new string('=', 20);
            Console.WriteLine(str);
            //............................................,

            //Input - output data

            Console.Write("\n\tEnter You Name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! How are you?");

            Console.WriteLine(str);

            //.............................................

            Console.WriteLine("\nEnter numbers");
            Console.Write("\nEnter first number:");
            double firstnumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEnter second number:");
            double secondnumber = Convert.ToDouble(Console.ReadLine());

            //Divising

            if(secondnumber == 0)
            {
                Console.WriteLine("Divising by zero...");
            }
            else
            {
                double result = (double)firstnumber / secondnumber;
                Console.WriteLine($"Result: {firstnumber} / {secondnumber} = {result}");
                Console.WriteLine("Result is " + result);
            }


            //.............................................
            Console.Write("Press any key.......");
            Console.ReadKey();
        }
    }
}
