namespace MainMenu;
// define a class named "Program"
class Program
{
    static void Main(string[] args)
    {
        // using while loop to display the menu and handle user's input
        while (true)
        {
            // Clear the console screen
            Console.Clear();
            Console.WriteLine("Hi, Welcome! You have come to the Main Menu!\n");
            // Display menu options
            Console.WriteLine("1. Check Price");
            Console.WriteLine("2. Buy Tickets");
            Console.WriteLine("3. Repeat Review");
            Console.WriteLine("4. The Third Word");
            Console.WriteLine("0. Exit");

            Console.WriteLine("Enter your choice: ");
            // Try to parse user's input into an integer
            if (int.TryParse(Console.ReadLine(), out int choice))
            {  // Switch statement to determine the action based on user's choice
                switch (choice)
                {
                    case 0:
                        return;// Exit the loop and terminate the program
                    case 1:
                        CheckPrice();// Call the CheckPrice() method
                        break;
                    case 2:
                        BuyTickets();// Call the BuyTickets() method
                        break;
                    case 3:
                        MovieReview();// Call the MovieReview() method
                        break;
                    case 4:
                        ThirdWord();// Call the ThirdWord() method
                        break;

                    default:
                        Console.WriteLine("Wrong input, please try again!\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadKey();
        }
    }
    // Method to check the ticket price based on user's age
    static void CheckPrice()
    {
        Console.WriteLine("How old are you? ");

        if (int.TryParse(Console.ReadLine(), out int age))
        {
            if (age < 5)
                Console.WriteLine("Free entrance!");
            else if (age < 20)
                Console.WriteLine("Price for a minor: 80kr");
            else if (age > 64)
            {
                if (age > 100)
                    Console.WriteLine("Free entrance!");
                else
                    Console.WriteLine("Pensioners price: 90kr");
            }
            else
            {
                Console.WriteLine("standard price: 120kr");
            }
        }
    }
    // Method to buy tickets based on different age group
    static void BuyTickets()
    {
        Console.WriteLine("Choose your tickets group:\n");
        Console.WriteLine("1. minor price: 80");
        Console.WriteLine("2. pensioner price: 90");
        Console.WriteLine("3. standard price: 120");

        if (int.TryParse(Console.ReadLine(), out int tickets))
        {
            Console.WriteLine("How many tickets do you want to buy?");

            if (int.TryParse(Console.ReadLine(), out int quantity))
            {
                int price;
                switch (tickets)
                {
                    case 1:
                        price = 80;
                        break;
                    case 2:
                        price = 90;
                        break;
                    case 3:
                        price = 120;
                        break;
                    default:
                        price = 0;
                        break;
                }
                Console.WriteLine($"Total tickets: {quantity}, total amount: {quantity * price}");
            }
            else
            {
                Console.WriteLine("Invalid quantity. Please enter a number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
        }

    }
    // Method to catch user input and repeat 10 times
    static void MovieReview()
    {
        Console.WriteLine("How do you like the movie?");

        string? reviewInput = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(reviewInput))
        {
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine($"{i}. {reviewInput}");

            }
        }
    }
    // Method to extract and display the third word from a sentence
    static void ThirdWord()
    {
        Console.WriteLine("Enter a sentence:");
        string? sentence = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(sentence))
        {
            string[] words = sentence.Split(' ');

            if (words.Length >= 3)
            {
                Console.WriteLine(words[2]);
            }
            else
            {
                Console.WriteLine("The sentence does not have three words.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a sentence.");
        }

    }
}


