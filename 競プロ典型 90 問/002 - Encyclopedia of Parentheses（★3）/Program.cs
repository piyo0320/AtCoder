using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var N = int.Parse(input);

        for (int i = 0; i < (1 << N); i++)
        {
            var str = "";

            for(int j = N - 1; j >= 0; j--)
            {
                // i の j ビット目が 0 か？
                if ((i & (1 << j)) == 0)
                {
                    // 辞書順で早いほうを 0 に対応させる
                    str += "(";
                }
                else
                {
                    str += ")";
                }                  
            }

            // 判定
            var degree = 0;
            foreach (var ch in str)
            {
                if (ch == '(')
                {
                    degree++;
                }
                else
                {
                    degree--;
                }

                if (degree < 0)
                {
                    // 不正
                    break;
                }
            }

            if (degree == 0)
            {
                Console.WriteLine(str);
            }
        }

        return;
    }
}

