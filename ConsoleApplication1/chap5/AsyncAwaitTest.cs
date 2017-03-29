//using System;
//using System.IO;
//using System.Net;
//using System.Text;
//using System.Threading;

//namespace ConsoleApplication1.chap5
//{
//    class AsyncAwaitTest
//    {
//        //async 예약어가 없이 await를 사용할 수 없다.
//        private static async void AwaitRead()
//        {
//            using (FileStream fs = new FileStream("test.log", FileMode.Open))
//            {
//                byte[] buffer = new byte[fs.Length];

//                Console.WriteLine("실행 전의 스레드 id : " + Thread.CurrentThread.ManagedThreadId);
//                await fs.ReadAsync(buffer, 0, buffer.Length);
//                Console.WriteLine("실행 후의 스레드 id : " + Thread.CurrentThread.ManagedThreadId);
//                //ReadAsync 이하의 처리는 스레드 풀 스레드가 담당하기 때문에 스레드 id가 다르게 나온다.

//                //이하의 라인은 ReadAsync 비동기 호출이 완료된 후 호출    
//                string txt = Encoding.UTF8.GetString(buffer);
//                Console.WriteLine(txt);

//            }
//        }

//        public static void Main()
//        {
//            AwaitRead();
//            Console.ReadLine();

//            WebClient wc = new WebClient();
//        }
//    }
//}
