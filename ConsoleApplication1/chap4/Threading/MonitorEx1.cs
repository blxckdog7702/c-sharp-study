//using System;
//using System.Threading;

//namespace ConsoleApplication1.chap4.Threading
//{
//    class MonitorEx1
//    {
//        int number = 0;


//        public static void Main()
//        {
//            MonitorEx1 me = new MonitorEx1();

//            Thread t1 = new Thread(ThreadFunc);
//            Thread t2 = new Thread(ThreadFunc);

//            t1.Start(me);
//            t2.Start(me);

//            t1.Join();
//            t2.Join();

//            Console.WriteLine(me.number);
//        }

//        static void ThreadFunc(object inst)
//        {
//            MonitorEx1 me = inst as MonitorEx1;

//            for (int i = 0; i < 1000000; i++) //동기화 처리가 되지 않았을 때
//            {
//                //반복 횟수가 커질수록 예측할 수 없는 값이 나온다.
//                //공유 리소스인 number에 대한 동기화 처리를 하지 않았기 때문이다.
//                me.number++;
//                me.number = me.number + 1;
//            }

//            //for (int i = 0; i < 100000; i++) //모니터를 사용하여 동기화 처리를 했을 때
//            //{
//            //    Monitor.Enter(me);
//            //    //모니터 Enter와 Exit 사이의 코드는 한 순간에 스레드 하나에만 진입해서 실행된다.
//            //    //Enter와 Exit 메서드로 전달하는 인자는 참조형 타입의 인스턴스여야 한다.
//            //    //me객체의 잠금이 한 스레드에 점유되고 있으면 다른 스레드는 me 객체에 대한 작업을 하지 못하고 대기 상태로 들어간다.
//            //    //값 타입을 매개변수로 넣으면 System.Threading.SynchronizationLockException: 예외 출력.
//            //    try
//            //    {
//            //        me.number++;
//            //    }
//            //    finally
//            //    {
//            //        Monitor.Exit(me);
//            //    }
//            //}

//            //for (int i = 0; i < 100000; i++) //lock을 사용하여 동기화 처리를 했을 때
//            //{
//            //    lock (me)
//            //    {
//            //        me.number++;
//            //    }
//            //}
//        }
//    }
//}
