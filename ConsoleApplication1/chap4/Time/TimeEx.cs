//using System;
//using System.Diagnostics;

//namespace ConsoleApplication1
//{
//    class TimeEx
//    {
//        public static void Main()
//        {
//            DateTime now = DateTime.Now;
//            Console.WriteLine(now); //현재 시간 출력
//            Console.WriteLine(now.Ticks); //기준시간 1년 1월 1일. 유닉스나 자바에선 1970년 1월 1일

//            DateTime utcNow = DateTime.UtcNow;
//            Console.WriteLine(utcNow); //협정 세계시 출력 .Local로 하면 지역시간 반영

//            DateTime myBirthday = new DateTime(now.Year, 1, 24);
//            Console.WriteLine(myBirthday.Kind); //지정하지 않았으므로 Unspecified 출력

//            DateTime endOfYear = new DateTime(DateTime.Now.Year, 12, 31);
//            TimeSpan dayGaps = endOfYear - now; //DateTime의 빼기연산해서 나온 결과값은 TimeSpan으로 나온다.
//            Console.WriteLine(dayGaps.Days); //Day외에도 시간, 분, 초 , 밀리초 단위도 출력 가능

//            DateTime before = DateTime.Now; //Sum() 메서드의 수행 시간을 측정하는 부분
//            Sum();
//            DateTime after = DateTime.Now;
//            long gap = after.Ticks - before.Ticks; //Ticks의 기준은 100ns.
//            Console.WriteLine(gap);

//            Stopwatch st = new Stopwatch(); //스탑워치 기능도 쓸 수 있다.
//            st.Start();
//            Sum();
//            st.Stop();
//            Console.WriteLine("total Ticks : " + st.ElapsedTicks);
//        }

//        private static int Sum()
//        {
//            int sum = 0;

//            for (int i = 0; i < 1000000; i++)
//            {
//                sum += i;
//            }

//            return sum;
//        }
//    }
//}
