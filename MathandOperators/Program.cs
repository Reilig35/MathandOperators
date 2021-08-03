using System;

namespace MathandOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiply user number by 50
            Console.WriteLine("Please type in a number -");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"{num1} X 50 =  {num1 * 50}");

            //Adding 25 to user input
            Console.WriteLine("Please type in a number -");
            byte num2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"{num2} + 25 = {num2 + 25}");
           
            //Dividing user input by 12.5
            Console.WriteLine("Please type in a number -");
            string num3A = Console.ReadLine();
            float num3B = float.Parse(num3A);
            float num3C = num3B / 12.5f;
            Console.WriteLine($"{num3A} divided by 12.5 = " + num3C);
            
            //Checking if user input is greater than 50 with a boolean result
            Console.WriteLine("Please type in a number -");
            byte num4 = Convert.ToByte(Console.ReadLine());
            if (num4 > 50)
            {
                Console.WriteLine($"Is {num4} greater than 50- " + true);
            }
            else 
            {
                Console.WriteLine($"Is {num4} greater than 50- " + false);
            }

            //Finding the remainder of the user input
            Console.WriteLine("Please type in a number -");
            byte num5A = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"After {num5A} has been diveded by 7\nYou get a remainder of- {num5A % 7}");
        }
    }
}
