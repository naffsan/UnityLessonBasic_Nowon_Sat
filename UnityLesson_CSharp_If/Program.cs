using System;

namespace UnityLesson_CSharp_If
{
    internal class Program
    {
        static bool condition1 = true;
        static bool condition2;
        static bool condition3;
        static void Main(string[] args)
        {
            

            if (condition1)
            {
                /*조건이 참일 때 실행할 내용*/
                Console.WriteLine("조건 1이 참이다");
            }
            else if (condition2)
            {
                //조건1이 거짓이고 조건2가 참일 때 실행할 내용
                Console.WriteLine("조건 1이 거짓이고 조건 2가 참이다");
            }
            else if (condition3)
            {
                //조건1, 2가 거짓이고 조건3이 참일 때 실행할 내용
                Console.WriteLine("조건 1, 2가 거짓이고 조건 3이 참이다");
            }
            else
            {
                //else위 >>모든<< 조건이 거짓일 때 실행할 내용
                Console.WriteLine("조건 1, 2, 3 모두 거짓이다");
            }
            
           
        }
    }
}
