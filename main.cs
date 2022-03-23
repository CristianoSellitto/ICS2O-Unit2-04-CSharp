// Cristiano
// ICS2O-Unit2-04-CSharp
// March 23 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        int length;
        int width;
        Console.WriteLine("Enter length of rectangle:");
        length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter width of rectangle:");
        width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your rectangle's perimeter is " + ((length * 2) + (width * 2)) + "cm");
        Console.WriteLine("Your rectangle's area is " + (length * width) + "cm²");
        Console.WriteLine("\nFinished.");
    }
}
