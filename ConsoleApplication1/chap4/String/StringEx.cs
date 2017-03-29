//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1
//{
//    class StringEx
//    {
//        public static void Main()
//        {
//            string txt = "Hello World!";
//            string[] stringArr;

//            Console.WriteLine(txt.Contains("Hello")); //true
//            Console.WriteLine(txt.Contains("WORLD")); //false

//            Console.WriteLine(txt.EndsWith("rld!")); //true
//            Console.WriteLine(txt.EndsWith("Hello")); //false
//            //Console.WriteLine(txt.EndsWith("world!", StringComparison.OrdinalIgnoreCase)); //StringComparison.OrdinalIgnoreCase를 지정하면 대소문자 구분 안함

//            Console.WriteLine(txt.GetHashCode()); //해시값 반환  
//            Console.WriteLine("Hello World!".GetHashCode()); //이렇게 해도 똑같은 값 반환.


//            Console.WriteLine(txt.IndexOf("World!")); //해당 문자열 포함 시 그 문자열의 인덱스 리턴, 아니면 -1
//            Console.WriteLine(txt.IndexOf("Dog")); // -1
//            Console.WriteLine(txt.IndexOf("world!", StringComparison.OrdinalIgnoreCase)); //StringComparison.OrdinalIgnoreCase를 지정하면 대소문자 구분 안함, 인덱스 리턴

//            Console.WriteLine(txt.Replace("World", "c#")); //앞 문자열을 뒷 문자열로 대체 후 전체 리턴 Hello c#! 출력

//            stringArr = txt.Split('o'); //'o'를 기준으로 나눈 문자열들을 배열로 리턴
//            OutputArrayString(stringArr);// "Hell", " W", "rld!" 출력

//            Console.WriteLine(txt.StartsWith("Hel")); //true
//            Console.WriteLine(txt.StartsWith("hel")); //false
//            Console.WriteLine(txt.StartsWith("hel", StringComparison.OrdinalIgnoreCase)); //true

//            Console.WriteLine(txt.Substring(4)); //4번째부터 끝까지 출력. "o World!" 출력
//            Console.WriteLine(txt.Substring(4, 2)); //4번째부터 길이 2만큼 "o " 출력
//            //Console.WriteLine(txt.Substring(4, 50)); //ArgumentOutOfRangeException 발생

//            Console.WriteLine(txt.ToLower()); //소문자 변환 후 리턴
//            Console.WriteLine(txt.ToUpper()); //대문자 변환 후 리턴
//            Console.WriteLine(txt); //변환 내용이 유지되는 것은 아니다. 그대로 Hello World! 출력

//            Console.WriteLine(txt.Trim('!', 'H')); //문자열의 앞뒤에 해당 문자가 있으면 삭제, 매개변수 입력하지 않으면 앞뒤에 있는 공백 삭제

//            Console.WriteLine(txt.Length); //문자열의 길이 리턴, 12

//            Console.WriteLine(txt != "Hello World!"); //false
//            Console.WriteLine(txt == "Hello World!"); //true;

//            Console.WriteLine(txt[4]); //해당 위치에 있는 문자 반환

//            Console.WriteLine(txt == "Hello World!"); //true ==연산자는 대소문자를 구분한다.
//            Console.WriteLine(txt == "hello world!"); //false
//            Console.WriteLine(txt.Equals("hello world!", StringComparison.OrdinalIgnoreCase)); //Equals 메서드도 대소문자를 구분하지만, 구분하지 않게 따로 설정이 가능하다.

//            int a = 100;
//            int b = 50;
//            int formatInt = 123456;
//            double formatDouble = 123546.789;

//            string formatTxt = String.Format("A의 값은 {0}입니다. B의 값은 {1}이구요, 이 둘을 더한 값은 {2}입니다.", a, b, a + b);
//            Console.WriteLine(formatTxt);
//            //formatTxt = String.Format("A의 값은 {0}입니다. B의 값은 {1}이구요, 이 둘을 더한 값은 {2}입니다. 뺀 값은 {3}입니다", a, b, a + b);
//            //매개변수 개수보다 인덱스가 더 많으면 예외 발생.

//            //인덱스[, 정렬][:형식] 순으로 지정한다. //정렬은 양수면 우측, 음수면 좌측 정렬을 한다.
//            Console.WriteLine("정수 형식 : {0,20:d10}", formatInt); //정수 형식. 123456에 10자리를 맞추기 위해 0000123456이 출력된다.
//            Console.WriteLine("숫자 형식 : {0,20:n10}", formatDouble); //숫자 형식. 123456.789에 .789를 포함해서 10자리 소수점이 맞춰진다.
//            Console.WriteLine("퍼센트 형식 : {0,-20:p3}", a); //백분율 형식.100으로 곱하고 백분율 기호와 함께 표시된다. p뒤의 숫자는 소수점 자리수를 의미한다.
//            Console.WriteLine("16진수 형식 : {0,-20:x10}", formatInt); //16진수 형식. 10자리를 맞추기 위해 앞에 0이 표시된다. 
//            Console.WriteLine("날짜/시간 형식 : {0,-20:F}", DateTime.Now);



//        }

//        private static void OutputArrayString(string[] arr)
//        {
//            foreach (string txt in arr) Console.WriteLine(txt);
//        }
//    }
//}
