using mission2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");
        
        // Read and validate user input
        if (!int.TryParse(Console.ReadLine(), out int numberOfRolls) || numberOfRolls <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer.");
            return;
        }

        // Call DiceRoller to simulate rolls
        int[] rollResults = DiceRoller.SimulateRolls(numberOfRolls);

        // Display results
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numberOfRolls}.\n");

        for (int i = 2; i <= 12; i++)
        {
            int rollCount = rollResults[i];
            double percentage = (rollCount / (double)numberOfRolls) * 100;
            string histogram = new string('*', (int)Math.Round(percentage));

            Console.WriteLine($"{i}: {histogram}");
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}