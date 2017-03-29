//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Network
//{
//    class HttpServerEx
//    {
//        public static void Main()
//        {
//            //서버 소켓 스레드
//            Thread serverThread = new Thread(ServerFunc);
//            serverThread.IsBackground = true;
//            serverThread.Start();


//            Console.WriteLine("종료하려면 아무 키나 누르세요...");
//            Console.ReadLine();
//        }

//        static void ServerFunc()
//        {
//            using (Socket servSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
//            {
//                Console.WriteLine("http://localhost:8000입니다.");

//                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 8000);

//                servSocket.Bind(endPoint);
//                servSocket.Listen(10);

//                while (true)
//                {
//                    Socket cliSocket = servSocket.Accept();
//                    Console.WriteLine("요청이 들어왔습니다!"); //요청이 들어올 때 마다 출력된다.
//                    ThreadPool.QueueUserWorkItem(httpProcessFunc, cliSocket); //요청이 들어오면 httpProcessFunc가 호출된다.
//                }
//            }
//        }

//        private static void httpProcessFunc(object state)
//        {
//            Socket socket = state as Socket;

//            byte[] buf = new byte[4096];
//            socket.Receive(buf);

//            string header = "HTTP/1.0 200 OK\nContent-Type: text/html; charset=UTF-8\r\n\r\n";
//            //브라우저는 개행문자 2개 이후로 나온 내용을 화면에 보여준다. 개행문자 2개가 header와 body의 구분자가 된다.
//            string body = "<html><body><mark>테스트 HTML</mark> 웹 페이지입니다.</body></html>";

//            byte[] resbuf = Encoding.UTF8.GetBytes(header + body);

//            socket.Send(resbuf); //header + body를 합쳐 다시 전송한다.

//            socket.Close(); //다 쓴 소켓은 닫아준다.
//        }
//    }
//}
