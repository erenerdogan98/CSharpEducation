using System;

namespace _03_MakingDecision
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            /*Console.WriteLine("Please write password");
            string password;
            password = Console.ReadLine();

            if (password == "abcd")
            {
                Console.WriteLine("Password is correct.");
            }
            else
            {
                Console.WriteLine("Password is not correct.");
            }

            // can be write also like that
            if (password == "abcd")
                Console.WriteLine("Password is correct");
            else
                Console.WriteLine("Password is not correct");

            string capital, country;
            Console.WriteLine("Write Capital");
            capital = Console.ReadLine();
            Console.WriteLine("Write Country");
            country = Console.ReadLine();

            if (capital == "ankara" & country == "türkiye")
                Console.WriteLine("Correct.");
            else
                Console.WriteLine("Incorrect");

            // Let's do basic practice for Integers
            int number;
            Console.WriteLine("Write number ");
            number = int.Parse(Console.ReadLine());
            if (number == 2)
                Console.WriteLine("Number is correct");
            else
                Console.WriteLine("Number is not correct.");
           

            // Ex - 3-
            int exam1, exam2, exam3, ave;
            string result = "..";
            Console.Write("Exam 1: ");
            exam1 = int.Parse(Console.ReadLine());
            Console.Write("Exam 2: ");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("Exam 3: ");
            exam3 = int.Parse(Console.ReadLine());

            ave = (exam1+ exam2 + exam3) / 3;
            Console.WriteLine($"Average of exams : {ave}");

            if (ave > 0 & ave <= 50)
                result = "Failed";
            if (ave > 50 & ave <= 70)
                result = "Not Bad";
            if (ave > 70 & ave < 85)
                result = "Good";
            if (ave >= 85)
                result = "Very Good";
            Console.WriteLine(result); 

            // EX-4-  | means , or & means and.

            string city;
            Console.WriteLine("Write a city");
            city = Console.ReadLine();

            if (city == "kutahya" | city == "ankara" | city == "istanbul" | city == "bursa")
                Console.WriteLine("City is available.");
            else
                Console.WriteLine("City is not available.");

            // Ex-5-

            Console.WriteLine("Please write your username");
            string username = Console.ReadLine();
            if (username != "admin")
                Console.WriteLine("Error.");
            else
                Console.WriteLine("Welcome");
            Console.ReadKey();
            */
            #endregion

            #region Mode Operations
            /*
            // Mode is showing with % .
            int number;
            number = 33;
            int result = number % 5;
            Console.WriteLine(result); 

            // Ex-2-
            Console.Write("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 % num2;
            Console.WriteLine($"The remainder of the division of the 1st number by the 2nd number: {result}");
          

            // Ex-3- 
            Console.Write("Write number: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("Number is Even");
            else 
                Console.WriteLine("Number is Odd");
            
                          */
            #endregion

            #region  Decision structures with char variables 
            /* 
             Console.Write("Please write your team first word: ");
            char team = char.Parse(Console.ReadLine());
            if (team == 'F' | team == 'f')
                Console.Write("Fenerbahce");
            if (team == 'B' | team == 'b')
                Console.Write("Besiktas");
            if (team == 'G' | team == 'g')
                Console.Write("Galatasaray");
            else
                Console.Write("..");*/
            #endregion

            #region Basic Ex Project
            /*
            Console.WriteLine("***** Restaurant *****");
            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine("1- Main Dishes");
            Console.WriteLine("2- Soups");
            Console.WriteLine("3- Pizzas");
            Console.WriteLine("4- Drinks");
            Console.WriteLine("5- Desserts");
            Console.WriteLine("---------------");
            Console.WriteLine();

            string menuItem;

            Console.Write("Select the menu we want to see the details of: ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("---------- Maind Dishes -----------");
                Console.WriteLine();
                Console.WriteLine("1-) Chicken with curry sauce");
                Console.WriteLine("2-) Chips");
                Console.WriteLine("3-) Beans and Rice");
                Console.WriteLine("4-) Lasagna");
                Console.WriteLine("5-) Steak");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
            }

            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("---------- Soups -----------");
                Console.WriteLine();
                Console.WriteLine("1-) Lentil Soup");
                Console.WriteLine("2-) Ezogelin Soup");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
            }

            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("---------- Pizzas -----------");
                Console.WriteLine();
                Console.WriteLine("1-) Mixed Pizza");
                Console.WriteLine("2-) Pepperoni Pizza");
                Console.WriteLine("3-) Chicken Pizza");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
            }

            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("---------- Drinks -----------");
                Console.WriteLine();
                Console.WriteLine("1-) Water");
                Console.WriteLine("2-) Cola");
                Console.WriteLine("3-) Ayran");
                Console.WriteLine("------------------------------");
                Console.WriteLine();
            }

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("---------- Desserts -----------");
                Console.WriteLine();
                Console.WriteLine("1-) Baklava");
                Console.WriteLine("2-) Triplet");
                Console.WriteLine("3-) Rice pudding");
                Console.WriteLine("4-) Profiterole");
                Console.WriteLine("--------------------------------");
                Console.WriteLine();
            }
            Console.ReadLine(); */
            #endregion

            #region Switch Case

            /* Console.Write("Enter a month number: ");
             int monthNumber = int.Parse(Console.ReadLine());

             // switch + tab tab
             switch (monthNumber)
             {
                 case 1: Console.Write("January"); break;
                 case 2: Console.Write("February"); break;
                 case 3: Console.Write("March"); break;
                 case 4: Console.Write("April"); break;
                 case 5: Console.Write("May"); break;
                 case 6: Console.Write("June"); break;
                 case 7: Console.Write("July"); break;
                 case 8: Console.Write("August"); break;
                 case 9: Console.Write("September"); break;
                 case 10: Console.Write("October"); break;
                 case 11: Console.Write("November"); break;
                 case 12: Console.Write("December"); break;
                 default: Console.Write("Incorrect input value"); break;
             }
             Console.ReadKey();
            */
            #endregion

            #region Calculator by Using Switch Case

            int number1, number2, result;
            char symbol;
            Console.Write("Number 1: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Number 2: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Symbol: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result= number1 + number2;
                    Console.Write($"Sum: {result}");
                    break;
                case '-':
                    result = number1 - number2;
                    Console.Write($"Minus: {result}");
                    break;
                case '*':
                    result = number1 * number2;
                    Console.Write($"Multiply: {result}");
                    break;
                case '/':
                    result = number1 / number2;
                    Console.Write($"Divide: {result}");
                    break;
                default:
                    break;
            }
            #endregion
        }
    }
}
