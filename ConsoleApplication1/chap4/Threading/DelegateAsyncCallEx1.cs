//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Threading
//{
//class DelegateAsyncCallEx1 //델리게이트의 비동기 호출 실행을 스레드 풀에서 하는 예제.
//{
//    public delegate long CalcMethod(int start, int end);
//    //Cumsum 메서드를 받을 수 있는 델리게이트 선언.
//    //Cumsum 메서드는 start부터 end까지 수들의 합계를 구하는 것.

//    public static void Main()
//    {
//        CalcMethod calc = new CalcMethod(Util.Cumsum);

//        IAsyncResult ar = calc.BeginInvoke(1, 100, null, null);
//        //calc의 연산은 스레드 풀의 스레드에서 실행한다.
//        //끝나면 호출할 콜백함수나, 넘길 데이터가 없으므로 null,null

//        ar.AsyncWaitHandle.WaitOne();
//        //AsyncWaitHandle의 타입은 EventWaitHandle 타입이다. Cumsum이 완료되면 Signal로 바뀐다.
//        //Cumsum이 완료될 때까지 WaitOne에서 주 스레드는 대기한다.

//        long result = calc.EndInvoke(ar);
//        //Cumsum의 결과값을 얻기위해서 EndInvoke를 호출하였다.
//        //EndInvoke는 비동기 호출이 완료될 때 까지 호출하는 스레드를 차단한다.
//        //그래서 리턴 값이 없더라도 항상 EndInvoke를 호출하여 비동기 호출을 완료하는 것이 권장된다.

//        Console.WriteLine("합계 : {0}", result);
//    }
//}
//}
