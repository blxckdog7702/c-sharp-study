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
//    class TCPSocketEx2 //TCP 다중 스레드
//    {
//        public static void Main()
//        {
//            //서버 소켓 스레드
//            Thread serverThread = new Thread(ServerFunc);
//            serverThread.IsBackground = true;
//            serverThread.Start();

//            Thread.Sleep(1000);

//            //클라이언트 소켓이 동작하는 스레드
//            Thread clientThread = new Thread(ClientFunc);
//            clientThread.IsBackground = true;
//            serverThread.Start();

//            Console.WriteLine("종료하려면 아무 키나 누르세요...");
//            Console.ReadLine();
//        }

//        static void ServerFunc()
//        {
//            using (Socket srvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
//            {
//                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 11200);

//                srvSocket.Bind(endPoint);

//                srvSocket.Listen(10);

//                while (true)
//                {
//                    Socket cliSocket = srvSocket.Accept(); //Accept받은 소켓을 스레드풀의 처리를 스레드 풀의 스레드에게 맡긴다.
//                    ThreadPool.QueueUserWorkItem((WaitCallback)clientSocketProcess, cliSocket);
//                    //하지만 한 클라이언트 당 하나의 스레드가 생성되면서 동시 처리할 수 있는 클라이언트 개수에 제한이 생긴다.
//                }
//            }
//        }

//        private static void clientSocketProcess(object state)
//        {
//            Socket cliSocket = state as Socket;

//            byte[] recvBytes = new byte[1024];

//            int nRecv = cliSocket.Receive(recvBytes);
//            string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);

//            byte[] sendBytes = Encoding.UTF8.GetBytes("Hello: " + txt);
//            cliSocket.Send(sendBytes);
//            cliSocket.Close();
//        }

//        static void ClientFunc()
//        {
//            //구현
//        }
//    }
//}
