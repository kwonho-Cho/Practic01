using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace LearnCS5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Person man = new Person();
                ////man._Name = "김철수";
                ////man._IsSex = true;
                //man.InitData("김철수", true);
                //man.Laugh();

                //Person girl = new Person();
                ////girl._Name = "이영희";
                ////girl._IsSex = false;
                //girl.InitData("이영희",false);
                //girl.Laugh();

                //Console.WriteLine("{0} 와 {1}는 함께 소풍을 갔습니다", man.GetName(), girl.GetName());
            }

            //클래스에는 기본생성자가 내재되어있다. 다만, 프로그래머가 생성자를 설정할 경우가 우선되며 그에따라 내재되는 기본생성자는 무시된다
            Person man = null;
            Console.WriteLine("누가 먼저인가?");
            man = new Person("홍길동", true);
            man.ShowInfo();

        }
    }
}
