//using System;
//using System.IO;
//using System.Text;

//namespace ConsoleApplication1
//{

//    class TextEncodingEx
//    {
//        public static void Main()
//        {
//            const string fileName = "UTF8Test.txt";

//            byte[] dataArray = null;

//            using (System.IO.FileStream
//                fileStream = new FileStream(fileName, FileMode.Open))
//            {
//                dataArray = new byte[fileStream.Length];
//                fileStream.Read(dataArray, 0, dataArray.Length);

//                string data = Encoding.UTF8.GetString(dataArray); //UTF8로 생성된 txt파일을 정상적으로 읽어온다. BOM문자도 읽어와서 ?로 뜬다.
//                Console.WriteLine(data);
//            }
//        }
//    }
//}
