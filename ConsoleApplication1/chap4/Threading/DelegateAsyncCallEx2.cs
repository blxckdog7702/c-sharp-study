//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Threading
//{
//    class DelegateAsyncCallEx2 //FileStream의 비동기 호출과 유사한 Delegate의 비동기 호출 예제
//    {
//        public delegate long CalcMethod(int start, int end);

//        public static void Main()
//        {
//            CalcMethod calc = new CalcMethod(Util.Cumsum);

//            calc.BeginInvoke(1, 100, calcCompleted, calc);
//            //비동기 호출이 시작된다. 끝나면 calcComplete를 스레드 풀에서 실행한다.
//        }

//        static void calcCompleted(IAsyncResult ar)
//        {
//            CalcMethod calc = ar.AsyncState as CalcMethod; //BeginInvoke에서 매개변수로 보낸 calc를 형변환해서 받는다.

//            long result = calc.EndInvoke(ar); //비동기 호출 결과를 리턴해준다.

//            Console.WriteLine(result);
//        }
//    }
//}
