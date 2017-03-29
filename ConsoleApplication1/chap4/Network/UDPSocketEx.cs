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
//    class UDPSocketEx
//    {
//        public static void Main()
//        {
//            //서버 소켓 스레드
//            Thread serverThread = new Thread(ServerFunc);
//            serverThread.IsBackground = true;
//            serverThread.Start();

//            //Thread.Sleep(1000);

//            //클라이언트 소켓이 동작하는 스레드
//            Thread clientThread = new Thread(ClientFunc);
//            clientThread.IsBackground = true;
//            clientThread.Start();

//            Console.ReadLine();
//        }

//        static void ServerFunc(object obj)
//        {
//            using (Socket servSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)) //UDP 소켓 생성
//            {
//                //ipAddress = IPAddress.Parse("0.0.0.0"); //"0.0.0.0" 이나 IPAddress.Any를 쓰면 모든 IP에 바인딩 할 수 있다.
//                //IPEndPoint endPoint = new IPEndPoint(ipAddress, 10200);
//                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 10200); //아이피주소:10200

//                servSocket.Bind(endPoint); //이 endPoint 정보로 소켓 바인딩

//                byte[] recvBytes = new byte[1024]; //받는 데이터를 저장할 바이트 배열
//                EndPoint clientEP = new IPEndPoint(IPAddress.None, 0); //클라이언트의 정보가 담겨질 EndPoint 객체

//                while (true)
//                {
//                    int nRecv = servSocket.ReceiveFrom(recvBytes, ref clientEP); //받은 바이트 수와 클라이언트 endPoint를 리턴한다.
//                    string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv); //받은 바이트 배열을 문자열으로 변환

//                    byte[] sendBytes = Encoding.UTF8.GetBytes("Hello: " + txt); //클라이언트로부터 받은 문자열에 Hello를 붙인다.
//                    servSocket.SendTo(sendBytes, clientEP); //다시 클라이언트에 전송.
//                }
//                //servSocket.Close();
//                //서버는 계속해서 서비스하는 입장이라 가정하고 무한루프로 해놓고 소켓을 닫지 않았다.
//            }
//        }

//        private static IPAddress GetCurrentIPAddress()
//        //이 메서드는 IPv4중 첫번째 ip 주소만을 리턴하므로 문제가 발생할 수 있다.
//        {
//            IPAddress[] addrs = Dns.GetHostEntry(Dns.GetHostName()).AddressList;

//            foreach (IPAddress addr in addrs)
//            {
//                if (addr.AddressFamily == AddressFamily.InterNetwork) return addr;
//                Console.WriteLine(addr);
//            }
//            return null;
//        }

//        static void ClientFunc()
//        {
//            Socket cliSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);


//            for (int i = 0; i < 5; i++)
//            {
//                byte[] buf = Encoding.UTF8.GetBytes("검둥개 님의 시간은" + DateTime.Now.ToString() + "입니다.");
//                EndPoint serverEP = new IPEndPoint(IPAddress.Loopback, 10200);
//                //127.0.0.1 또는 IPAddress.Loopback로 해도 된다.(로컬호스트)
//                //여기서 서버의 IP 대신 GetCurrentIPAddress() 한 것은 같은 컴퓨터에서 실습하기 때문이다.
//                //다른 컴퓨터라면 그 컴퓨터의 아이피 주소가 들어가야 한다.

//                cliSocket.SendTo(buf, serverEP); //서버로 보낸다.

//                byte[] recvBytes = new byte[1024]; //서버로부터 응답받은 내용을 저장할 버퍼
//                int nRecv = cliSocket.ReceiveFrom(recvBytes, ref serverEP);
//                //서버에서 받은 바이트 recvByte에 저장, 바이트 길이 nRecv에 저장.
//                string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv); //UTF8로 변환해서 받는다.

//                Console.WriteLine(txt);
//                Thread.Sleep(1000);
//            }
//            cliSocket.Close(); // 소켓은 쓰고나면 꼭꼭 닫아준다.
//        }
//    }
//}
