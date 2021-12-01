using System;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        var inputs = Console.ReadLine().Split(' ').Select(r => long.Parse(r)).ToList();

        var N = inputs[0];
        var Y = inputs[1];
        var lie = true;

        var output = "-1 -1 -1";

        for (int i = 0; i < N + 1; i++)
        {
            // zを固定する
            var phase2Y = Y - 10000L * i;
            var phase2N = N - i;

            for (int j = 0; j < phase2N + 1; j++)
            {
                // 計算する
                var x = phase2N - j;
                var sum = 5000L * j + 1000 * x;
                
                if (phase2Y == sum)
                {
                    lie = false;
                    output = $"{i} {j} {x}";
                    break;
                }
            }

            if (!lie)
            {
                break;
            }

        }

        Console.WriteLine(output);
    }
}

