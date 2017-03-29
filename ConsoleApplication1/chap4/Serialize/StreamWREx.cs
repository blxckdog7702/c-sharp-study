//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4
//{
//    class StreamWREx
//    {
//        public static void Main()
//        {
//            //Stream에 문자열을 쓰려면 Encoding을 해서 바이트 배열로 변환해야 한다.
//            MemoryStream ms = new MemoryStream();

//            byte[] buf = Encoding.UTF8.GetBytes("Hello World!");
//            ms.Write(buf, 0, buf.Length);

//            //StreamWriter는 문자열 인코딩 방식을 생성자에서 받는다. 그 이후에는 바로 해당 인코딩 방식에 따라 자동으로 변환한다.
//            StreamWriter sw = new StreamWriter(ms, Encoding.UTF8);
//            StreamReader sr = new StreamReader(ms, Encoding.UTF8); //읽을때는 저장 인코딩 형식을 맞춰야한다. 다른 인코딩 형식으로 읽으면 깨짐.

//            sw.WriteLine("안녕 세상아!"); //MemoryStream에 넣을 때와는 달리 직접 인코딩을 해주지 않아도 설정해둔 방식으로 들어간다.

//            Console.WriteLine(sr.ReadToEnd()); //아무것도 출력되지 않는다. 아직 내부버퍼에만 있는 상태여서.

//            sw.Flush(); //내부 버퍼에 보관하던 문자열들을 모두 stream에 쓴다. (기본 버퍼 사이즈 = 1024바이트)
//            Console.WriteLine(sr.ReadToEnd()); //아무것도 출력되지 않는다. 내부버퍼에서 stream으로 보냈지만, 포지션이 뒤쪽에 있어서 아무것도 없는곳을 읽는다.

//            ms.Position = 0;
//            Console.WriteLine(sr.ReadToEnd()); //내부버퍼에서 stream으로도 보냈고, 포지션도 0으로 초기화해서 stream안의 모든 문자열들이 출력된다.

//            sw.WriteLine("Blackdog");
//            sw.WriteLine(3000); //Tostring 메서드를 통해서 "3000"이 들어간다.
//            sw.Flush(); //내부 버퍼에 보관하던 문자열들을 모두 stream에 쓴다.

//            ms.Position = 0;

//            string txt = sr.ReadToEnd(); //안의 모든 내용을 읽기 위해서 포지션 0으로 초기화.
//            Console.WriteLine(txt);

//            byte[] arr = ms.ToArray();
//            Util.PrintArr(arr);
//        }
//    }
//}
