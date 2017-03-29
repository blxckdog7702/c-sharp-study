//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Network
//{
//    class IPAddressEx1
//    {
//        public static void Main()
//        {
//            IPAddress ipAddr = IPAddress.Parse("202.2.30.11");
//            Console.WriteLine(ipAddr);

//            IPAddress ipAddr2 = new IPAddress(new byte[] { 202, 131, 30, 11 });
//            Console.WriteLine(ipAddr2); //위 아래 모두 같은 결과.

//            //IPAddress ipAddr3 = IPAddress.Parse("2001:0000:85a3:1000:8a2w:0370:7334");
//            //8a2w 처럼 주소가 잘못된 경우, System.FormatException: 잘못된 IP 주소를 지정했습니다. 예외 출력
//            //자리 수가 모자라도 마찬가지
//            IPAddress ipAddr3 = IPAddress.Parse("2001::85a3:0042:1000:8a2e:0370:7334"); //중간에 0000은 ::로 축약가능.
//            Console.WriteLine(ipAddr3);

//            IPAddress ipAddr4 = IPAddress.Parse("2001::7334");
//            Console.WriteLine(ipAddr4);
//        }
//    }
//}
