using System;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        var inputN = int.Parse(Console.ReadLine());
        var mochis = new int[inputN];

        for (int i = 0; i < inputN; i++)
        {
            mochis[i] = int.Parse(Console.ReadLine());
        }

        var output = mochis.Distinct().Count();

        Console.WriteLine(output);
    }
}

