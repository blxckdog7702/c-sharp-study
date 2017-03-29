//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1
//{
//    struct Vector
//    {
//        int x;
//        int y;

//        public Vector() //매개변수 없는 생성자 정의 불가. (에러)
//        {
//        }

//        public Vector(int x) //모든 필드에 값을 할당해야 한다.(에러)
//        {
//            this.x = x;
//        }

//        public Vector(int x, int y) //매개변수 있는 생성자는 정의 가능.
//        {
//            this.x = x;
//            this.y = y;
//        }
//    }

//    class Program
//    {
//        Vector vec = new Vector(); //속성값 0으로 초기화.
//        Vector vec2; //이것도 선언 가능.
//    }
//}
