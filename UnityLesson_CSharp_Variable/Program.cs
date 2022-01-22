using System;

namespace UnityLesson_CSharp_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Person
    {
        //변수 선언 형태: int는 타입 또는 자료형, age는 변수명(대소문자 구분 함)
        /*Person 클래스를 구성하는 변수들, 멤버 변수라고 함(필드)*/
        int age;//정수형 나이, int 하나에 4바이트/범위는 -2147483648~2147483647
        float height;//실수형 키, 하나에 4바이트짜리 실수
        bool isResting;//논리형 쉬고있는가? 1바이트 논리-참 거짓은 1비트만으로 판별 가능하나
                       //cpu 데이터처리 최소단위가 1바이트이므로
                       //그 이하단위로 처리 불가능, 모든 비트가 0일때만 거짓
        char genderChar;//문자형 성별 문자, 2바이트 문자
        string name;//문자열형 이름, 문자개수*2바이트 문자열

        /*bit=한자리 이진수(0, 1/정보처리의 최소단위)
         byte=8bit(cpu의 데이터처리 최소단위)
        4byte=4*8bit= 32bit
        4바이트가 표현가능한 범위는 2^(bit수)
        */
    }
}
