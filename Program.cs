using System;

void Main()
{
    Random random = new Random();
    int secretNumber;
    int maxAttempts;

    Console.WriteLine("Welcome to the Guessing Game!");
    Console.WriteLine("I'm thinking of a number between 1 and 100.");

    //Difficulty menu
    Console.WriteLine("Select a difficulty level:");
    Console.WriteLine("1. Easy (8 attempts)");
    Console.WriteLine("2. Medium (6 attempts)");
    Console.WriteLine("3. Hard (4 attempts)");
    Console.WriteLine("4. Cheater (unlimited guesses!)");

    int selectedDifficulty;
    while (!int.TryParse(Console.ReadLine(), out selectedDifficulty) || selectedDifficulty < 1 || selectedDifficulty > 4)
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 3 to select the difficulty level.");
    }

    switch (selectedDifficulty)
    {
        case 1:
            maxAttempts = 8;
            secretNumber = random.Next(1, 101);
            break;
        case 2:
            maxAttempts = 6;
            secretNumber = random.Next(1, 101);
            break;
        case 3:
            maxAttempts = 4;
            secretNumber = random.Next(1, 101);
            break;
        case 4:
            maxAttempts = int.MaxValue; // Allows unlimited attempts
            Console.WriteLine("Cheater mode activated! Enter the correct number to win!");
            secretNumber = -1; // This number is just a placeholder value, not used in Cheater mode ;)
            break;
        default:
            maxAttempts = 8; //Defaults to 'Easy' difficulty
            secretNumber = random.Next(1, 101);
            break;
        
    }

    if (selectedDifficulty != 4)
    {

    for (int attempt = 1; attempt <= maxAttempts; attempt++)
    {
        int attemptsLeft = maxAttempts - attempt + 1;
        Console.WriteLine("Attempt #{0}", attempt); //Let's the user know what attempt they are on
        Console.WriteLine("You have {0} guess(es) left.", attemptsLeft); //Shows user how many guesses they have left
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
        Console.WriteLine("Invalid input. Please enter a valid number."); //Message appears when there is no input present
     }
 }
    Console.WriteLine("Out of attempts. The correct number was: " + secretNumber);
    }
    else
    {
        while (true)
        {
            Console.Write("Take a guess: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int guess))
            {
                Console.WriteLine("You guessed: " + guess);

                if (guess == secretNumber)
                {
                    Console.WriteLine("Congrats! You guessed the correct number!");
                    return; // Exits the program, like above.
                }
                else
                {
                    Console.WriteLine("Sorry, that's not the correct number. Keep trying!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}

Main();