//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap5
//{
//    class ActionFunc
//    {
//        public static void Main()
//        {
//            Action<string> printText =
//                (txt) =>
//                {
//                    Console.WriteLine("매개변수로 입력된 텍스트는 : " + txt);
//                };

//            printText("좋은 하루입니다!");

//            Func<int, int> square = (num) => num* num;

//            Console.WriteLine(square(5));
//        }
//    }
//}
