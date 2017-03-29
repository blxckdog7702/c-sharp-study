//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Threading
//{
//    class FileState
//    {
//        public byte[] buffer;
//        public FileStream file;
//    }

//    class AsyncCallEx1
//    {
//        public static void Main()
//        {
//            FileStream fs = new FileStream("test.log", FileMode.Open);

//            FileState state = new FileState();
//            state.buffer = new Byte[fs.Length];
//            state.file = fs;

//            fs.BeginRead(state.buffer, 0, state.buffer.Length, ReadCompleted, state);
//            //읽은 데이터를 저장할 버퍼, 읽기를 시작할 바이트 위치, 읽을 바이트의 길이, 비동기 요청이 끝나면 실행될 메서드, 비동기 요청을 구분할 수 있는 객체

//            Console.WriteLine("비동기 호출 실행중!");

//            Console.ReadLine(); //비동기이기 때문에 읽기 작업과는 별개로 실행된다.

//            fs.Close();
//        }

//        //읽기 작업이 완료되면 호출되는 메서드이다. 스레드 풀의 스레드에서 실행된다.
//        static void ReadCompleted(IAsyncResult ar)
//        {
//            Console.WriteLine("비동기 호출 실행 완료!");
//            FileState state = ar.AsyncState as FileState; //state로 전달된 객체를 형변환을 통해 받을 수 있다.

//            state.file.EndRead(ar); //비동기 읽기 작업이 끝나기를 기다린다. BeginRead를 썼으면 꼭 써줘야한다.
//                                    //그렇지 않으면 교착 상태 같이 원치 않는 동작이 발생할 수 있다.

//            string txt = Encoding.UTF8.GetString(state.buffer);
//            Console.WriteLine(txt); //"test.log"에 있던 문자열들이 출력된다.
//        }
//    }
//}
