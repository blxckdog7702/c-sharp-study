//using System;
//using System.Collections;

//namespace ConsoleApplication1.chap4.Collection
//{
//    class ArrayListEx
//    {
//        public static void Main()
//        {
//            ArrayList al = new ArrayList();

//            al.Add("Hello"); //박싱이 발생한다.
//            al.Add(6); //값 형식을 담으면 박싱이 발생하기 때문에 값 형식을 담기에는 적절치 않다. 대신 List<T>가 권장된다.
//            al.Add("World!");
//            al.Add(true);

//            int num = (int)al[1]; //언박싱

//            Console.WriteLine(al.Contains(6)); //6의 포함여부 검사. true.
//            Console.WriteLine(al.Contains("hello")); //대소문자 불일치 때문에 false.

//            al.Remove("World!"); //삭제하면 [3]에 있던 True가 자동으로 [2]로 온다.
//            Console.WriteLine(al[2]); //true.

//            al[2] = false;

//            Console.WriteLine(al[2]); //false;

//            Console.WriteLine("ArrayList내 모든 요소 출력");


//            foreach (object obj in al)
//            {
//                Console.WriteLine(obj);
//            }
//        }
//    }
//}
