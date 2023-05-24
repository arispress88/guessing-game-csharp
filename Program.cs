using System;

void Main()
{
    int secretNumber = 42;
    int maxAttempts = 4;

    Console.WriteLine("Welcome to the Guessing Game!");
    Console.WriteLine("I'm thinking of a number between 1 and 100.");

    for (int attempt = 1; attempt <= maxAttempts; attempt++)
    {
        Console.WriteLine("Attempt #{0}", attempt);
        Console.Write("Take a guess: ");
        string input = Console.ReadLine();
    

    

    if (int.TryParse(input, out int guess))
    {

        if (guess == secretNumber)
        {
            Console.WriteLine("Congrats! You guessed the correct number!");
            return; //Leaves the program after the correct guess  
        }
        else if (attempt != maxAttempts)
        {
            Console.WriteLine("Sorry, that's not the right number.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
     }
 }
    Console.WriteLine("Out of attempts. The correct number was: " + secretNumber);
}

Main();