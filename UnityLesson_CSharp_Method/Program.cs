using System;

namespace UnityLesson_CSharp_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHelloWorld();
            PrintSomething("야옹");//소괄호 안에 들어가는 것은 매개변수(parameter)
            bool tmpIsFinished = false;
            tmpIsFinished = PrintSomethingAndReturnFinished("멍멍왈왈크르렁호로록");
            Console.WriteLine(tmpIsFinished);
        }
        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        static void PrintSomething(string something)//함수 정의에서 소괄호 안 내용은 인자라고 함(argument)

        {
            Console.WriteLine(something);
        }
        /*반환형 함수이름(인자자료형 인자이름, 인자자료형 인자이름...)
        {
            함수 연산 내용
                return 반환할 내용
        }*/
        //인자, 반환 모두 있는 것
        static bool PrintSomethingAndReturnFinished(string something)
        {
           
            bool isFinished = false; //지역변수(이 함수 안에서만 연산을 위해 사용됨)
            Console.WriteLine(something);
            isFinished = true;
            return isFinished;

        }
    }
}
