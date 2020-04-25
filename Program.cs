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
            /* 1.강아지 => (귀엽다 출력)
             * 2.엄마 => (도망가자! 출력)
             * 3.모르는 아저씨 => (무시한다 출력)
             * 4.종료
             * 
             * 10번 반복 질문 후 자동종료
             * while문 이용
             *
             */
            int num = 0;
            while(num++ < 10)
            {
                Console.Write("1. 강아지\n2. 엄마\n3. 모르는 아저씨\n4. 종료\n 번호를 입력해주세요 : ");
                int inputNum = int.Parse(Console.ReadLine());

                switch (inputNum)
                {
                    case 1:
                        Console.WriteLine("\n귀엽다!\n");
                        break;
                    case 2:
                        Console.WriteLine("\n도망가자!\n");
                        break;
                    case 3:
                        Console.WriteLine("\n(무시하자)\n");
                        break;
                    case 4:
                        num += 10;
                        break;
                    default:
                        Console.WriteLine("\n내용을 잘못 입력하셨습니다\n");
                        break;
                }
            }
            Console.WriteLine("\n시스템을 종료합니다\n");
        }
    }
}
