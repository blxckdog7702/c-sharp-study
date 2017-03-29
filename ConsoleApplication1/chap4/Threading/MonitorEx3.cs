//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Threading
//{
//    class MonitorEx3
//    {

//        public static void Main()
//        {
//            MyData data = new MyData();

//            //Thread t1 = new Thread(ThreadFunc);
//            //Thread t2 = new Thread(ThreadFunc);

//            //t1.Start(data);
//            //t2.Start(data);

//            //t1.Join();
//            //t2.Join();

//            ThreadPool.QueueUserWorkItem(ThreadFunc, data);
//            ThreadPool.QueueUserWorkItem(ThreadFunc, data);

//            Thread.Sleep(3000);

//            Console.WriteLine(data.Number);
//        }

//        class MyData
//        {

//            int number = 0;

//            public object _numberLock = new object(); //임의의 object 객체를 lock을 위해 만들어준다.

//            public int Number { get => number; }

//            public void Increment()
//            {
//                number++;
//            }

//            public void IncrementLock()
//            {
//                lock (_numberLock)
//                {
//                    number++;
//                }
//            }
//        }

//        static void ThreadFunc(object inst)
//        {
//            MyData data = inst as MyData;

//            Stopwatch st = new Stopwatch();

//            st.Start();
//            for (int i = 0; i < 100000; i++)
//            {
//                data.Increment();
//            }
//            st.Stop();
//            Console.WriteLine("lock을 쓰지 않았을 때의 시간 : {0} Ticks", st.Elapsed.Ticks);

//            st.Start();
//            for (int i = 0; i < 100000; i++)
//            {
//                data.IncrementLock();
//            }
//            st.Stop();
//            Console.WriteLine("lock을 썼을 때의 시간 : {0} Ticks", st.Elapsed.Ticks); //일반적으로 다섯 배 이상 차이가 난다.

//        }
//    }
//}

