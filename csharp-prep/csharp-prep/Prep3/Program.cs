using System;

class Program
{
    static void Main(string[] args)
    {
        /* Number one
        // Asking the magic number
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        // Asking the guess
        Console.Write("What is your guess ");
        int guess = -1;
        guess = int.Parse(Console.ReadLine());
        // conditional
        if (guess < magicNumber)
        {
            Console.WriteLine ("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it");
        }*/
        /* Number two
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("You guessed it!");
            }*/

        
            /* Number three
                Instead of having the user supply the magic number,
                generate a random number from 1 to 100.
                Play the game and make sure it works!*/

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        int guess = -1;
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
        
            
            
                
            
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("You guessed it!");

            }
        }
    }   

}  
        
        
