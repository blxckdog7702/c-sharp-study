//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Threading
//{
//    class EventWaitHandleEx1 //Join() 메서드의 역할을 EventWaitHandle로 구현
//    {
//        public static void Main()
//        {
//            //true면 signal,false면 non-signal 상태로 시작.
//            EventWaitHandle ewh = new EventWaitHandle(false, EventResetMode.ManualReset);

//            Thread t = new Thread(ThreadFunc);
//            t.IsBackground = true;
//            t.Start(ewh);

//            ewh.WaitOne(); //ewh가 signal 상태로 바뀔때까지 대기.

//            Console.WriteLine("주 스레드 종료!");
//        }

//        static void ThreadFunc(object obj)
//        {
//            EventWaitHandle ewh = obj as EventWaitHandle;

//            Console.WriteLine("6초 후에 프로그램 종료");
//            Thread.Sleep(6000);
//            Console.WriteLine("스레드 종료");

//            ewh.Set(); //ewh를 signal 상태로 바꿔준다.
//        }
//    }
//}
