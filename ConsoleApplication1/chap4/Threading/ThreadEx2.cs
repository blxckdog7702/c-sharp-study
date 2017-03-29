//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Threading
//{
//class ThreadParam
//{
//    public int x;
//    public int y;
//}
//class ThreadEx2
//{
//    public static void Main()
//    {
//        Thread t = new Thread(ThreadFunc);

//        ThreadParam tp = new ThreadParam();
//        tp.x = 1;
//        tp.y = 2;

//        t.Start(tp); //스레드에 2개 이상의 값을 매개변수로 넣고 실행하려면, 
//                        //전달할 값의 수 만큼 필드를 포함한 객체를 넣어준다.
//    }

//    static void ThreadFunc(object initialValue)
//    {
//        ThreadParam value = (ThreadParam)initialValue;
//        Console.WriteLine("넘어온 x값:{0}, 넘어온 y값:{1}", value.x, value.y);
//    }
//}
//}
