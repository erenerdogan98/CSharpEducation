using System;

namespace _05_LoopsStarts
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region creating 10 stars one below the other
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region create 10 stars side by side 
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region creating 10 stars side by side and one below the other
            //for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("**********");
            //    }
            #endregion

            #region Right triangle
            //for (int i = 1; i <= 5; i++) 
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Reverse right triangle
            //for (int i = 5; i > 0; i--) 
            //{
            //    for (int j = 1; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region right triangle and it's reverse
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 5; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region baklava
            //int n = 5;

            //for (int i = 1; i <= n; i++) 
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int  k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - 1; --j > 0; j--)
            //    {
            //        Console.Write("  ");
            //    }

            //    for ( int k = 1; k <=2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Pyramid
            //int n = 6;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = n - i; j >=1; j--) // for spaces
            //    {
            //        Console.Write(" ");
            //    }

            //    for( int k = 0; k < 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Reverse Pyramid

            //int n = 5;
            //for (int i = n; i >=1; i--)
            //{
            //    for (int j = n - i; j >=1; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            Console.ReadKey();

        }
    }
}
