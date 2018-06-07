using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciDelegate
{
    public delegate int NotificationHandler(int fibanocci);
    class Program
    {
        static void Main(string[] args)
        {
            NotificationHandler FibnociDelegate = new NotificationHandler(Fibonacci);
            int number;
            Console.WriteLine("Give the length of the sequence");
            number = int.Parse(Console.ReadLine());
            for (int iterator = 0; iterator < number; iterator++)
            {
                Console.Write(" " + FibnociDelegate(iterator));
                Console.WriteLine(" " + (iterator * 100) / (number) + "%\n");
                //Console.Write(" " + Fibonacci.Fib(i));
                // Console.Write(" " + (i * 100) / (number) + "%\n");
            }
            Console.ReadKey();
        }
        public static int Fibonacci(int number)
        {
            if (number == 0 || number == 1)
                return number;
            else
                return (Fibonacci(number - 1) + Fibonacci(number - 2));
        }
    }
}
