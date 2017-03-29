//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Network
//{
//class DnsEx
//{
//    public static void Main()
//    {
//        //인터넷 연결 안하면 System.Net.Sockets.SocketException: 알려진 호스트가 없습니다. 예외 출력
//        IPHostEntry entry = Dns.GetHostEntry("www.microsoft.com");
//        foreach(IPAddress ipAddress in entry.AddressList)
//        {
//            Console.WriteLine(ipAddress);
//        }

//        IPHostEntry entry2 = Dns.GetHostEntry("www.naver.com"); //네이버에 할당된 아이피는 2개
//        foreach (IPAddress ipAddress in entry2.AddressList)
//        {
//            Console.WriteLine(ipAddress);
//        }

//        string myComputer = Dns.GetHostName(); //내컴퓨터 이름과 지금 할당된 아이피 주소가 표시된다.

//        Console.WriteLine("컴퓨터 이름 : " + myComputer);

//        IPHostEntry entry3 = Dns.GetHostEntry(myComputer);
//        foreach (IPAddress ipAddress in entry3.AddressList)
//        {
//            Console.WriteLine(ipAddress.AddressFamily + ": " + ipAddress);
//        }
//    }
//}
//}
