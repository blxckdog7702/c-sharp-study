//using System;
//using System.IO;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap5
//{
//    class TaskAsync
//    {
//        //비동기로 처리할 ReadAllTextAsync라는 메서드를 만들어서 파일 경로를 넘겨준다.
//        private static async void AwaitFileRead(string filePath)
//        {
//            string fileText = await ReadAllTextAsync(filePath);
//            Console.WriteLine(fileText);
//        }

//        //Task를 이용하여 넘겨받은 파일 경로로 들어가 텍스트를 읽고 리턴한다.
//        static Task<string> ReadAllTextAsync(string filePath)
//        {
//            return Task.Factory.StartNew(() =>
//            {
//                return File.ReadAllText(filePath);
//            });
//        }

//        public static void Main()
//        {
//            string filePath = "test.log";

//            //비동기로 처리되므로 바로 다음 줄 실행
//            AwaitFileRead(filePath);

//            Console.ReadLine();
//        }
//    }
//}
