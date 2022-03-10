class MainClass
{
    static void Main()
    {
        Console.Write("Do we have power? (y/n)");
        bool hasPower = Console.ReadLine().ToLower() == "y";

        Console.Write("Do we have paper? (y/n)");
        bool hasPaper = Console.ReadLine().ToLower() == "y";


        int inkLevel = PromptUserForNum("What is the ink level?");   

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
    
    private static string PromptUser(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }
    private static int PromptUserForNum(string message)
    {
        bool isValid = false;
        int numb;
        do
        {
           
            string input = PromptUser(message);

            if (int.TryParse(input, out numb))
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("That is not a valid number, try again!");
            }
        } while (!isValid);
        return numb;
    }
}
