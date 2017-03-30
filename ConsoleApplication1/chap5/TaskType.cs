//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap5
//{
//    class TaskType
//    {
//        public static void Main()
//        {
//            //스레드 풀에서
//            ThreadPool.QueueUserWorkItem((obj) => { Console.WriteLine("process workitem"); }, null);

//            Task task1 = new Task(() => { Console.WriteLine("process taskitem"); });

//            task1.Start();

//            Task task2 = new Task((obj) => { Console.WriteLine("process taskitem(obj)"); }, null);

//            task2.Start();

//            task1.Wait(); //task1의 작업이 끝날 때까지 현재 스레드를 대기한다.
//            task2.Wait();

//            //task 객체를 생성할 필요 없이 바로 작업 시작 가능.
//            Task.Factory.StartNew(() => { Console.WriteLine("process taskitem StartNew"); });

//            //Task<TResult> 타입은 값을 반환할 수 있다.
//            Task<int> task3 = new Task<int>(() =>
//               {
//                   Random rand = new Random((int)DateTime.Now.Ticks);
//                   return rand.Next();
//               }
//            );
//            task3.Start();
//            task3.Wait();
//            Console.WriteLine("무작위 숫자 값 : " + task3.Result);

//            //StartNew<TResult> 도 반환.
//            Task<int> taskReturn = Task.Factory.StartNew<int>(() => 255);
//            taskReturn.Wait();
//            Console.WriteLine(taskReturn.Result);
//        }
//    }
//}
