//using System;
//using System.Collections;

//namespace ConsoleApplication1.chap4.Collection
//{
//    class HashtableEx
//    {
//        public static void Main()
//        {
//            Hashtable ht = new Hashtable();

//            ht.Add("서태웅", 11); //Hashtable에 값 추가, key, value모두 object 타입으로 다뤄지기 때문에 박싱 발생.
//            ht.Add("강백호", 10);
//            ht.Add("정대만", 14);
//            ht.Add("채치수", 4);
//            ht.Add("송태섭", 7);
//            //ht.Add("송태섭", 3); //key값이 겹치는 경우 ArgumentException 발생


//            Console.WriteLine(ht["정대만"]);
//            ht.Remove("채치수"); //"채치수"의 value 삭제

//            ht["강백호"] = 100; //"강백호" 의 value 변경

//            foreach (object key in ht.Keys)
//            {
//                Console.WriteLine("{0} => {1}", key, ht[key]);
//            }
//        }
//    }
//}
