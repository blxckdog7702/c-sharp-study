//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace ConsoleApplication1.chap4.Test
//{
//    class SortAidProgram
//    {
//        static char[] alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

//        public static List<string> SortAidList(List<string> unsortedList)
//        {
//            unsortedList.Sort(); //맨 처음엔 문자열 기준으로 자동 정렬
//            //unsortedList.ForEach(Console.WriteLine);

//            int lowPos = 0; //swap을 위한 변수

//            for (int i = 0; i < unsortedList.Count; i++)
//            {
//                lowPos = i;

//                for (int j = i + 1; j < unsortedList.Count; j++)
//                {
//                    //'.' 이전의 문자열이 같은 문자열끼리 '.'뒤의 숫자비교
//                    if (ExtractStringProgram.ExtractString(unsortedList[i], "", ".")
//                        .Equals(ExtractStringProgram.ExtractString(unsortedList[j], "", ".")))
//                    {
//                        //j,lowPos가 가리키는 값을 담기 위한 변수
//                        int numOfj;
//                        int numOfLowPos;

//                        //'.'이후에 숫자만 있으면 바로 int로 형변환, 숫자와 문자가 섞여있다면 밑에서 ExtractString 이용해서 숫자만 추출
//                        bool isConvertiblej = int.TryParse(unsortedList[j].Split('.').ElementAt(1), out numOfj);
//                        bool isConvertibleLowPos = int.TryParse(unsortedList[lowPos].Split('.').ElementAt(1), out numOfLowPos);

//                        if (!isConvertiblej) numOfj = int.Parse(ExtractStringProgram.ExtractString(unsortedList[j], ".", "-"));
//                        if (!isConvertibleLowPos) numOfLowPos = int.Parse(ExtractStringProgram.ExtractString(unsortedList[lowPos], ".", "-"));

//                        //Console.WriteLine("numOfi = " + numOfi);
//                        //Console.WriteLine("numOfj = " + numOfj);
//                        //Console.WriteLine("numOfLowPos = " + numOfLowPos);

//                        //'.' 뒤에 나오는 숫자만 추출해서 비교
//                        if (numOfLowPos > numOfj) lowPos = j;
//                        else if (numOfLowPos == numOfj) //만약 추출한 숫자가 같다면
//                        {
//                            //"-C1" 꼴의 문자열이 붙는 요소 끼리만 비교
//                            if (unsortedList[lowPos].Contains("-") && unsortedList[j].Contains("-"))
//                            {
//                                //"-C1" 꼴에서 숫자만 추출
//                                int restNumOfLowPos = int.Parse(unsortedList[lowPos].Split('-').ElementAt(1).TrimStart(alpha));
//                                int restNumosj = int.Parse(unsortedList[j].Split('-').ElementAt(1).TrimStart(alpha));

//                                if (restNumOfLowPos > restNumosj) lowPos = j;
//                            }
//                        }
//                        //Console.WriteLine("losPos = " + lowPos);
//                        //Console.WriteLine();
//                    }
//                }
//                string temp = unsortedList[i]; //swap
//                unsortedList[i] = unsortedList[lowPos];
//                unsortedList[lowPos] = temp;

//                //unsortedList.ForEach(Console.WriteLine);
//                //Console.WriteLine();
//            }
//            return unsortedList;
//        }

//        //    public static void Main()
//        //    {
//        //        var unsorted = new List<string>();
//        //        unsorted.Add("TP6GC.9");
//        //        unsorted.Add("TP6GC.4");
//        //        unsorted.Add("TP3GC.1");
//        //        unsorted.Add("TP3GC.16");
//        //        unsorted.Add("TP3GC.10");
//        //        unsorted.Add("TP3GC.3");
//        //        unsorted.Add("TP3GC.1-C1");
//        //        unsorted.Add("TP3GC.1-C2");
//        //        unsorted.Add("TP3GC.3-C2");
//        //        unsorted.Add("TP3GC.3-C20");
//        //        unsorted.Add("TP3GC.3-C11");
//        //        unsorted.Add("TP3GC.3-C385");
//        //        unsorted.Add("TPXGU.5");
//        //        unsorted.Add("TPXGU.6");
//        //        unsorted.Add("TPXGU.5-W1");
//        //        unsorted.Add("TPXGU.6-W1");
//        //        unsorted.Add("TPXGU.6-C1");

//        //        var sortedList = SortAidList(unsorted);

//        //        sortedList.ForEach(Console.WriteLine); //출력
//        //    }
//    }
//}
