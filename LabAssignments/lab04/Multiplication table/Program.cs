using System;
namespace MultiplicationTable
{
  class Program
 {
    static void Main()
    {
        Console.Write("\nPlease enter an integer number in the range of 1 – 20: ");
        var input = Console.ReadLine();

        int number = Int32.Parse(input);
        int product = 0;
        if(number < 20 && number > 0)
        {
            Console.WriteLine("\nMultiplication table for number {0}:", number);
            for(var i = 1; i <= 10; i++)
            {
                product = number * i;
                Console.WriteLine("{0} * {1} = {2}", i, number, product);
            }
        }
        else 
        {
        return;
        }
    }
  }
}
