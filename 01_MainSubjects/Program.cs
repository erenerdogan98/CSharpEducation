using System;

namespace _01_MainSubjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Print Commands 
            /*
            Console.WriteLine("Hello World!"); 
            Console.Write("Hey!");
            - Difference between Console.WriteLine (cw is shortcut) and Console.Write is that Console.WriteLine goes to the next line at the end of the sentence.- */

            /* Let's do simple practice ..
            Console.WriteLine("*** Food Categories ***");
            Console.WriteLine();
            Console.WriteLine("1- Soups");
            Console.WriteLine("2- Main Course");
            Console.WriteLine("4- Salads");
            Console.WriteLine("5- Drinks");
            Console.WriteLine("6- Desserts");
            */
            #endregion

            #region Variables
            /* The way variables are defined is the type of variable and the name we will assign to the variable =>
             variableType variable_name; 
             Naming Variations 
             1-) Camel Case => The first letter of the first word is lowercase, the first letter of the following words is uppercase.
            */

            #region 1- string
            /*
            string name;
            name = "Eren";
            Console.WriteLine(name); 
            string customerName = "Ramazan";
            string customerSurname = "Çınar";
            string customerPhone = "+90 500 325 10 10";
            string customerEmail = "test123@gmail.com";
            string district = "Kadikoy";
            string city = "Istanbul";

            Console.WriteLine("*** Reservation Card ***");
            Console.WriteLine();
            Console.WriteLine("_________________________");
            Console.WriteLine("Customer : " + customerName + " " + customerSurname);
            // Can write also like that , string interpolation
            Console.WriteLine($"Customer : {customerName} {customerSurname}");
            Console.WriteLine($"Contact : {customerPhone}"); 
            Console.WriteLine($"Email : {customerEmail}"); 
            Console.WriteLine($"Address : {district}/{city}");

            // Variables have an assignment order, from top to bottom of the code. Let's show a sample ex.
            // customerName = "Fatmanur";
            Console.WriteLine(customerName);
            // Now , customerName in that line will be Fatmanur ...
            customerSurname = "Ay";
            customerPhone = "+90 500 325 30 14";
            customerEmail = "test123@gmail.com";
            district = "Yenimahalle";
            city = "Ankara";
            Console.WriteLine("_________________________");
            Console.WriteLine($"Customer : {customerName} {customerSurname}");
            Console.WriteLine($"Contact : {customerPhone}");
            Console.WriteLine($"Email : {customerEmail}");
            Console.WriteLine($"Address : {district}/{city}");
            */
            #endregion

            #region 2- int
            /* Represents integer types. */
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("*** Restaurant Menu Prices ***");
            Console.WriteLine("---- Hamburger : " + hamburgerPrice + " TL ");
            Console.WriteLine($"---- Pizza : {pizzaPrice} TL");
            Console.WriteLine($"---- Coke : {cokePrice} TL");
            Console.WriteLine($"---- Water : {waterPrice} TL");
            Console.WriteLine($"---- Lemonade : {lemonadePrice} TL");

            // Let's define counts for each them , and total prices , total price be 0 at the begin.
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;
            int totalPrice = 0;

            hamburgerCount = 3;
            cokeCount = 1;
            waterCount = 3;
            friesCount = 2;
            pizzaCount = 2;
            lemonadeCount = 3;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

            Console.WriteLine("________________________________");
            Console.WriteLine($"Hamburger Price: {totalHamburgerPrice} TL");
            Console.WriteLine($"Coke Price: {totalCokePrice} TL");
            Console.WriteLine($"Water Price: {totalWaterPrice} TL");
            Console.WriteLine($"Fries Price: {totalFriesPrice} TL");
            Console.WriteLine($"Pizza Price: {totalPizzaPrice} TL");
            Console.WriteLine($"Lemonade Price: {totalLemonadePrice} TL");
            Console.WriteLine();
            Console.WriteLine($"Total Amount: {totalPrice} TL");
            #endregion
            #endregion

            Console.Read();
        }
    }
}
