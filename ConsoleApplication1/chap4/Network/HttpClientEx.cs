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
//    class HttpEx //HTTP 프로토콜의 기본은 요청과 응답이다. 
//    {
//        public static void Main()
//        {
//            //클라이언트 소켓이 동작하는 스레드
//            Thread clientThread = new Thread(ClientFunc);
//            clientThread.IsBackground = true;
//            clientThread.Start();

//            Console.WriteLine("종료하려면 아무 키나 누르세요...");
//            Console.ReadLine();
//        }

//        static void ClientFunc()
//        {
//            using (Socket cliSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
//            {
//                IPAddress ipAddr = Dns.GetHostEntry("www.naver.com").AddressList[0];

//                EndPoint serverEP = new IPEndPoint(ipAddr, 80);

//                cliSocket.Connect(serverEP);

//                /////Send와 Receive 구현

//                string request = "GET / HTTP/1.0\r\nHost: www.naver.com\r\n\r\n";
//                byte[] sendBuffer = Encoding.UTF8.GetBytes(request);

//                //네이버 웹 서버로 HTTP 요청을 전송
//                cliSocket.Send(sendBuffer);

//                //HTTP 요청이 전달되었으므로 네이버 웹 서버에서 응답 수신
//                StringBuilder sb = new StringBuilder();

//                while (true)
//                {
//                    Console.WriteLine("몇 번 돌았나?");
//                    byte[] recvBuffer = new byte[4096];

//                    int nRecv = cliSocket.Receive(recvBuffer);

//                    if (nRecv == 0)
//                    {
//                        //서버측에서 더는 받을 데이터가 없으면 Receive() 메서드에서 0을 반환.
//                        Console.WriteLine("더 이상 수신받을 데이터가 없습니다.!");
//                        break;
//                    }

//                    string text = Encoding.UTF8.GetString(recvBuffer, 0, nRecv);
//                    sb.Append(text);
//                    sb.Append("\r\n");
//                }

//                cliSocket.Close();

//                string response = sb.ToString();

//                Console.WriteLine(response);
//            }
//        }
//    }
//}
