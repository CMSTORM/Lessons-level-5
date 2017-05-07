using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "one";
            string two = "two";
            string three = "three";
            string four = "four";
            string five = "five";
            string six = "six";
            string seven = "seven";
            string eight = "eight";
            string nine = "nine";

            string twenty = "and twenty ";
            string thirty = "and thirty ";
            string fourty = "and fourty ";
            string fifty = "and fifty ";
            string sixty = "and sixty ";
            string seventy = "and seventy ";
            string eighty = "and eighty ";
            string ninety = "and ninety ";

            string oneHundred = "one hundred ";
            string twoHundred = "two hundred ";
            string threeHundred = "three hundred ";
            string fourHundred = "four hundred ";
            string fiveHundred = "five hundred ";
            string sixHundred = "six hundred ";
            string sevenHundred = "seven hundred ";
            string eightHundred = "eight hundred ";
            string nineHundred = "nine hundred ";

            try
            {
                int number = int.Parse(Console.ReadLine());

                //Limiting the range
                if (number >= 0 && number <= 999)
                {
                    //In case it's zero
                    if (number == 0) Console.WriteLine("Zero/Null");


                    //Calculate the hundreds
                    switch (number / 100)
                    {
                        case 1:
                            Console.Write(oneHundred);
                            break;
                        case 2:
                            Console.Write(twoHundred);
                            break;
                        case 3:
                            Console.Write(threeHundred);
                            break;
                        case 4:
                            Console.Write(fourHundred);
                            break;
                        case 5:
                            Console.Write(fiveHundred);
                            break;
                        case 6:
                            Console.Write(sixHundred);
                            break;
                        case 7:
                            Console.Write(sevenHundred);
                            break;
                        case 8:
                            Console.Write(eightHundred);
                            break;
                        case 9:
                            Console.Write(nineHundred);
                            break;
                    }

                    //In case it's only 10
                    if (number % 100 == 10) Console.WriteLine("and ten");

                    //We need a new number for the decimals
                    int number1 = number % 100;

                    //This is for the special numbers after 10 and before 20 
                    if (number1 > 10 && number1 < 20)
                    {
                        switch (number1)
                        {
                            case 11:
                                Console.WriteLine(" and eleven");
                                break;
                            case 12:
                                Console.WriteLine("and twelve");
                                break;
                            case 13:
                                Console.WriteLine(" and thirteen");
                                break;
                            case 14:
                                Console.WriteLine("and fourteen");
                                break;
                            case 15:
                                Console.WriteLine(" and fifteen");
                                break;
                            case 16:
                                Console.WriteLine(" and sixteen");
                                break;
                            case 17:
                                Console.WriteLine("and seventeen");
                                break;
                            case 18:
                                Console.WriteLine("and eigthteen");
                                break;
                            case 19:
                                Console.WriteLine("and nineteen");
                                break;
                        }
                    }

                    else
                    {
                        //Calculate the simple decimals
                        switch (number1 / 10)
                        {
                            case 2:
                                Console.Write(twenty);
                                break;
                            case 3:
                                Console.Write(thirty);
                                break;
                            case 4:
                                Console.Write(fourty);
                                break;
                            case 5:
                                Console.Write(fifty);
                                break;
                            case 6:
                                Console.Write(sixty);
                                break;
                            case 7:
                                Console.Write(seventy);
                                break;
                            case 8:
                                Console.Write(eighty);
                                break;
                            case 9:
                                Console.Write(ninety);
                                break;
                        }
                        //calculate the last digits
                        number1 %= 10;
                        switch (number1)
                        {
                            case 1:
                                Console.WriteLine(one);
                                break;
                            case 2:
                                Console.WriteLine(two);
                                break;
                            case 3:
                                Console.WriteLine(three);
                                break;
                            case 4:
                                Console.WriteLine(four);
                                break;
                            case 5:
                                Console.WriteLine(five);
                                break;
                            case 6:
                                Console.WriteLine(six);
                                break;
                            case 7:
                                Console.WriteLine(seven);
                                break;
                            case 8:
                                Console.WriteLine(eight);
                                break;
                            case 9:
                                Console.WriteLine(nine);
                                break;
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("Number Out Of Range");
                }
            }
            catch
            {
                Console.WriteLine("Invalid Number!");
            }

             
           
            Console.ReadLine();
        }
    }
}
