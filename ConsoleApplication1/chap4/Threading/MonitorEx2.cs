//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Threading
//{
//    class MyData
//    {
//        int number = 0;

//        //public object _numberLock = new object(); //임의의 object 객체를 lock을 위해 만들어준다.

//        public int Number { get => number; }

//        public void Increment() 
//        {
//            //이 메서드에 아무런 동기화 기능도 제공하지 않았다.이를 스레드에 안전하지 않은 메서드라고 한다.
//            number++;

//            //lock(_numberLock) //메서드 내부에서는 동기화 처리를 이렇게 할 수 있다.
//            //{
//            //    number++;
//            //}
//        }
//    }
//    class MonitorEx2
//    {
//        public static void Main()
//        {
//            MyData data = new MyData();

//            Thread t1 = new Thread(ThreadFunc);
//            Thread t2 = new Thread(ThreadFunc);

//            t1.Start(data);
//            t2.Start(data);

//            t1.Join();
//            t2.Join();

//            Console.WriteLine(data.Number);
//        }

//        static void ThreadFunc(object inst)
//        {
//            MyData data = inst as MyData;

//            for ( int i = 0; i < 100000; i++)
//            {
//                //lock(data) { data.Increment(); }  안전하지 않은 메서드에 대한 외부 동기화 처리
//                data.Increment();
//            }
//        }
//    }
//}
