//using System;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading;

//namespace ConsoleApplication1.chap4.Network
//{
//    public class AsyncStateData
//    {
//        public byte[] buffer;
//        public Socket socket;
//    }

//    class TCPSocketEx3 //TCP 비동기 통신 서버 예제
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
//            clientThread.Start();

//            Console.ReadLine();
//        }

//        static void ServerFunc()
//        {
//            using (Socket srvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
//            {
//                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 11200);

//                srvSocket.Bind(endPoint);

//                srvSocket.Listen(10);

//                while(true)
//                {
//                    Socket cliSocket = srvSocket.Accept();

//                    AsyncStateData data = new AsyncStateData();
//                    data.buffer = new byte[1024];
//                    data.socket = cliSocket;

//                    cliSocket.BeginReceive(data.buffer, 0, data.buffer.Length, SocketFlags.None, asyncReceiveCallback, data);
//                    //비동기 동작
//                    //바로 While문의 시작으로 돌아가 다른 클라이언트와의 연결을 지연없이 받을 수 있다.
//                    //BeginRecv -> EndRecv -> BeginSend -> EndSend 순서대로 진행된다.
//                }
//            }
//        }

//        private static void asyncReceiveCallback(IAsyncResult ar) //BeginReceive에서 콜백
//        {
//            AsyncStateData rcvData = ar.AsyncState as AsyncStateData;

//            int nRecv = rcvData.socket.EndReceive(ar);
//            string txt = Encoding.UTF8.GetString(rcvData.buffer, 0, nRecv); //문자열 데이터를 받는다.

//            byte[] sendBytes = Encoding.UTF8.GetBytes("Hello: " + txt); //받은 문자열에 Hello를 붙여서 다시 보낸다.
//            rcvData.socket.BeginSend(sendBytes, 0, sendBytes.Length, SocketFlags.None, asyncSendCallback, rcvData.socket);
//        }

//        private static void asyncSendCallback(IAsyncResult ar) //BeginSend에서 콜백
//        {
//            Socket socket = ar.AsyncState as Socket;
//            socket.EndSend(ar); //비동기 보내기 작업을 끝내준다.

//            socket.Close(); //소켓을 다 사용했으므로 닫아준다.
//        }

//        static void ClientFunc()
//        {
//            //구현
//        }
//    }
//}
