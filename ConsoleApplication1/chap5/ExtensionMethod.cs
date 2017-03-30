//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap5
//{
//    //현재 날짜로부터 n일을 뺀 날짜를 구해주는 메서드를 가진 헬퍼 클래스.
//    public static class DateTimeHelper
//    {
//        //기존 헬퍼 메서드
//        public static DateTime MinusDays(DateTime dt, int days)
//        {
//            DateTime d = dt.AddDays(-days);
//            return d;
//        }

//        //확장 메서드
//        public static DateTime MinusDaysEx(this DateTime dt, int days)
//        {
//            DateTime d = dt.AddDays(-days);
//            return d;
//        }
//    }
//    class ExtensionMethod
//    {
//        public static void Main()
//        {
//            //DateHelper라는 클래스 이름과 함께 MinusDays 메서드를 호출해야한다.
//            //날짜 연산의 대상이 되는 current 객체를 넘겨줘야 한다.
//            DateTime current = DateTime.Now;
//            DateTime dt1 = DateTimeHelper.MinusDays(current, 3);
//            Console.WriteLine(dt1.ToString());

//            //확장 메서드를 이용하면 헬퍼 클래스의 이름을 기억해서 호출할 필요가 없다.
//            //대상이 되는 객체를 인자로 넘겨줄 필요가 없다.
//            DateTime dt2 = current.MinusDaysEx(3);
//            Console.WriteLine(dt2.ToString());
//            Console.ReadLine();
//        }
//    }
//}
