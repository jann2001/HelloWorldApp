﻿namespace HelloWorldApp
{
    public class Program
    {
        private static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        private static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        private static int Divide(int num1, int num2)
        {
            return num1 * num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int result = Sum(5, 7);
            Console.WriteLine(result);
            int product = Multiply(5, 7);
            Console.WriteLine(product);
            int divide = Divide(15, 5);
            Console.WriteLine(divide);
        }
    }
}