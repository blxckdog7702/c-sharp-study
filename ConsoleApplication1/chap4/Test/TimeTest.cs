//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Time
//{
//    class TimeTest
//    {
//        public static void Main()
//        {
//            DateTime now = DateTime.Now;
//            Console.WriteLine(now); //현재 시간 출력

//            //날짜 출력
//            Console.WriteLine(string.Format("{0:D}", DateTime.Now));

//            //시간 출력
//            CultureInfo info = new CultureInfo("en-US");
//            Console.WriteLine(string.Format(info,"{0:t}", DateTime.Now));

//            //AM/PM 표시를 앞으로.
//            Console.WriteLine(now.ToString("tt", new CultureInfo("en-US")) + " " + now.ToString("h:mm")); 

//        }
//    }
//}
