using System;

namespace RigaSchool.iu
{
    class RigaSchool1iu
    {
        static void Main(string[] args)
        {
            {
                #region Homework1
            Console.WriteLine("Hello World!");
            Console.Write("My name is Vineta."); Console.Write("I am 37 years old.\nMy weight is 50 kg.\nMy height is 1.72 m.");
            Console.WriteLine("I enjoy reading and pondering God's Word on a daily basis."); Console.Write("I like music.");
            Console.WriteLine("Worship Songs are special to me.");
            Console.WriteLine("I like to learn something new and challenging.");
            Console.WriteLine("I want to try kockboxing\nI like to play basketball with my son.\n");
                #endregion
            }

            {
                #region Homework2

                string stringVariable = "Name";
                string stringVariable1 = "Vineta";

                Console.WriteLine($"{stringVariable}:{stringVariable1}");

                string stringVariable2 = "Age";
                int integralVariable = 37;

                Console.WriteLine($"{stringVariable2}:{integralVariable}");

                string stringVariable3 = "Height";
                decimal decimalVariable = 1.72m;
                string charVariable = "m";


                Console.WriteLine($"{stringVariable3}:{decimalVariable} {charVariable}");

                string stringVariable4 = "Weight";
                int integralVariable1 = 50;
                string charVariable1 = "KG";

                Console.WriteLine($"{stringVariable4}:{integralVariable1} {charVariable1}");

                int intVariable = (int)decimalVariable;
                Console.WriteLine($"Decimal casting:{intVariable}\n");

                #endregion
            }

            #region Homework3

            decimal number1 = 1.2m;
            double number2 = 15.5d;
            short number3 = -3333;
            int number4 = 888;
            long number5 = -1345;

            Console.WriteLine($"Absolute value of decimal:\n({number1}) = {Math.Abs(number1)}\n");
            Console.WriteLine($"Absolute value of double:\n({number2}) = {Math.Abs(number2)}\n");
            Console.WriteLine($"Absolute value of short:\n({number3}) = {Math.Abs(number3)}\n");
            Console.WriteLine($"Absolute value of int:\n({number4}) = {Math.Abs(number4)}\n");
            Console.WriteLine($"Absolute value of long:\n({number5}) = {Math.Abs(number5)}");

            #endregion

            {
                #region Homework4-a

                int monthnumber;
                Console.WriteLine("Enter month number (1-12):");
                monthnumber = Convert.ToInt32(Console.ReadLine());
                
                switch (monthnumber)
                {
                    case 1: Console.WriteLine("31 days");
                        break;
                    case 2:
                        Console.WriteLine("28 or 29 days");
                        break;
                    case 3:
                        Console.WriteLine("31 days");
                        break;
                    case 4:
                        Console.WriteLine("30 days");
                        break;
                    case 5:
                        Console.WriteLine("31 days");
                        break;
                    case 6:
                        Console.WriteLine("30 days");
                        break;
                    case 7:
                        Console.WriteLine("31 days");
                        break;
                    case 8:
                        Console.WriteLine("31 days");
                        break;
                    case 9:
                        Console.WriteLine("30 days");
                        break;
                    case 10:
                        Console.WriteLine("31 days");
                        break;
                    case 11:
                        Console.WriteLine("30 days");
                        break;
                    case 12:
                        Console.WriteLine("31 days");
                        break;
                    default:
                        Console.WriteLine("Invalid input!!!Enter month number between 1-12");
                        break;
                }
                #endregion

                #region Homowork4-b

                //int number 1_= 31;
                //int number 2_= 28 or 29;
                //int number 3_= 31;
                //int number 4_= 30;
                //int number 5_= 31;
                //int number 6_= 30;
                //int number 7_= 31;
                //int number 8_= 31;
                //int number 9_= 30;
                //int number 10_= 31;
                //int number 11_= 30;
                //int number 12_= 31;

                Console.ReadLine();
                #endregion
            }


        
        }
    }
}
