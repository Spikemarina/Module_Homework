using System;

namespace Module_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //1HW
            returnValueSum();

            //2HW
            returnOddEven();
            

            


            static void returnValueSum()
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

            static void returnOddEven()
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
        }
    }
}
