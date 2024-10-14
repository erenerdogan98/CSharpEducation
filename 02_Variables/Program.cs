using System;

namespace _02_Variables
{
    public class Program
    {
        static void Main(string[] args)
        {
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
            /* Represents integer types. 
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
            Console.WriteLine($"Total Amount: {totalPrice} TL"); */
            #endregion

            #region 3- Double
            /* Used for integers with fractions.
            double number = -5.36;
            Console.WriteLine(number);

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 12.82;
            orangePrice = 11.25;
            strawberryPrice = 18.32;
            potatoPrice = 9.26;
            tomatoPrice = 10.08;

            Console.WriteLine("--- Apple Kg Price:" + applePrice + "TL");
            Console.WriteLine($"--- Orange Kg Price: {orangePrice} TL");
            Console.WriteLine($"--- Strawberry Kg Price: {strawberryPrice} TL");
            Console.WriteLine($"--- Potato Kg Price: {potatoPrice} TL");
            Console.WriteLine($"--- Tomato Kg Price: {tomatoPrice} TL");

            Console.WriteLine();
            Console.WriteLine();

            double appleKg, orangeKg, strawberryKg, potatoKg, tomatoKg;
            appleKg = 1.253;
            orangeKg = 0.876;
            strawberryKg = 2.325;
            potatoKg = 3.20;
            tomatoKg = 1.78;

            double appleTotalPrice = appleKg * applePrice;
            double orangeTotalPrice = orangeKg * orangePrice;
            double strawberryTotalPrice = strawberryKg * strawberryPrice;
            double potatoTotalPrice = potatoKg * potatoPrice;
            double tomatoTotalPrice = tomatoKg * tomatoPrice;
            double shoppingTotalPrice = 0;
            Console.WriteLine($" Purchased product: Apple - Kg Price: {applePrice} TL - Kg: {appleKg} - Total Amount: {appleTotalPrice} TL");
            Console.WriteLine($" Purchased product: Orange - Kg Price: {orangePrice} TL - Kg: {orangeKg} - Total Amount: {orangeTotalPrice} TL");
            Console.WriteLine($" Purchased product: Strawberry - Kg Price: {strawberryPrice} TL - Kg: {strawberryKg} - Total Amount: {strawberryTotalPrice} TL");
            Console.WriteLine($" Purchased product: Potato - Kg Price: {potatoPrice} TL - Kg: {potatoKg} - Total Amount: {potatoTotalPrice} TL");
            Console.WriteLine($" Purchased product: Tomato - Kg Price: {tomatoPrice} TL - Kg: {tomatoKg} - Total Amount: {tomatoTotalPrice} TL");
            Console.WriteLine();
            Console.WriteLine();
            shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            Console.WriteLine($"Shopping Total Price: {shoppingTotalPrice} TL");
            Console.Read();
            */
            #endregion

            #region 4- Char
            /* For variables of type character. 
            char charaacter = 'A';*/
            #endregion

            #region Keyboard data input string variable

            /* Console.WriteLine("**** CSharp Airlines Passenger Information");
             Console.WriteLine();

             string passengerName, passengerSurname, passengerGender, passengerAge, passengerDistrict, passengerCity, passengerID;

             Console.Write("Passenger Name: ");
             passengerName = Console.ReadLine(); // Now the user will write the name...

             Console.Write("Passenger Surname: ");
             passengerSurname = Console.ReadLine();

             Console.Write("Passenger Gender: ");
             passengerGender = Console.ReadLine();

             Console.Write("Passenger Age: ");
             passengerAge = Console.ReadLine();

             Console.Write("Passenger District: ");
             passengerDistrict = Console.ReadLine();

             Console.Write("Passenger City: ");
             passengerCity = Console.ReadLine();

             Console.Write("Passenger ID: ");
             passengerID = Console.ReadLine();

             Console.WriteLine();
             Console.WriteLine("--------------------");
             Console.WriteLine($"Passenger: {passengerName} {passengerSurname} - {passengerGender} - {passengerAge} - {passengerDistrict}/{passengerCity} - {passengerID}");
             Console.ReadLine(); */
            #endregion

            #region Keyboard data input integer variable
            /*int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 18000;
            chairPrice = 4000;
            tvPrice = 13400;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.WriteLine("Please enter Shoes Count: ");
            shoesCount = int.Parse(Console.ReadLine()); // To convert int to string.

            Console.WriteLine("Please enter Computers Count: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Chairs Count: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter TV Count: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesCount*shoesPrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;
            Console.WriteLine();
            Console.WriteLine($"Total Amount: {totalPrice} TL");
            Console.ReadLine(); */
            #endregion

            #region Keyboard data input double variable
            /*double exam1, exam2, exam3, result;

            Console.Write("Please enter Exam 1: ");
            exam1 = double.Parse(Console.ReadLine()); // To converts double to string.

            Console.Write("Please enter Exam 2: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter Exam 3: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine();
            Console.WriteLine($"Your exam grade point average: {result}");*/
            #endregion

            #region Keyboard data input char variable
            char gender;
            Console.Write("Please choose gender:");
            gender = char.Parse(Console.ReadLine());
            Console.Read();
            #endregion
        }
    }
}
