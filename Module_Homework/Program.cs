using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Module_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //1HW
            //ReturnValueSum();

            //2HW
            // ReturnOddEven();

            //3HW
            GetMobile();

            //4HW
            //GetWordCheck();



           static void ReturnValueSum()
            {
                int[] array = { 3, 7, 10, 21, 32, 43, 74 };
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                Console.WriteLine($"The sum of elements is { sum}");
                Console.ReadLine();
            }

            static void ReturnOddEven()
            {
                int[] array = { 3, 7, 10, 21, 32, 43, 74 };
                
                
               for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0 && i != 0)
                        {
                            Console.WriteLine($"{array[i]} is even number");
                        }

                        else
                        {
                            Console.WriteLine($"{array[i]} is odd number");
                        }
                    }
                Console.ReadLine();
                

            }

            static void ReturnPopulateArray()
            {
                int[] Array = { 1, 6, 35, 541, 54, 95 };
                
                for (int i = 0; i < Array.Length; i++)
                {
                    for (int j = i+ 1; j < Array.Length; j++)
                    {
                        if (Array[i] == Array[j])
                        {
                         Console.WriteLine(Array[i]);
                        }
                    }
                }
                Console.ReadLine();

            }

            static void GetMobile ()
            {
                string input;
                do
                {
                    Console.WriteLine("Please input number: ");
                    input = Console.ReadLine();
                    int.TryParse(input, out int result);
                    string pattern2 = @"^(\+\d{2}-\d{3}-\d{3}-\d{3})";
                    Regex regex = new Regex(pattern2);
                    Match output = regex.Match(input);
                    
                    if (output.Success)
                    {
                        Console.WriteLine("Valid number");
                    }
                    else
                    {
                        Console.WriteLine("Invalid number. Do you want to continue?");
                    }
                }
                while (Console.ReadLine() != "exit");
                Console.ReadLine();


            }

            static void GetWordCheck()
            {
                do
                {
                    Console.WriteLine("Enter text:\n");
                    string input = Console.ReadLine();
                    string pattern = @"^(\b[A-Z]\w*\s*)+$"; 
                    Regex regex = new Regex(pattern);
                    Match output = regex.Match(input);
                                   
                    string result = output.Success ? "True" : "False. Continue?\nYes=Enter\nNo";
                    Console.WriteLine(result);
                    
                }
                while (Console.ReadLine() != "No");
                    Console.ReadLine();
            }
        }
    }
}
