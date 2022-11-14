using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////計算1+(2+2)*3-1
            int result = 1 + (2 + 2) * 3 - 1;
            Console.WriteLine(result);

            //120/7的商以及餘數是多少
            int A = 120;
            int B = 7;
            int result1 = A / B;
            int result2 = A % B;
            Console.WriteLine(result1);
            Console.WriteLine(result2);


            {//判斷9,202各數為奇偶數?
                int result3 = 9 % 2;
                int result4 = 202 % 2;

                Console.WriteLine(result3);
                Console.WriteLine(result4);
            }

        }
    }
} 