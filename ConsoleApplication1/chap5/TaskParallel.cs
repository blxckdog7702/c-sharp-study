//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap5
//{
//    class TaskParallel
//    {
//        //비동기 처리 담당 메서드
//        private static async void DoAsyncTask()
//        {
//            var task3 = Method3Async();
//            var task5 = Method5Async();

//            //task3, task5가 끝날 때까지 대기한다.
//            await Task.WhenAll(task3, task5);
//            //그 이후 실행
//            Console.WriteLine(task3.Result + task5.Result);
//        }
//        //3초 후 3리턴
//        private static Task<int> Method3Async()
//        {
//            return Task.Factory.StartNew( () =>
//            {
//                Thread.Sleep(3000);
//                return 3;
//            });
//        }
//        //5초 후 5리턴
//        private static Task<int> Method5Async()
//        {
//            return Task.Factory.StartNew(() =>
//            {
//                Thread.Sleep(5000);
//                return 5;
//            });
//        }

//        public static void Main()
//        {
//            DoAsyncTask();

//            Console.WriteLine("먼저 출력되고, 비동기 값 나중에 출력됨.");
//            Console.ReadLine();
//        }
//    }
//}
