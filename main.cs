// Cristiano
// ICS2O-Unit2-04-CSharp
// March 23 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        int basetriangle;
        int heighttriangle;
        Console.WriteLine("The area formula for a triangle is: A = b × h ÷ 2");
        Console.WriteLine("Enter the base of your triangle:");
        basetriangle = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the width of your triangle:");
        heighttriangle = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your triangle's area is " + (basetriangle * heighttriangle / 2) + "cm²");
        Console.WriteLine("\nFinished.");
    }
}
