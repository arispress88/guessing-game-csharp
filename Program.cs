using System;

void Main()
{
    Random random = new Random();
    int secretNumber = random.Next(1, 101); //Generates a random number between 1-100 to be the secret number
    int maxAttempts = 4;

    Console.WriteLine("Welcome to the Guessing Game!");
    Console.WriteLine("I'm thinking of a number between 1 and 100.");

    for (int attempt = 1; attempt <= maxAttempts; attempt++)
    {
        int attemptsLeft = maxAttempts - attempt + 1;
        Console.WriteLine("Attempt #{0}", attempt);
        Console.WriteLine("You have {0} guess(es) left.", attemptsLeft);
        Console.Write("Take a guess: ");
        string input = Console.ReadLine();
    

    

    if (int.TryParse(input, out int guess))
    {

        if (guess == secretNumber)
        {
            Console.WriteLine("Congrats! You guessed the correct number!");
            return; //Leaves the program after the correct guess  
        }
        else if (guess < secretNumber)
        {
            Console.WriteLine("Sorry, your guess is too low.");
        }
        else if (guess > secretNumber)
        {
            Console.WriteLine("Sorry, your guess is too high.");
        }

        if (attempt != maxAttempts)
        {
            Console.WriteLine("Try again.");
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