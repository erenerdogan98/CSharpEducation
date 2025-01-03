using System;
using System.ComponentModel;

namespace _04_Loops
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region 1- For
            /*
            for (int i = 0; i < 10; i++) // i = 0 means loop starts from 0 , i < 10 means loop goes until 10 , i++ means It continues by increasing by one.
            {
                Console.WriteLine(i);
            }

            // Example 
            for (int i = 1; i <= 62; i+=6) // now it starts from 1 and to 62 , i+=6 means , it continues by increasing by six.
            {
                Console.WriteLine(i);
            }
      
            // Ex-2-
            Console.WriteLine("Enter the number of pieces you want.");
            int start = int.Parse(Console.ReadLine());

            for (int i = 0; i <= start; i++) 
            {
                Console.WriteLine("Yaşasın Cumhuriyet!");
            }   
            Console.ReadLine();
                  */

            #region Using for loop with Making Decisions
            /*
                        for (int i = 0; i <=185; i++)
                        {
                            if(i % 10 == 0)
                                Console.WriteLine(i);
                        }

                        // Ex

                        int totalValue = 0;
                        for(int i = 2; i < 24; i++)
                        {
                            if (i % 3 == 0)
                            {
                                totalValue += i; // That means , it sums to values for each i value.
                                Console.WriteLine(i);
                            }

                        }
                        Console.WriteLine("-------");
                        Console.WriteLine(totalValue);

                        int count = 0;
                        for (int i = 2; i < 24; i++)
                        {
                            if (i % 3 == 0)
                            {
                                count ++; // That means , it shows us to count of i in loop..
                            }

                        }
                        Console.WriteLine(count);
                        Console.ReadLine();
            */
            #endregion
            #endregion

            #region 2- While
            // Rule is simple , while (Condition) {operations} , condtion is boolean type.

            /*int i = 0;
            while (i <= 10)
            {
                Console.WriteLine("Hello!");
                i++;
            }
 

            // Ex-1-
            int i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            }
                       */
            // Ex-2-
            int i = 0;
            int sum = 0;
            while (i <= 10)
            {
                sum += i; // it means , sum value will equal sums of i in loop.
                i++; // it increas i by one .
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            #endregion
        }
    }
}
