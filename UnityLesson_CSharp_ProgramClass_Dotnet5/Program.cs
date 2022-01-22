//파란색: 키워드(예약어)-우리가 임의로 가져다 바꿀 수 없는 것, 기능이 정해짐
//using: 키워드, 무언가를 사용하겠다는 의미
//1. 미리 짜여진 코드 덩어리(대부분은 이거)
//system: 미리 짜여진 코드 덩어리
//2. 우선순위 차순위인 함수를 일반적으로 호출할 때

using System;
/*namespace키워드: 클래스간 이름 충돌을 방지하면서 코드를 한 공간으로 묶는 기능, 이거 바꿔도 됨
 단 using에 명시 안하면 못씀*/
namespace UnityLesson_CSharp_ProgramClass_Dotnet5
{
    /*Main함수가 Program클래스 안에 들어있는 이유는 객체지향 프로그래밍 컨셉을 지키기 위함*/
    internal class Program
    {
        /*exe 실행파일 실행했을 때 제일 먼저 호출되는 함수가 이 아래쪽 main함수*/

        /*static-dynamic(정적-동적)
         소프트웨어에서 정적: 메모리에 할당 x(객체화 불가능)
        동적: 할당 ㅇ(객체화 가능)
           static이라고 정의되면 유일무이한 개념이 됨-main함수는 하나밖에 존재할 수 없다

       void: 아무것도 없음, 함수에서는 반환형이 없다는 의미
        :주로 입력만 필요하고 값 반환이 필요없을 때 씀(예: 캐릭터 이동하는데 값 반환 필요없음)
        */
        static void Main(string[] args)
        {
            /*"콘솔 창에서 이 문장을 써라" 라는 의미*/
            Console.WriteLine("Hello World!");
        }
    }
}
