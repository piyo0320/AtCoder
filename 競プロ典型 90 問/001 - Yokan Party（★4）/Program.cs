using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        var inputs = Console.ReadLine().Split(" ").Select(r => long.Parse(r)).ToList();
        var N = inputs[0];
        var L = inputs[1];

        var K = long.Parse(Console.ReadLine());

        var A = Console.ReadLine().Split(" ").Select(r => long.Parse(r)).ToList();

        var right = L;
        var left = 0L;
        var score = 0L;

        // 2分探索
        while (left <= right)
        {
            // 候補の真ん中の値を使う
            var mid = (left + right) / 2;

            var length = A[0];

            var cutIndex = -1;
            var splitedCount = 1;
            var lastLength = L;

            for (int i = 0; i < N; i++)
            {
                length = A[i];

                if (cutIndex != -1)
                {
                    length -= A[cutIndex];
                }

                if (length >= mid)
                {
                    splitedCount++;
                    cutIndex = i;
                    lastLength = L - A[cutIndex];

                    if (splitedCount == K + 1)
                    {
                        break;
                    }
                }
            }

            if (splitedCount == K + 1 && lastLength >= mid)
            {
                // OK
                left = mid + 1;
                score = length;
            }
            else
            {
                right = mid - 1;
            }

            score = Math.Min(score, mid);
        }

        Console.WriteLine(score);
        return;
    }
}

