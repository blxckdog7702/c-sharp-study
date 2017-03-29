//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1
//{
//    class StringBuilderEx
//    {
//        public static void Main()
//        {
//            string txt = "Hello World!";
//            string txt2 = "Hello World!";

//            Stopwatch st = new Stopwatch();
//            st.Start();
//            for (int i = 0; i < 300000; i++)
//            {
//                txt = txt + "1"; //매번 늘어난 크기의 공간을 새롭게 할당하기 때문에, 30만번의 메모리 할당과 복사 때문에 많은 시간이 걸린다.
//            }
//            st.Stop();
//            Console.WriteLine("String으로 작업하는데 걸린 시간 : " + st.Elapsed); //18초 정도 걸린다.

//            StringBuilder sb = new StringBuilder(txt2); //StringBuilder 내에 일정한 메모리를 할당하고, txt2를 복사한다. 공간이 부족하면 공간을 2배로 할당한다.
//            st.Start();
//            for( int i = 0; i < 300000; i++)
//            {
//                sb.Append("1");
//            }
//            st.Stop();
//            Console.WriteLine("StringBuilder로 작업하는데 걸린 시간 : " + st.Elapsed); //2밀리초 정도 걸린다.
//        }
//    }
//}
