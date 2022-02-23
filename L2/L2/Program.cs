using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

            /// <summary>
            /// This is XML comment
            /// </summary>
            /// <param name="m"> bu deyishen ne ucundu ne deyer ala biler</param>
            /// 
            static void Main2(int m)
            {
                Console.WriteLine("Hello World!");


            }

            static void Main3(string[] args)
            {
                Console.WriteLine("Hello World!");

                //Conversion 2 novu var : 
                // 1) Implicit: int -> float (32 -> 32.0)
                int i = 5;
                double a = i;
                Console.WriteLine("Implicit:" + a + a.GetType());


                // 2) Explicit: float -> int (32.62 -> 32)
                float b = 2.3F; //Eger sonuna f\F yazmasam Double kimi goturur
                int x = (int)b;
                Console.WriteLine("Explicit:" + x + x.GetType());

                //Artimetric Overflow erroru sqlde olandan burda da var. lakin bu checki etmek ucun 
                // Chaeck command istifade etmek lazimdir. Yoxsa error almayacayiq

                checked
                {

                }

                //35402

                #region Convertions

                //Conversion br neche novu var :
                string q = "55";
                string n = "5x5";
                var c = double.Parse(q);
                var bol = int.TryParse(q, out int result);
                var bol2 = int.TryParse(n, out int result2);

                #endregion

                Console.WriteLine(Convert.ToDouble(q));
                Console.WriteLine(c);
                Console.WriteLine(bol);
                Console.WriteLine(bol2);



                //SizeOf(); - neche bayt oldugunu -hecmi gorsedir
                //TypeOf(); - hansi type-dedir menasina gelir 

                //Deyishenin hem null hem de diger deyerler almasi ucun : 
                // int vv = null; - Bu format error verir

                int? v = null;

                if (v.HasValue)
                {
                    //V nin her hansi sa deyeri varmi onu yoxlayir
                    int z = v.Value;
                }


                //Proqram run olunanda Ram-da iki cur icra olunur
                //1)Stack -  Value tipler ucun
                // Main method with n parametr( a methoc (b method)) 
                //Lifo mentiqi ile n parametrini bir bir butun metodlari ishlede ishledeen 
                //sonda Main methodu neticeni getirir. Nested objects kimi.
                //Bir basha verilen parametre uygun yaddashda yer tutur.

                //2) Heap - Referance ucun 
                //Heap olcusu belli olmayan objectler ile ishleyir. List , new object ve s.
                //Minimal null deyer olaraq yaddashda saxlayir
                //comment

            }

            static void Main5(string[] args)
            {
                //Console.WriteLine("Hello World!");

                while (true)
                {
                    try
                    {
                        Console.Write("Write first int value : ");
                        var firstvalue = Console.ReadLine();

                        if (firstvalue == "q")
                        {
                            string message = "Do you want to close program? (Y/N)";

                            Console.Write(message);
                            Console.ReadLine();

                            if (Console.ReadLine() == "Y")
                            {
                                Console.Write("Bye");
                                System.Environment.Exit(0);
                            }
                            else
                            {
                                Console.Write("Write first int value : ");
                                var firstvalue2 = Console.ReadLine();

                                if (firstvalue.GetType() == typeof(int))
                                {
                                    Console.Write("Type of first value is :" + firstvalue.GetType() + "and value is ");
                                }
                                else
                                {
                                    Console.Write("Type of first value is not int. ");
                                }

                            }

                        }


                    }
                    catch (Exception exc)
                    {
                        Console.Write("Error on first int value : " + exc);
                        Console.Write("Please write correct value.");
                    }


                    //Console.Write("Write second int value : ");
                    //Console.ReadLine();
                }


            }

            static void ExitApp()
            {
                string message = "Do you want to close program? (Y/N)";

                Console.Write(message);
                Console.ReadLine();

                if (Console.ReadLine() == "Y")
                {
                    Console.Write("Bye");
                    System.Environment.Exit(0);
                }
                else
                {

                }
            }
        }
    }

