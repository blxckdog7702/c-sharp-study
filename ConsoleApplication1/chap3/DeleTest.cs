//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1
//{
//    class DeleTest
//    {
//        public delegate int CalcDelegate(int a, int b); //반환형이 int이고, 2개의 int형 변수를 매개변수로 받는 메서드를 가리킬 수 있다.

//        public static void Calc(int a, int b, CalcDelegate dele) //델리게이트도 타입이기 때문에 매개변수로 넘길 수 있다.
//        {
//            Console.WriteLine(dele(a, b)); //매개변수 a,b를 대상으로 dele가 가리키는 연산을 수행한다.
//        }

//        public static int plus(int a, int b) { Console.Write("더하기!"); return a + b; } //정적/인스턴스 유형 메소드 모두 델리게이트가 가리킬 수 있다.
//        public static int minus(int a, int b) { Console.Write("빼기!"); return a - b; }
//        public int multiply(int a, int b) { return a * b; } //인스턴스 유형.

//        public static void Main()
//        {
//            DeleTest dt = new DeleTest();

//            CalcDelegate Plus = new CalcDelegate(plus);
//            CalcDelegate Minus = DeleTest.minus; //C# 2.0부터는 간단하게 사용가능.
//            CalcDelegate Multiply = new CalcDelegate(dt.multiply); //인스턴스 메소드.
//            CalcDelegate PlusAndMinus = Minus + Plus; //델리게이트 상대로 +,- 연산 가능.

//            Calc(3, 5, Plus);
//            Calc(7, 2, minus);
//            Calc(4, 5, dt.multiply);
//            Calc(1, 1, PlusAndMinus);
//            //PlusAndMius에 Minus와 Plus가 같이 넘어가면서 dele(a,b)에서 각각 호출이 된다.
//            //하지만 Console.WriteLine 함수는 한 번만 실행되므로 뒤에 호출된 Plus값만 출력된다.
//        }

//    }
//}
