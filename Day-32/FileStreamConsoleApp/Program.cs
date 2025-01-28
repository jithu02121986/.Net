using System;
using System.IO;

Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("Enter your email: ");
string email = Console.ReadLine();


string filePath = "C:\\RRD_Training\\.Net\\Day-32\\user_data.txt";

try
{

    using (StreamWriter writer = new StreamWriter(filePath, true))
    {
        writer.WriteLine($"Name: {name}");
        writer.WriteLine($"Email: {email}");
        writer.WriteLine();
    }

    Console.WriteLine("User Data Saved in file...Please check!");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

