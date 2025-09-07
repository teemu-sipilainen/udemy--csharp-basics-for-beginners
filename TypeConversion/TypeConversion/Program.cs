/**
 * Udemy course
 * 
 * C# Basics for Beginners: Learn C# Fundamentals by Coding
 * Section 3: Primitive Types and Expressions
 * 20. Type Conversion
 * Project: Type Conversion
 * 
 * Author: Teemu Sipiläinen
 * Date: 7 Sep, 2025
 */

using System;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit type conversion
            byte b1 = 1;
            int i1 = b1;
            Console.WriteLine(i1); // Prints 1

            // Explicit type conversion
            int i2 = 1;
            byte b2 = (byte) i2; // Value is small enough to fit in a byte
            Console.WriteLine(b2); // Prints 1

            int i3 = 1000;
            byte b3 = (byte)i3; // Some of the bits are lost
            Console.WriteLine(b3); // Prints 232

            String number4 = "1234";
            int i4 = Convert.ToInt32(number4);
            Console.WriteLine(i4);

            try
            {
                // String number5 = "1";
                String number5 = "1234";
                byte b5 = Convert.ToByte(number5); // Causes: An unhandled exception of type 'System.OverflowException' occurred in mscorlib.dll
                Console.WriteLine(b5);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            try
            {
                string str6 = "true";
                bool b6 = Convert.ToBoolean(str6);
                Console.WriteLine(b6);
            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted to a boolean.");
            }
        }
    }
}
