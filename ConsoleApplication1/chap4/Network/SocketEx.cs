//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Network
//{
//    class SocketEx
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

//            Console.WriteLine("종료하려면 아무 키나 누르세요...");
//            Console.ReadLine();
//        }

//        static void ServerFunc()
//        {

//        }

//        static void ClientFunc()
//        {

//        }
//    }


//}
