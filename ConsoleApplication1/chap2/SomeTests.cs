//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using testProj;

//namespace ConsoleApplication1
//{
//    struct Vector
//    {
//        public int x;
//        public int y;
//    }

//    interface A
//    {
//        //int a; //인터페이스는 프로퍼티 포함 불가.
//    }

//    abstract class B
//    {
//        int b; //추상클래스는 프로퍼티 포함 가능.
//    }

//    class SomeTests
//    {
//        enum EnumTest { Test = 1, }

//        public static void Main()
//        {

//            int[] arr = new int[5];

//            EnumTest enumTest = EnumTest.Test;

//            Type type = arr.GetType();
//            Console.WriteLine(type.IsClass); //배열은 IsClass 했을 때 true;

//            type = enumTest.GetType();
//            Console.WriteLine(type.IsClass); //열거형은 IsClass 했을 때 false;

//            Vector v = new Vector() { x = 1, y = 2 }; //이렇게 간단 초기화 가능
//            type = v.GetType();
//            Console.WriteLine(type.IsClass); //구조체는 IsClass 했을 때 false;


//            //----------------같은 값을 갖는 int와 short를 equals하면?            
//            int a = 256;
//            short b = 256;

//            Console.WriteLine(a.Equals(b)); //True 출력.
//            Console.WriteLine(b.Equals(a)); //False 출력.

//            //내부적으로 as 연산자로 형변환을 하기 때문에
//            //형변환이 되는 short -> int는 형변환 후 값을 비교해서 값이 같기 때문에 true.
//            //형변환이 되지 않는 int -> short는 as 연산 후 null 값을 리턴하기 때문에 false.
//        }
//    }
//}
