using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Output 1 - 255");
            for(int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Output 1 - 100");
            for(int i = 1; i < 101; i++)
            {
                if((i % 3 == 0 || i % 5 == 0) && !(i % 3 == 0 && i % 5 == 0))
                Console.WriteLine(i);
            }
            Console.WriteLine("Output 'Fizz', 'Buzz' or 'FizzBuzz'");
            for(int i = 1; i < 101; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " FizzBuzz" );
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine(i + " Fizz" );
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine(i + " Buzz" );
                }
            }
        }
    }
}
