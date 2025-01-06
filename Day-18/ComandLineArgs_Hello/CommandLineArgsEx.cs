class CommandLineArgsEx
{
    static void Main(string[] userNames)
    {
        Console.WriteLine($"The Size of User Names {userNames.Length}");
        //for Loop

        for (int i = 0; i < userNames.Length; i++)
        {
            Console.WriteLine("User Names : " + userNames[i]);
        }
        //for each loop
        foreach (string userName in userNames)
        {
            Console.WriteLine("User Names in for each loop : :" + userName);
        }

    }
}