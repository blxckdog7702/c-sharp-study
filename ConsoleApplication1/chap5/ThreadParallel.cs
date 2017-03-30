//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap5
//{
//    class ThreadParallel
//    {

//        public static void Main()
//        {
//            Dictionary<string, int> dict = new Dictionary<string, int>();


//            Thread t3 = new Thread((param) =>
//            {
//                Thread.Sleep(3000);
//                var dict1 = param as Dictionary<string, int>;
//                dict1.Add("t3Result", 3);
//                Console.WriteLine("3초땡");
//            });

//            Thread t5 = new Thread((param) =>
//            {
//                Thread.Sleep(5000);
//                var dict2 = param as Dictionary<string, int>;
//                dict2.Add("t5Result", 5);
//                Console.WriteLine("5초땡");
//            });

//            t3.Start(dict);
//            t5.Start(dict);

//            t3.Join();
//            t5.Join();

//            Console.WriteLine(dict["t3Result"] + dict["t5Result"]);
//        }
//    }
//}
