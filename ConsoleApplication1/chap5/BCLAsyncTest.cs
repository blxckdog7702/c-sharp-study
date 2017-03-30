//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap5
//{
//    class BCLAsyncTest
//    {
//        public static void Main()
//        {
//            AwaitDownloadString();

//            Console.ReadLine();
//        }

//        private static async void AwaitDownloadString()
//        {
//            WebClient wc = new WebClient();
//            wc.Encoding = Encoding.UTF8;

//            //DownloadStringAsync보다 더 간편하게 이용 가능.
//            string text = await wc.DownloadStringTaskAsync("http://www.naver.com");
//            Console.WriteLine(text);
//        }
//    }
//}
