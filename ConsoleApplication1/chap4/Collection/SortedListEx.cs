//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Collection
//{
//    class SortedListEx
//    {
//        public static void Main()
//        {
//            SortedList sl = new SortedList();

//            sl.Add(10, "강백호"); //값을 넣을 때 마다 key값 기준으로 정렬해서 저장된다. 숫자 오름차순.
//            sl.Add(11, "서태웅");
//            sl.Add(7, "송태섭");
//            sl.Add(14, "정대만");
//            sl.Add(4, "채치수");

//            foreach( object key in sl.Keys)
//            {
//                Console.WriteLine("{0}번 {1}", key, sl[key]); //숫자 오름차순으로 결과를 출력한다.
//            }
//        }
//    }
//}
//ㅁ