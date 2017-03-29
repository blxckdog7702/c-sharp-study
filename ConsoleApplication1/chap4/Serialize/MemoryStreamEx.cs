//using System;
//using System.IO;

//namespace ConsoleApplication1.chap4
//{
//    class MemoryStreamEx
//    {
//        public static void Main()
//        {
//            //직렬화
//            byte[] shortByte = BitConverter.GetBytes((short)32000); //short 32000를 바이트 배열로 직렬화
//            byte[] intByte = BitConverter.GetBytes(16522300); //int 16522300을 바이트 배열로 직렬화

//            MemoryStream ms = new MemoryStream(); //바이트 배열을 읽고 쓰기 위해서 MemoryStream 객체 생성
//            ms.Write(shortByte, 0, shortByte.Length); //ms 객체에 shortByte 기록 (2바이트)
//            ms.Write(intByte, 0, intByte.Length); //ms 객체에 intByte 기록 (4바이트)

//            ms.Position = 0; //ms에 순서대로 저장된 바이트 배열들을 다시 읽어오기 위해서 포지션을 0으로 설정

//            //역직렬화
//            byte[] outByte = new byte[2];
//            ms.Read(outByte, 0, 2); //outByte에는 ms의 0~1 사이에 있는 값들을 읽어온다. position은 2로 이동
//            short shortResult = BitConverter.ToInt16(outByte, 0); //바이트 배열을 short로 변환
//            Console.WriteLine(shortResult); //32000 출력

//            outByte = new byte[4];
//            ms.Read(outByte, 0, 4); //outByte에는 ms의 2~5 사이에 있는 값들을 읽어온다. position은 5로 이동
//            int intResult = BitConverter.ToInt32(outByte, 0); //바이트 배열을 int로 변환
//            Console.WriteLine(intResult); //16522300 출력

//            byte[] arr = ms.ToArray(); //ms를 바로 바이트 배열로 변환 가능.

//            short shortResult2 = BitConverter.ToInt16(arr, 0); //arr의 0번부터 변환
//            Console.WriteLine(shortResult2); //32000 출력

//            int intResult2 = BitConverter.ToInt32(arr, 2); //arr의 2번부터 변환
//            Console.WriteLine(intResult2); //16522300 출력
//            //Byte 배열에는 Position 기능이 없으므로 변환하려는 바이트의 위치를 직접 지정해줘야 한다.
//        }
//    }
//}
