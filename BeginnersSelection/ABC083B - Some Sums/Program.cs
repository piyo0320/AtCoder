using System;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        var inputs = Console.ReadLine().Split(' ').Select(r => int.Parse(r)).ToList();

        var inputN = inputs[0];
        var inputA = inputs[1];
        var inputB = inputs[2];

        var output = 0;

        for (int i = 1; i < inputN + 1; i++)
        {
            var sum = (i.ToString().ToCharArray()).Select(r => int.Parse(r.ToString())).Sum();
            if ((sum < inputA) || (sum > inputB))
            {
                continue;
            }

            output += i;
        }

        Console.WriteLine(output);
    }
}

