using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var N = int.Parse(input);

        if (N > 41)
        {
            N++;
        }

        Console.WriteLine($"AGC{N.ToString("000")}");
        return;
    }
}

