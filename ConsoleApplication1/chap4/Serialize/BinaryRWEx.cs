//using System;
//using System.IO;

//namespace ConsoleApplication1.chap4
//{
//    class BinaryRWEx
//    {
//        public static void Main() //기본형 타입을 2진 데이터로 바꿔서 쓴다. 문자열은 UTF-8로 바꾼다.
//        {
//            MemoryStream ms = new MemoryStream();

//            BinaryWriter bw = new BinaryWriter(ms);

//            bw.Write("Hello World!" + Environment.NewLine); //문자열은 무조건 UTF-8인코딩
//            bw.Write("Blackdog" + Environment.NewLine);
//            bw.Write(1048575); //1111(15) + 1111 1111 1111 1111(65535) = 1048575
//            bw.Flush(); //내부 버퍼의 내용을 강제로 스트림에 쓴다. (내부 버퍼의 크기는 16바이트)

//            ms.Position = 0;

//            BinaryReader br = new BinaryReader(ms);
//            string first = br.ReadString();
//            string second = br.ReadString();
//            //int test = br.ReadInt32(); //int로 받아오면 1048575로 결과값이 출력된다.
//            ushort test = br.ReadUInt16(); //억지로 4바이트를 2바이트로 쪼개면 65535출력
//            ushort test2 = br.ReadUInt16(); //15출력. 순서가 뒤바뀐 이유는 리틀 엔디안이기 때문에.

//            Console.WriteLine("{0}{1}{2} {3}", first, second, test, test2); //Hello World!, Blackdog, 65535 15 출력.

//            byte[] arr = ms.ToArray();
//            Util.PrintArr(arr); //데이터의 의미 단위마다 그 길이를 알려주는 1바이트가 있고 그 뒤에 데이터가 바이트화 되서 출력된다.
//                                //14 hello world! 개행, 10 blackdog 개행 식으로...

//        }
//    }
//}
