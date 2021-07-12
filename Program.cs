using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("This is a calculator... Try me...");
            while (true)
            {
                Console.WriteLine("Please enter two numbers (multiplied, divided, added, or subtracted)...");

                string calculatorInput = Console.ReadLine();

                if (calculatorInput.Contains("+"))
                {
                    string[] numberStrings = calculatorInput.Split('+');

                    double firstNumber = double.Parse(numberStrings[0]);

                    double secondNumber = double.Parse(numberStrings[1]);

                    double addition = firstNumber + secondNumber;

                    Console.WriteLine(firstNumber + " + " + secondNumber + " = " + addition);

                }
                if (calculatorInput.Contains("-"))
                {
                    string[] numberStrings = calculatorInput.Split('-');

                    double firstNumber = double.Parse(numberStrings[0]);

                    double secondNumber = double.Parse(numberStrings[1]);

                    double subtraction = firstNumber - secondNumber;

                    Console.WriteLine(firstNumber + " - " + secondNumber + " = " + subtraction);


                }
                if (calculatorInput.Contains("x"))
                {
                    string[] numberStrings = calculatorInput.Split('x');

                    double firstNumber = double.Parse(numberStrings[0]);

                    double secondNumber = double.Parse(numberStrings[1]);

                    double multiplication = firstNumber * secondNumber;

                    Console.WriteLine(firstNumber + " x " + secondNumber + " = " + multiplication);
                }
                if (calculatorInput.Contains("*"))
                {
                    string[] numberStrings = calculatorInput.Split('*');

                    double firstNumber = double.Parse(numberStrings[0]);

                    double secondNumber = double.Parse(numberStrings[1]);

                    double multiplication = firstNumber * secondNumber;

                    Console.WriteLine(firstNumber + " x " + secondNumber + " = " + multiplication);
                }
                if (calculatorInput.Contains("/"))
                {
                    string[] numberStrings = calculatorInput.Split('/');

                    double firstNumber = double.Parse(numberStrings[0]);

                    double secondNumber = double.Parse(numberStrings[1]);

                    double division = firstNumber / (double)secondNumber;

                    Console.WriteLine(firstNumber + " / " + secondNumber + " = " + division);
                }
            }
            
        }
    }
}
