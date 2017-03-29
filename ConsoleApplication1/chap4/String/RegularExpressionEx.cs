//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Text.RegularExpressions;

//namespace ConsoleApplication1
//{
//    class RegularExpressionEx //정규 표현식을 위한 클래스이다.
//    {
//        public static void Main()
//        {
//            string email = "black개dog14@gmail.com";
//            string email2 = "blackdog14@★gmail.com";
//            Console.WriteLine(IsEmail(email)); //true
//            Console.WriteLine(IsEmail(email2)); //false
//            Console.WriteLine(isEmail2(email)); //true;
//            Console.WriteLine(isEmail2(email2)); //false;

//            string txt = "Hello World! Welcome to my world!";

//            Regex regex = new Regex("world", RegexOptions.IgnoreCase); //ignoreCase옵션을 넣어주면 대소문자 구분 없이 비교한다.
//            string result = regex.Replace(txt, "Universe");
//            Console.WriteLine(txt); //원래 문자열 출력
//            Console.WriteLine(result); //world가 Universe로 대체된 문자열 출력
//        }
//        //내가 생각한 이메일 규칙은 1. @문자를 반드시 한 번 포함한다.
//        //2. @ 이전의 문자열은 문자와 숫자만 허용한다.
//        //3. @ 이후의 문자열은 문자와 숫자만 허용하고 반드시 1번의 .문자를 포함한다.

//        public static bool IsEmail(string txt)
//        {
//            string[] parts = txt.Split('@');

//            if (parts.Length != 2) //@ 문자를 0번 포함하거나 2번 이상 포함하면 false 리턴
//            {
//                return false;
//            }

//            if (!isAlphaNumeric(parts[0])) //@ 문자 앞의 문자열이 문자나 숫자가 아니면 false 리턴
//            {
//                return false;
//            }

//            parts = parts[1].Split('.');
//            if (parts.Length != 2) //. 문자를 0번 포함하거나 2번 이상 포함하면 false 리턴
//            {
//                return false;
//            }

//            if (isAlphaNumeric(parts[0]) && isAlphaNumeric(parts[1])) //.문자 앞 뒤의 문자열들이 문자나 숫자가 아니면 false 리턴
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        public static bool isAlphaNumeric(string txt) //문자나 숫자인지 판별
//        {
//            foreach (char ch in txt)
//            {
//                if (!char.IsLetterOrDigit(ch))
//                {
//                    return false;
//                }
//            }
//            return true;
//        }

//        public static bool isEmail2(string txt) //정규식으로 표현
//        {
//            Regex regex = new Regex(@"([0-9a-zA-Z]+)@([0-9a-zA-Z]+)(\.[0-9a-zA-Z]+)$");

//            return regex.IsMatch(txt);
//        }
//    }
//}
