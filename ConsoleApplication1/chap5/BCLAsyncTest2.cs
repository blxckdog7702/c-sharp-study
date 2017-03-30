//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap5
//{
//    class BCLAsyncTest2 //TCP 서버 비동기 통신 예제
//    {
//        public static void Main()
//        {
//            TcpListener listener = new TcpListener(IPAddress.Any, 11200);
//            listener.Start();

//            while (true)
//            {
//                //연결 요청을 받아들인다.
//                var client = listener.AcceptTcpClient();
//                ProcessTcpClient(client);
//            }
//        }

//        //NetworkStream 클래스의 ReadAsync와 WriteAsync를 이용하면 간단하게 비동기 통신 구현 가능
//        private static async void ProcessTcpClient(TcpClient client)
//        {
//            NetworkStream ns = client.GetStream();

//            byte[] buffer = new byte[1024];
//            int received = await ns.ReadAsync(buffer, 0, buffer.Length);

//            string txt = Encoding.UTF8.GetString(buffer, 0 ,received);

//            byte[] sendBuffer = Encoding.UTF8.GetBytes("Hello : " + txt);
//            await ns.WriteAsync(sendBuffer, 0, sendBuffer.Length);
//            ns.Close();
//        }
//    }
//}
