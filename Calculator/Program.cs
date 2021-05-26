using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ======================================== ");
            Console.WriteLine("||Welcome to a very confusing calculator||");
            Console.WriteLine("||Please enter a simple mathematical    ||"); 
            Console.WriteLine("||action(only +-/*^ are allowed). Enjoy!||");
            Console.WriteLine("||You can use negative numbers!         ||");
            Console.WriteLine(" ======================================== ");

             var input = Console.ReadLine();
             input = input.Replace(" ", String.Empty);

            string num1 = "";
            string num2 = "";
    
            foreach (char symbol in input)
            {
                if (input.IndexOf(symbol) == 0 && Char.ToString(symbol) == "-") {
                    num1 += symbol;
                }
                else if (Char.IsDigit(symbol) == true)
                {
                    num1 += symbol;
                }

                else if (Char.IsDigit(symbol) == false)
                {
                    int index = input.IndexOf(symbol);

                    num2 = input.Substring(input.IndexOf(symbol) + 1);

                    Console.WriteLine("First number is: " + num1);
                    Console.WriteLine("Second number is: " + num2);

                    int num1value = Int32.Parse(num1);
                    int num2value = Int32.Parse(num2);

                    switch (Char.ToString(symbol))
                    {
                        case "+":
                            Console.WriteLine(num1value + " added to " + num2value + " is: " + (num1value + num2value));
                            break;
                        case "-":
                            Console.WriteLine(num1value + " minus " + num2value + " is: " + (num1value - num2value));
                            break;
                        case "/":
                            Console.WriteLine(num1value + " divided by " + num2value + " is: " + (num1value / num2value));
                            break;
                        case "*":
                            Console.WriteLine(num1value + " multiplied by " + num2value + " is: " + (num1value * num2value));
                            break;
                        case "^":
                            Console.WriteLine(num1value + " power by " + num2value + " is: " + Math.Pow(num1value,num2value));
                            break;
                        default:
                            Console.WriteLine("Invalid mathematical action!");
                            break;

                    }
                        return;
                }


            } 

        }
    }
}

