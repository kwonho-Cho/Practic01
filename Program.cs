using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*구구단 (2~9)
             * 1.전체
             * 2.짝수
             * 3.홀수 
             * 몇번?
             * 3개 출력 후 다음줄
             */

            Console.Write("구구단 몇 단을 출력하시겠습니까? : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("1.전체\n2.짝수\n3.홀수\n번호를 선택해주세요 : ");
            int num2 = int.Parse(Console.ReadLine());

            if (num2 == 1)
            {
                for(int i = 1; i<=9; i++)
                {
                    Console.Write($"{num1} * {i} = {num1*i}  ");
                    if (i % 3 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            else if (num2 == 2)
            {
                for(int i = 2; i<=9; i+=2)
                {
                    Console.Write($"{num1} * {i} = {num1 * i}  ");
                    if (i % 3 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            else if(num2 == 3)
            {
                for (int i = 1; i <= 9; i+=2)
                {
                    Console.Write($"{num1} * {i} = {num1 * i}  ");
                    if (i % 5 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
