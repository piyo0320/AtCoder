using System;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Count(r => r == '1');

        Console.WriteLine(input);
    }
}

