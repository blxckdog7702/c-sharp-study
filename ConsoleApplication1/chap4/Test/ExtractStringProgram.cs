//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Test
//{
//    class ExtractStringProgram
//    {
//        public static string ExtractString(string source, string beginDelim, string endDelim)
//        {
//            bool isBeginDelimExisting = false; //beginDelim의 존재 여부 나타내는 변수
//            bool isEndDelimExisting = false; //endDelim의 존재 여부 나타내는 변수

//            int indexOfBeginDelim = 0; //beginDelim 첫번째 글자의 번호
//            int indexOfEndDelim = 0; //endDelim 첫번째 글자의 번호
//            int nextIndexOfBeginDelim = 0; //beginDelim 마지막 글자 다음 번호

//            try
//            {
//                //문자열의 처음부터 beginDelim을 찾을 때까지 비교 수행
//                for (int i = 0; i <= source.Length - beginDelim.Length; i++)
//                {
//                    if (source.Substring(i, beginDelim.Length).Equals(beginDelim))
//                    {
//                        isBeginDelimExisting = true;
//                        indexOfBeginDelim = i; //저장하고 break;
//                        break;
//                    }
//                }
//                if (!isBeginDelimExisting) return ""; //입력받은 beginDelim가 존재하지 않으면 "" 리턴


//                nextIndexOfBeginDelim = indexOfBeginDelim + beginDelim.Length; //beginDelim 마지막 글자 다음 번호 저장

//                //beginDelim 뒤부터 EndDelim을 찾을 때까지 비교 수행
//                for (int i = nextIndexOfBeginDelim; i <= source.Length - endDelim.Length; i++)
//                {
//                    if (source.Substring(i, endDelim.Length).Equals(endDelim))
//                    {
//                        isEndDelimExisting = true;
//                        indexOfEndDelim = i;  //저장하고 break;
//                        break;
//                    }
//                }
//                if (!isEndDelimExisting) return ""; //입력받은 endDelim가 존재하지 않으면 "" 리턴

//                //두 Delim 사이의 문자열 추출해서 리턴
//                return source.Substring(nextIndexOfBeginDelim, indexOfEndDelim - nextIndexOfBeginDelim);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//                return ""; //그 외 에러 발생 시 "" 리턴
//            }
//        }

//        public static void Main()
//        {
//            var code = ExtractString("실행중 문제가 발생했습니다. Error Code [20]", "[", "");

//            Console.WriteLine(code);

//            //var cmd = ExtractString("exec APP.COMMON.SET(NID=PN000101,CMD='ED-SYS::::1')", "CMD='", "'");

//            //Console.WriteLine(cmd);

//            //var cmd2 = ExtractString("나는 박도현입니다. 박도현입니까? ", "박", "?");

//            //Console.WriteLine(cmd2);
//        }
//    }
//}
