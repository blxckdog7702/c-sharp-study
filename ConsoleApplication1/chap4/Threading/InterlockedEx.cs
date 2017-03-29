//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Threading
//{
//class MyData
//{
//    int number = 0;

//    public int Number { get => number; set => number = value; }

//    public void Increment()
//    {
//        Interlocked.Increment(ref number); //원자적 연산을 기본으로 제공해준다. 이건 +1의 예제이다.
//    }
//    //increase : 1증가.
//    //decrease : 1감소.
//    //Exchange : 대입.
//    //add(a,b) : a를 a+b값으로 바꿈.
//    //CompareExchange(a,b,c) : a,b가 같으면 a = c 수행.
//}
//class InterlockedEx
//{
//    public static void Main()
//    {
//        MyData data = new MyData();

//        Thread t1 = new Thread(ThreadFunc);
//        Thread t2 = new Thread(ThreadFunc);

//        ThreadPool.QueueUserWorkItem(ThreadFunc, data);
//        ThreadPool.QueueUserWorkItem(ThreadFunc, data);

//        t1.Start(data);
//        t2.Start(data);

//        t1.Join();
//        t2.Join();

//        Console.WriteLine(data.Number);
//    }

//    static void ThreadFunc(object inst)
//    {
//        MyData data = inst as MyData;

//        for(int i = 1; i <= 100000; i++) data.Increment();
//    }
//}

//}
