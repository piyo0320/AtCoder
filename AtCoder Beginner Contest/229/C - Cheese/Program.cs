using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" ");
        var N = int.Parse(input[0]);
        var W = int.Parse(input[1]);

        var arr = new List<(long, long)>();

        for (int i = 0; i < N ; i++)
        {
            var temp = Console.ReadLine().Split(" ");

            arr.Add((int.Parse(temp[0]), int.Parse(temp[1])));
        }

        long canWeight = W;
        long oishisa = 0;

        var sorted = arr.OrderByDescending(x => x.Item1).ToList();

        for (int j = 0; j < N ;j++)
        {
            if (canWeight > sorted[j].Item2)
            {
                oishisa += sorted[j].Item1 * sorted[j].Item2;
                canWeight -= sorted[j].Item2;
            }
            else
            {
                oishisa += sorted[j].Item1 * canWeight;
                Console.WriteLine(oishisa);
                return;
            }
        }

        Console.WriteLine(oishisa);
        return;
    }
}

