using System;
using CalculatorLibrary;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Console Calculator in c#\r");
            Console.WriteLine("------------------------\n");

            Calculator calculator = new Calculator();   
            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";

                double result = 0;
                Console.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();


                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.WriteLine("This is not valid input. Please enter an integer value:");
                    numInput1 = Console.ReadLine();
                }

                Console.WriteLine("Type another number, add then press Enter");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.WriteLine("This is not valid input. Please enter an integer value:");
                    numInput2 = Console.ReadLine();

                }

                    Console.WriteLine("choose an option from  the following list:");
                    Console.WriteLine("\ta - Add");
                    Console.WriteLine("\ts - Subtract");
                    Console.WriteLine("\tm - Multiply");
                    Console.WriteLine("\td - Divide");
                    Console.WriteLine("Your option?");

                    string op = Console.ReadLine();
                    try
                    {
                        result = calculator.DoOperation(cleanNum1, cleanNum2, op);
                        if (double.IsNaN(result))
                        {
                            Console.WriteLine("This operation will result in an mathematical error.\n");
                        }
                        else Console.WriteLine("Your result:{0:0.##}\n ", result);
                    }

                    catch (Exception e)
                    {
                    Console.WriteLine("Oh no! An exception occured trying to do the math.\n - Details:" + e.Message);
                    }

                Console.WriteLine("------------------------\n");
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            calculator.Finish();
            return;
        }

    }
}
