using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTut
{
    class Program
    {
        static void Main()
        {
            /*
            int num1 = 5;
            int num2 = 7;

            int total = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            int quotient = num1 / num2;
            int remainder = num1 % num2;
            //use modulus to determine whether a number is even or odd
            int remainder1 = num1 % 2;


            Console.WriteLine(total);
            Console.WriteLine(difference);
            Console.WriteLine(product);
            Console.WriteLine(quotient);
            Console.WriteLine(remainder);
            Console.WriteLine(remainder1);
            

            double num1 = 7.03230923;
            float num2 = 5.9f;

            float total = (float)num1 + num2;

            bool trueOrFalse = 12 < 5;
            Console.WriteLine(trueOrFalse.ToString());
            Console.Read();

            int roomTemp = 78;
            int outsideTemp = 95;

            bool isWarm = outsideTemp >= roomTemp;
            Console.WriteLine(isWarm);
            Console.ReadLine();
            */

            // BEGIN PROJECT -----------------------------------------------------------------------------
            // Takes an input from the user, multiplies it by 50, and prints the result to the console(>10,000,000)

            int multiplier = 50;

            Console.WriteLine("Please enter a number and it will be multiplied by 50.");

            string userNumber = Console.ReadLine();
            int numberInput = Convert.ToInt32(userNumber);
            Console.WriteLine("The number we've created together is " + multiplier * numberInput);

            Console.ReadLine();


            // Takes an input from the user, adds 25 to it, and prints the result to the console.

            int addedAmount = 25;

            Console.WriteLine("Please enter a number and it will be added to 25.");

            string userNumber1 = Console.ReadLine();
            int numberInput1 = Convert.ToInt32(userNumber1);
            int total = numberInput1 + addedAmount;
            Console.WriteLine("The number we've created together is " + total);

            Console.ReadLine();


            // Takes an input from the user, divides it by 12.5, and prints the result to the console.

            double divideAmount = 12.5;

            Console.WriteLine("Please enter a number and it will be divided by 12.5.");

            string userNumber2 = Console.ReadLine();
            double numberInput2 = Convert.ToDouble(userNumber2);

            Console.WriteLine("The number we've created together is " + numberInput2 / divideAmount);

            Console.ReadLine();


            // Takes an input from the user, checks if it is greater than 50, and prints true or false to the console.

            int comparedValue = 50;

            Console.WriteLine("Please enter a number, and the program will check if is greater than a specified value. ");

            string userNumber3 = Console.ReadLine();
            int numberInput3 = Convert.ToInt32(userNumber3);

            bool isGreaterThan = numberInput3 > comparedValue ;

            Console.WriteLine("Our number is " + comparedValue + ". Your number is " + numberInput3 + ". If your number is greater than our number you will read true, if it is less you will read false." + " Press enter to see.");
            Console.ReadLine();

            Console.WriteLine(isGreaterThan);
            Console.ReadLine();


            // Takes an input from the user, divides it by 7, and prints the remainder to the console.

            Console.WriteLine("Please enter a number.");

            int dividedBy = 7;
            string userNumber4 = Console.ReadLine();
            double numberInput4 = Convert.ToInt32(userNumber4);

            Console.WriteLine("The number you entered is " + userNumber4 + ", and the remainder of that number divided by " + dividedBy + " is; " + numberInput4 % dividedBy);

            Console.ReadLine();

        }
    }
}
