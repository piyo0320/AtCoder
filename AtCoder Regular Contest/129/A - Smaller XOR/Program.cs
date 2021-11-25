using System;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        //var inputN = int.Parse(Console.ReadLine());
        var inputs = Console.ReadLine().Split(' ').Select(r => long.Parse(r)).ToList();

        var inputN = inputs[0];
        var inputL = inputs[1];
        var inputR = inputs[2];

        var NStr = Convert.ToString(inputN, toBase: 2).ToCharArray();
        var digit = NStr.Length;

        long output = 0;

        for (int i = 0; i < digit; i++)
        {
            if (NStr[(digit - i - 1)] == '0')
            {
                continue;
            }

            if (inputL > Math.Pow(2, i + 1) - 1)
            {
                // 全部条件満たさないので次に行く
                continue;
            }

            if (inputR < Math.Pow(2, i))
            {
                // これ以降は全部条件満たさないのでやる意味なし
                break;
            }

            // 2^i ～ 2^{i+1}-1 の 2^iコの数値が候補
            // 候補の範囲にLがあればそこから
            var start = Math.Max((long)Math.Pow(2, i), inputL);

            // 候補の範囲にRがあればそこまで
            var end = Math.Min((long)Math.Pow(2, i + 1) - 1, inputR);

            output += end - start + 1;
        }

        Console.WriteLine(output);
    }
}

