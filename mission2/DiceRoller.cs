namespace mission2;

public static class DiceRoller
{
    public static int[] SimulateRolls(int numberOfRolls)
    {
        // Array to store counts of sums (2-12)
        int[] rollCounts = new int[13]; // Index 0 and 1 are unused

        Random random = new Random();

        for (int i = 0; i < numberOfRolls; i++)
        {
            int die1 = random.Next(1, 7); // Roll first die (1-6)
            int die2 = random.Next(1, 7); // Roll second die (1-6)
            int sum = die1 + die2;       // Sum of the two dice

            rollCounts[sum]++;
        }

        return rollCounts;
    }
}