//using System;

//namespace ConsoleApplication1
//{
//    static class StaticConcTest
//    {
//        public static void Main()
//        {
//            Dog dog1 = new Dog(); //static, 일반 생성자 모두 호출

//            Dog dog2 = new Dog(); //일반 생성자만 호출
//        }
//    }

//    public class Dog
//    {
//        static bool firstDogCreated = false;

//        static Dog()
//        {
//            Console.WriteLine("static 생성자");
//            firstDogCreated = true;
//            Console.WriteLine(firstDogCreated);
//            Console.WriteLine("첫 번째 개가 태어났습니다.");
//        }

//        public Dog()
//        {
//            firstDogCreated = true;
//            Console.WriteLine("일반 생성자");
//            Console.WriteLine("개가 태어났습니다.");
//        }
//    }
//}
