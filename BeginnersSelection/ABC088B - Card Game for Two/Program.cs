using System;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        var inputN = int.Parse(Console.ReadLine());
        var inputs = Console.ReadLine().Split(' ').Select(r => int.Parse(r)).ToList();

        var output = 0;

        inputs.Sort((x,y) =>
        {
            return y.CompareTo(x);
        });

        bool aliceTurn = true;

        foreach (var item in inputs)
        {
            if (aliceTurn)
            {
                output += item;
            }
            else
            {
                output -= item;
            }

            aliceTurn = !aliceTurn;
        }

        Console.WriteLine(output);
    }
}

