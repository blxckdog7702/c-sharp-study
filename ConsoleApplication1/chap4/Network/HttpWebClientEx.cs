//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Network
//{
//    class HttpWebClientEx
//    {
//        public static void Main()
//        {
//            ClientFunc();

//            Console.WriteLine("종료하려면 아무 키나 누르세요...");
//            Console.ReadLine();
//        }

//        static void ClientFunc()
//        {
//            //WebClient 타입은 내부적으로 httpWebRequest를 이용해 통신한다.
//            WebClient wc = new WebClient();

//            //입력한 Url에서 받아온 데이터를 인코딩만 해서 출력하면 끝.
//            string responseText = Encoding.UTF8.GetString(wc.DownloadData("http://www.naver.com"));

//            Console.WriteLine(responseText);
//        }
//    }
//}
