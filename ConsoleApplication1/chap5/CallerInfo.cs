//using System;
//using System.Runtime.CompilerServices;

//namespace ConsoleApplication1.chap5
//{
//    class CallerInfo
//    {
//        public static void Main()
//        {
//            LogMessage("test");
//        }
//        //호출자 정보는 '호출하는 측의 정보'를 메서드의 인자로 전달하는 것이다.
//        //호출자 정보 특성이 명시된 매개변수는 선택적 매개변수 형식이여야 한다.
//        //컴파일 시점에 값이 치환되어 빌드된다.
//        static void LogMessage(string text, 
//            [CallerMemberName] string memberName = "", 
//            [CallerFilePath] string filePath = "", 
//            [CallerLineNumber] int lineNumber = 0)
//        {
//            Console.WriteLine("텍스트 : " + text); //"test" 출력
//            Console.WriteLine("이 메서드를 호출하는 메서드 이름" + memberName); //Main 출력
//            Console.WriteLine("호출 파일 경로" + filePath); //파일 경로 출력
//            Console.WriteLine("메서드가 호출된 라인 번호" + lineNumber); //10 출력
//        }
//    }
//}
