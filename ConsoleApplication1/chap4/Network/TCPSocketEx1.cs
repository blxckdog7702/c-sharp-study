//using System;
//using System.IO;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading;

//namespace ConsoleApplication1.chap4.Network
//{
//    class TCPSocketEx1
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
//            clientThread.IsBackground = false;
//            clientThread.Start();

//            Console.ReadLine();
//        }

//        static void ServerFunc()
//        {
//            using (Socket srvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
//            {
//                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 11200); //서버는 어떤 ip에서의 접근도 허용해야 하므로..

//                srvSocket.Bind(endPoint); //바인딩한다.

//                srvSocket.Listen(10);  //최대 10개의 클라이언트 접속을 보관 할 수 있다. //0 이나 음수여도 되는데?

//                while (true)
//                {
//                    Socket cliSocket = srvSocket.Accept();
//                    //서버 소켓은 클라이언트와 직접적인 통신이 안된다.
//                    //직접적인 통신은 서버 소켓의 Accept()로 반환된 소켓 인스턴스로만 할 수 있다.
//                    //Accept()로 반환된 소켓은 클라이언트 쪽 소켓과 1:1 대응되므로 IPEndPoint 인자를 전달할 필요가 없다.

//                    byte[] recvBytes = new byte[1024]; 

//                    int nRecv = cliSocket.Receive(recvBytes); //recvBytes에 소켓으로 받아온 데이터를 넣는다. nRecv에는 바이트 수를 넣는다.
//                    string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);

//                    byte[] sendBytes = Encoding.UTF8.GetBytes("Hello : " + txt); //받은 문자열에 Hello를 붙여서 다시 보낸다.
//                    cliSocket.Send(sendBytes); //다시 보낸다.
//                    cliSocket.Close(); //소켓을 닫아준다.
//                }
//            }
//        }

//        static void ClientFunc()
//        {
//            Socket cliSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

//            EndPoint serverEp = new IPEndPoint(IPAddress.Loopback, 11200);

//            cliSocket.Connect(serverEp); //클라이언트에서 Connect를 호출하는 시점에 서버는 Listen을 호출한 상태여야 한다.

//            byte[] buf = Encoding.UTF8.GetBytes("검둥개 님의 시간은" + DateTime.Now.ToString() + "입니다.");
//            cliSocket.Send(buf);

//            try
//            {
//                byte[] recvBytes = new byte[1024];

//                int nRecv = cliSocket.Receive(recvBytes);
//                string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv); //받은 문자열을 인코딩 후 출력한다.

//                Console.WriteLine(txt);
//            }
//            catch(SocketException)
//            {
//                //예외처리
//            }
//            cliSocket.Close();
//        }
//    }
//}
