//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Network
//{
//    class HttpWebRequestEx
//    {
//        public static void Main()
//        {
//            ClientFunc();

//            Console.WriteLine("종료하려면 아무 키나 누르세요...");
//            Console.ReadLine();
//        }

//        static void ClientFunc()
//        {
//            //타입 내부에서 TCP 소켓을 생성한다.
//            HttpWebRequest req = WebRequest.Create("http://www.naver.com") as HttpWebRequest;

//            //GetResponse()를 호출하면서 지정 웹 서버로 HTTP 요청을 보내고 응답을 받는다.
//            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;

//            //받은 응답을 읽어서 출력한다.
//            using(StreamReader sr = new StreamReader(resp.GetResponseStream()))
//            {
//                string responseText = sr.ReadToEnd();

//                Console.WriteLine(responseText);
//            }
//        }
//    }
//}
