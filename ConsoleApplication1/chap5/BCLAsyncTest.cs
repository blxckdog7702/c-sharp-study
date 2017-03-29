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
//        public static async void Main()
//        {
//            WebClient wc = new WebClient();
//            // wc.Encoding = Encoding.UTF8; //인코딩 해주기

//            byte[] buf = await wc.DownloadDataTaskAsync("http://www.naver.com");
//            string text = Encoding.UTF8.GetString(buf);
//            Console.WriteLine(text);

//            //wc.DownloadStringCompleted += wc_DownloadStringCompleted; //이벤트 등록

//            ////DownloadString의 비동기 메서드
//            //wc.DownloadStringAsync(new Uri("http://www.naver.com"));

//            //Console.ReadLine();
//        }

//        //static void wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
//        //{
//        //    Console.WriteLine(e.Result);
//        //}
//    }
//}
