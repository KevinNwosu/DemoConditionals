class MainClass
{
    static void Main()
    {
        int startNum, targNum, range;

        Console.Write("Enter an initial number: ");
        startNum = int.Parse(Console.ReadLine());

        Console.Write("Enter a target number: ");
        targNum = int.Parse(Console.ReadLine());

        Console.Write("Enter a range number: ");
        range = int.Parse(Console.ReadLine());

        string results = IsWithinRange(startNum, targNum, range) ? "within range" : "not within range";

        Console.WriteLine($"Given a starting number of {startNum} and a target number of {targNum}. It is {results}.");
    }
    private static bool IsWithinRange(int num, int target, int range)
    {
        return ((num - target) <= range) && ((target - num) >= range);
    }
    
}
