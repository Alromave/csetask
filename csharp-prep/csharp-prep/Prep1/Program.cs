using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");

        string grade = Console.ReadLine();
        int percent = int.Parse(grade);
        int digit = percent % 10;



        string letter = "";
        string sign = "";
        if (digit >= 7)
        {
            sign = "+";
        }
        else if (digit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter} {sign}");

        if (percent >= 70)
        {
            Console.WriteLine("you passed!");
        }
        else
        {
            Console.WriteLine("Better Luck next time!");
        }
    }
}