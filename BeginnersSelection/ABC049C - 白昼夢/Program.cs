using System;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        input = input.Replace("eraser", "");
        input = input.Replace("erase", "");
        input = input.Replace("dreamer", "");
        input = input.Replace("dream", "");
        var output =  (string.IsNullOrEmpty(input)) ? "YES" : "NO";

        Console.WriteLine(output);
    }
}

