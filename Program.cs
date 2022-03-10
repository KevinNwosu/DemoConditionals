class MainClass
{
    static void Main()
    {
        Console.Write("Do we have power? (y/n)");
        bool hasPower = Console.ReadLine().ToLower() == "y";

        Console.Write("Do we have paper? (y/n)");
        bool hasPaper = Console.ReadLine().ToLower() == "y";

        Console.Write("What's the ink level in numbers?");
        int inkLevel = int.Parse(Console.ReadLine());   

        PrintDoc(hasPower, hasPaper, inkLevel);
    }
    private static bool IsWithinRange(int num, int target, int range)
    {
        return ((num - target) <= range) && ((target - num) >= range);
    }

    private static void PrintDoc(bool hasPower, bool hasPaper, int inkLevel)
    {
        string result = hasPaper && hasPower && inkLevel >= 10 ? "Printing" : "Unable to print";
        Console.Write(result);
    }
    
}
