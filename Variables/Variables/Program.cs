/**
 * Udemy course
 * 
 * C# Basics for Beginners: Learn C# Fundamentals by Coding
 * Section 3: Primitive Types and Expressions
 * 18. Demo: Variables and Constants
 * Project: Variables
 * 
 * Author: Teemu Sipiläinen
 * Date: 25 Aug, 2025
 */

using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Teemu";
            bool isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            var number1 = 2;
            var count1 = 10;
            var totalPrice1 = 20.95f;
            var character1 = 'A';
            var firstName1 = "Teemu";
            var isWorking1 = true;

            Console.WriteLine(number1);
            Console.WriteLine(count1);
            Console.WriteLine(totalPrice1);
            Console.WriteLine(character1);
            Console.WriteLine(firstName1);
            Console.WriteLine(isWorking1);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;

            Console.WriteLine(Pi);
        }
    }
}
