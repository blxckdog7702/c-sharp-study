//using System;
//using System.Collections;
//using System.Threading;

//namespace ConsoleApplication1.chap4.Threading
//{
//    class MyData
//    {
//        int number = 0;

//        public object _numberLock = new object(); //임의의 object 객체를 lock을 위해 만들어준다.

//        public int Number { get => number; }

//        public void Increment()
//        {
//            number++;
//        }

//        public void IncrementLock()
//        {
//            lock (_numberLock)
//            {
//                number++;
//            }
//        }
//    }

//    class EventWaitHandleEx2 //ThreadPool에서 EventWaitHandler로 Join()메서드 기능을 구현
//    {
//        public static void Main()
//        {
//            MyData data = new MyData();

//            Hashtable ht1 = new Hashtable();
//            //QueueUserWorkItem이 매개변수를 하나만 받으므로,
//            //data와 EventWaitHandle 두 개의 값을 전달하기 위해서 Hashtable로 만들었다.
//            ht1["data"] = data;
//            ht1["evt"] = new EventWaitHandle(false, EventResetMode.ManualReset);
//            //기본 상태를 non-signal로 설정.
//            //AutoReset으로 하면 Signal 상태가 자동으로 Non-Signal 상태로 전환된다.
//            //AutoReset으로 설정했을 때, set()하면 대기하던 하나의 스레드를 깨우고 곧바로 non-signal로 바뀐다.

//            ThreadPool.QueueUserWorkItem(ThreadFunc, ht1);

//            Hashtable ht2 = new Hashtable();
//            ht2["data"] = data;
//            ht2["evt"] = new EventWaitHandle(false, EventResetMode.ManualReset);

//            ThreadPool.QueueUserWorkItem(ThreadFunc, ht2);

//            (ht1["evt"] as EventWaitHandle).WaitOne();
//            (ht2["evt"] as EventWaitHandle).WaitOne();

//            Console.WriteLine(data.Number);
//        }

//        static void ThreadFunc(object obj)
//        {
//            Hashtable ht = obj as Hashtable; //object형으로 넘어온 Hashtable을 형변환해서 사용한다.

//            MyData data = ht["data"] as MyData;

//            for (int i = 0; i < 100000; i++)
//            {
//                data.IncrementLock(); //동기화 처리된 증가 메서드
//            }

//            (ht["evt"] as EventWaitHandle).Set(); 
//            //작업을 다 끝내면 EventWaitHandler를 set해서 WaitOne()의 대기 상태를 해제한다.
//        }
//    }
//}
