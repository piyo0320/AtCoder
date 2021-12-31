using System;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" ");
        var A = input[0].ToCharArray();
        var B = input[1].ToCharArray();

        var aLength = A.Length;
        var bLength = B.Length;

        for (int i = 0; i < Math.Min(aLength, bLength); i++)
        {
            var tempA = int.Parse(A[aLength - i - 1].ToString());
            var tempB = int.Parse(B[bLength - i - 1].ToString());

            if (tempA + tempB > 9)
            {
                Console.WriteLine("Hard");
                return;
            }
        }

        Console.WriteLine("Easy");
        return;
    }
}

