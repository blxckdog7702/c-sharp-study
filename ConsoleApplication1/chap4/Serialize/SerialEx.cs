//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4
//{
//    class SerialEx
//    {
//        public static void Main()
//        {
//            //기본 타입을 바이트 배열로 변환
//            byte[] boolBytes = BitConverter.GetBytes(true);
//            byte[] shortBytes = BitConverter.GetBytes((short)32000);
//            byte[] intBytes = BitConverter.GetBytes((int)16661151);
//            //바이트 배열을 다시 기본 타입으로 복원
//            bool boolResult = BitConverter.ToBoolean(boolBytes, 0);
//            short shortResult = BitConverter.ToInt16(shortBytes, 0);
//            int IntResult = BitConverter.ToInt32(intBytes, 0);
//            //복원 확인
//            Console.WriteLine(boolResult.ToString()); //true 출력
//            Console.WriteLine(shortResult.ToString()); //32000 출력
//            Console.WriteLine(IntResult.ToString()); // 16661151 출력

//            //바이트 배열을 16진수 문자열로 표현
//            Console.WriteLine(BitConverter.ToString(boolBytes)); //BitConverer 후, 출력 값이 엔디안 방식에 따라 바뀔 수 있다.
//            Console.WriteLine(BitConverter.ToString(shortBytes));
//            Console.WriteLine(BitConverter.ToString(intBytes));

//            int n = 1652300;
//            string text = n.ToString(); // int를 string으로 직렬화.

//            int result = int.Parse(text); // string을 int로 역직렬화.
//            Console.WriteLine(result); // 이 경우에는 직렬화 수단이 바이트 배열이 아닌 문자열이 된 것.
//        }
//    }
//}
