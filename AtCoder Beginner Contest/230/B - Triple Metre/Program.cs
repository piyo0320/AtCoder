using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        var S = Console.ReadLine();

        var T = "";

        for (int i = 0; i < 100; i++)
        {
            T += "oxx";
        }

        var index = T.IndexOf(S);

        if (index == -1)
        {
            Console.WriteLine("No");
            return;
        }

        Console.WriteLine("Yes");
        return;
    }
}

