namespace CastTheDiceAssignment1;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Cast the Dice! If the sum results in 12, you win!");

        while (true)
        {
            Console.WriteLine("Casting dice...");
            var rand = new Random();

            int dice1 = rand.Next(1, 7);
            int dice2 = rand.Next(1, 7);

            Console.WriteLine($"The dices rolled {dice1} and {dice2} ");

            int result = dice1 + dice2;

            Console.WriteLine($"The sum is {result}");

            if (result == 12)
            {
                Console.WriteLine("Grattis 🥳 du har vunnit!");
                break;
            }
            else
            {
                Console.WriteLine("You lost, want to play again? (type y if yes)");

                var response = Console.ReadLine();

                if (response == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Exiting game");
                    Environment.Exit(0);
                }
            }
        }
    }
}
