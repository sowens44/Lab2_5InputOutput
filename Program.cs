using System;

namespace Lab2_5InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab2_5 New Changes today 
            Console.WriteLine("Hello World, I'm here!!");
            // 1
            int intFirstNumber = 0;
            int intSecondNumber = 0;
            int intResult = 0;
            double dblResult = 0;


            Console.WriteLine("Enter your First Number: ");
            intFirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Second Number: ");
            intSecondNumber = Convert.ToInt32(Console.ReadLine());

            //Adding
            intResult = intFirstNumber + intSecondNumber;
            Console.WriteLine($"{intFirstNumber} plus {intSecondNumber} is {intResult}");

            //Subtracting
            intResult = intFirstNumber - intSecondNumber;
            Console.WriteLine($"{intFirstNumber} minus {intSecondNumber} is {intResult}");

            //Multiplying
            intResult = intFirstNumber * intSecondNumber;
            Console.WriteLine($"{intFirstNumber} times {intSecondNumber} is {intResult}");

            //Dividing
            intResult = intFirstNumber / intSecondNumber;
            Console.WriteLine($"{intFirstNumber} Divided by {intSecondNumber} is {intResult}");

        }
    }
}
