using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Reflection.Metadata;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Assignment_Session03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Baseclass data = new Baseclass();

            #region Q1 - Write a program that allows the user to enter a number then print it.

            Console.Write("Enter number integer(numberOne)");
            data.numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number decimal(numberTwo)");
            data.numberTwo = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter mathematical operations (+ - * /):");
            string operations = Console.ReadLine();
            Console.WriteLine("\n -- Result --");

            if (operations == "+")
            {
                decimal sumOne = data.numberOne + data.numberTwo;
                Console.WriteLine("data.numberOne + data.numberTwo = " + sumOne);
            }
            else if (operations == "-")
            {
                decimal SubtractionOne = data.numberOne - data.numberTwo;
                Console.WriteLine("data.numberOne - data.numberTwo = " + SubtractionOne);
            }
            else if (operations == "*")
            {
                decimal MultiplicationOne = data.numberOne * data.numberTwo;
                Console.WriteLine("data.numberOne * data.numberTwo = " + MultiplicationOne);
            }
            else if (operations == "/")
            {
                decimal DividedByOne = data.numberOne / data.numberTwo;
                Console.WriteLine("data.numberOne / data.numberTwo = " + DividedByOne);
            }
            else
            {
                Console.WriteLine("Invalid operation. Please enter one of the following: +, -, *, /");
            }
            Console.WriteLine("\n Press any key to exit...");
            Console.ReadKey();


            #endregion



            #region Q2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen

            string imput = "abc123";
            int result;

            bool isSuccess = int.TryParse(imput, out result);

            if (isSuccess)
                Console.WriteLine("Converted to numbers successfully" + result);
            else
                Console.WriteLine("The conversion to numbers failed.");

            // The conversion to numbers failed.
            //TryParse attempts to convert the string to numbers(int or decimal) 
            //Without throwing an error if the data is invalid.

            #endregion




            #region Q3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            Console.Write("Please Enter number integer (numberOne)");
            data.numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter number decimal (numberTwo)");
            data.numberTwo = Convert.ToDecimal(Console.ReadLine());

            decimal sum = data.numberOne + data.numberTwo;
            decimal Subtraction = data.numberOne - data.numberTwo;
            decimal Multiplication = data.numberOne * data.numberTwo;
            decimal DividedBy = data.numberOne / data.numberTwo;

            Console.WriteLine("\n -- Result --");


            Console.WriteLine("data.numberOne + data.numberTwo = " + sum);
            Console.WriteLine("data.numberOne - data.numberTwo = " + Subtraction);
            Console.WriteLine("data.numberOne * data.numberTwo = " + Multiplication);
            Console.WriteLine("data.numberOne + data.numberTwo = " + DividedBy);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();


            #endregion



            #region Q4 - Write C# program that Extract a substring from a given string.


            Console.Write("Please Enter a string : ");
            data.text = Console.ReadLine();
            Console.Write("Please Enter how many characters to extract from : ");
            data.length = Convert.ToInt32(Console.ReadLine());

            if (data.length >= 0 && data.length <= data.text.Length)
            {
                string resultThird = data.text.Substring(0, data.length);
                Console.WriteLine("Retrieve part of the string" + resultThird);
            }
            else
                Console.WriteLine(" Length is not acceptable ");



            #endregion





            #region Q5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen


            data.number = 100;
            int nextNumber = data.number;

            Console.WriteLine("Before modification");
            Console.WriteLine("Date number = " + data.number);
            Console.WriteLine("nextNumber =" + nextNumber);

            nextNumber = 200;

            Console.WriteLine("After modification");
            Console.WriteLine("Date number = " + data.number);
            //Console.WriteLine("nextNumber =" + nextNumber);


            //First:- data.number = 100; => We saved the value 100 in the variable number.
            //Second :- int nextNumber = data.number; => Then I created a new variable named nextNumber and copied the value of data.number into it.
            //          At this point, nextNumber is a completely independent copy of data.number, because it is of the value type.


            #endregion



            #region Q6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            data.number = 200;
            int nextNumberTwo = data.number;

            Console.WriteLine("Before modification");
            Console.WriteLine("Date number = " + data.number);
            Console.WriteLine("nextNumberTwo =" + nextNumberTwo);

            nextNumberTwo = 400;

            Console.WriteLine("After modification");
            Console.WriteLine("Date number = " + data.number);
            Console.WriteLine("nextNumberTwo =" + nextNumberTwo);


            //First:- data.number = 100; => We saved the value 100 in the variable number.
            //Second :-   int nextNumberTwo; = data.number; => Then I created a new variable named nextNumberTwo and copied the value of data.number into it.
            //          At this point, nextNumber is a completely independent copy of data.number, because it is of the value type.


            #endregion

            #region Q7 - Write C# program that take two string variables and print them as one variable 

            Console.Write("Enter First string ");
            data.First = Console.ReadLine();
            Console.Write("Enter Second string ");
            data.Second = Console.ReadLine();

            string resultOne = $"{data.First} {data.Second}";

            Console.WriteLine("\n -- Result -- " + resultOne);


            string result2 = $"{data.First} {data.Second}";

            Console.WriteLine("\n -- Result -- " + result2);





            #endregion


            #region Q8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time
            // Note :  The formula for simple interest is Interest = (principal * rate * time ) /100.

            //First solution

            //Console.Write("Enter  principal amount ");
            //decimal principalAmount = Convert.ToDecimal(value: Console.ReadLine());
            //Console.Write("Enter rate of interest ");
            //decimal rateOfInterest = Convert.ToDecimal(value: Console.ReadLine());
            //Console.Write("Enter time in number of Months ");
            //decimal numberOfMonths = Convert.ToInt32(value: Console.ReadLine());

            //decimal interest = (principalAmount * rateOfInterest * numberOfMonths) / 100;

            //Console.WriteLine($"\n simple interest = {interest}");


            //Second solution

            CultureInfo culture = CultureInfo.InvariantCulture;

            Console.Write("Enter  principal amount ");
            decimal principalAmount = Convert.ToDecimal(value: Console.ReadLine(), culture);
            Console.Write("Enter rate of interest ");
            decimal rateOfInterest = Convert.ToDecimal(value: Console.ReadLine(), culture);
            Console.Write("Enter time in number of Months ");
            int numberOfMonths = Convert.ToInt32(value: Console.ReadLine());


            if
                (principalAmount > 0 && rateOfInterest > 0 && numberOfMonths > 0)
            {
                decimal interest = (principalAmount * rateOfInterest) / 100;
                decimal totalAmount = principalAmount + interest;
                decimal monthlyPayment = totalAmount / numberOfMonths;

                if (monthlyPayment > 0)
                    Console.WriteLine($"\n simple interest = {monthlyPayment}");
                else
                    Console.WriteLine("Monthly payment cannot be zero or negative.");
            }
            else
                Console.WriteLine("Invalid input. Please enter positive numeric values for principal amount, rate of interest, and number of months.");

            Console.WriteLine("\n Press any key to exit...");
            Console.ReadKey();

            #endregion



            #region Q9 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            // Note: The formula for BMI is BMI = (Weight) / (Height * Height)

            CultureInfo cultureTwo = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter weight in kilograms: ");
            decimal weight = Convert.ToDecimal(Console.ReadLine(), cultureTwo);
            Console.WriteLine("Enter height in meters: ");
            decimal height = Convert.ToDecimal(Console.ReadLine(), cultureTwo);

            if (weight > 0 && height > 0)
            {
                decimal bmi = weight / (height * height);
                Console.WriteLine($"\nYour Body Mass Index (BMI) is: {bmi:F2}");

                if (bmi < 18.5m)
                    Console.WriteLine("Underweight");
                else if (bmi < 24.9m)
                    Console.WriteLine("Normal weight");
                else if (bmi < 29.9m)
                    Console.WriteLine(" Overweight");
                else
                    Console.WriteLine(" Obesity");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter positive numeric values for weight and height.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

            #endregion

            #region Q10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result.
            ///that below 10 degrees is "Just Cold"
            ///above 30 degrees is "Just Hot"
            ///anything else is "Just Good"


            Console.WriteLine("Enter the temperature in degrees: ");

            if (int.TryParse(Console.ReadLine(), out int temperature))
            {
                string resultTwo = temperature < 10 ? "Just Cold" :
                                temperature > 30 ? "Just Hot" :
                                "Just Good";
                Console.WriteLine($"The temperature is: {resultTwo}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a values for temperature.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();


            #endregion

            #region Q11  Write a program that takes the date from the user and displays it in various formats using string interpolation.
            ///Ex:
            ///Today’s date : 20 , 11 , 2001
            ///Today's date : 20 / 11 / 2001
            ///Today's date : 20 – 11 – 2001

            Console.WriteLine("Enter day ");
            data.day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month ");
            data.month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year ");
            data.year = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n Today date : {data.day} , {data.month} , {data.year} ");
            Console.WriteLine($"\n Today date : {data.day} , {data.month} / {data.year} ");
            Console.WriteLine($"\n Today date : {data.day} , {data.month} - {data.year} ");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();



            #endregion



            #region Q12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            ///Example(1)
            ///Input: 12
            ///Output: Yes
            ///Example(2)
            ///Input: 9
            ///Output: No

            Console.WriteLine("Enter number ");
            data.number = int.Parse(Console.ReadLine());

            if (data.number % 3 == 0 && data.number % 4 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

            #endregion




            #region Q13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            ///Example(1)
            ///Input: -5
            ///Output: negative
            ///Example(2)
            ///Input: 10
            ///Output: positive

            Console.WriteLine("Enter number ");
            data.number = int.Parse(Console.ReadLine());

            if (data.number < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("Positive");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();


            #endregion

            #region Q14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            ///Example(1)
            ///Input: 7,8,5
            ///Output:
            ///max element = 8
            ///min element = 5
            ///Example(2)
            ///Input: 3 6 9
            ///Outputs:
            ///Max element = 9
            ///Min element = 3

            Console.WriteLine("Enter first number");
            data.number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second  number");
            data.numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third  number");
            data.numberThree = int.Parse(Console.ReadLine());

            int max = data.number;
            if (data.numberOne > max)
                max = data.numberOne;
            if (data.numberThree > max)
                max = data.numberThree;

            int min = data.number;
            if (data.numberOne < min)
                min = data.numberOne;
            if (data.numberThree < min)
                min = data.numberThree;

            Console.WriteLine($"\nMax element = {max}");
            Console.WriteLine($"\nMax element = {min}");


            #endregion




            #region Q15 - Write a program that allows the user to insert an integer number then check If a number is even or odd.


            Console.WriteLine("Enter number ");
            data.number = int.Parse(Console.ReadLine());

            if (data.number % 2 == 0)
                Console.WriteLine("even ");
            else
                Console.WriteLine("odd ");



            #endregion

            #region Q16 - Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            ///Example(1)
            ///Input: O
            ///Output: vowel
            ///Example(2)
            ///Input: b
            ///Output: Consonant

            Console.WriteLine("Enter character ");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input) && input.Length == 1)
            {

                data.character = char.ToLower(input[0]);

                if ("aeIou".Contains(data.character))
                    Console.WriteLine("vowel");
                else if (char.IsLetter(data.character))
                    Console.WriteLine("consonant");
                else
                    Console.WriteLine("Not a valid letter");

            }
            else
                Console.WriteLine("Please enter a single character.");


            #endregion

            #region Q17 - Write a program to input the month number and print the number of days in that month.
            /// Example
            /// Input: Month Number: 1
            /// Output: Days in Month: 31

            int[] daysInMonth =  { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.WriteLine("Enter number of month ");
            if(int.TryParse(Console.ReadLine() , out int month) && month >= 1 && month <= 12)
            {
                data.month = month;
                int days = daysInMonth[data.month - 1];
                Console.WriteLine($"Days in month: {days}");
            }
            else
            {
                Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

            #endregion

        }
    }
}
