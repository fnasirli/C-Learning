using System;

namespace F1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Program Started");

            Console.Write("a:");
            float a = float.Parse(Console.ReadLine());

            Console.Write("b:");
            float b = float.Parse(Console.ReadLine());

            float z = GetResultBySum(a, b);
            Console.WriteLine("Result :" + z);

            /*
                 while (true)
                 {
                     try
                     {
                         Console.Write("a:");
                         float a = float.Parse(Console.ReadLine());

                         while (true)
                         {
                             try
                             {
                                 Console.Write("b:");
                                 float b = float.Parse(Console.ReadLine());

                                 float result = a + b;
                                 Console.WriteLine("Output result is: " + result);
                                 break;
                             }
                             catch (Exception exc)
                             {
                                 Console.WriteLine("Number only can get integer value. " + exc.Message);
                             }
                         }
                         Console.WriteLine("Successfully executed.");
                         break;
                     }
                     catch (Exception exc)
                     {
                         Console.WriteLine("Number only can get integer value. " + exc.Message);
                     }
                 } 
                 */
        }


        //Metoddur. Meton Sql da funksiya ile eynidir.
        static float GetResultBySum(float z, float q)
        {
            return z + q;
        }


        //new comment for git



    }

}
