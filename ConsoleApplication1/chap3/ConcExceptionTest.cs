//using System;


//namespace ConsoleApplication1
//{
//    class ConcExceptionTest
//    {


//        public static void Main()
//        {
//            //Dog dog = new Dog("검둥개");
//            //Dog dogException1 = new Dog("a");

//            Dog dogException2;

//            //Console.WriteLine(dog.Name); //검둥개가 출력된다.

//            //if (dogException1.Name == null)
//            //{
//            //    Console.WriteLine("dogException1.name : null");
//            //}

//            //if (dogException1 == null)
//            //{
//            //    Console.WriteLine("생성자에서 예외가 발생하면 그 객체는 할당되지 않습니다.");
//            //}

//            try
//            {
//                dogException2 = new Dog(null);
//                if (dogException2 == null)
//                {
//                    Console.WriteLine("생성자에서 예외가 발생하면 그 객체는 할당되지 않습니다.");
//                }
//                Console.WriteLine("이건 출력되나?");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }
//        }
//    }

//    class Dog
//    {
//        string name;

//        public Dog(String name)
//        {
//            //try
//            //{
//            //    if (name == "a")
//            //    {
//            //        throw new ArgumentException();
//            //        Console.WriteLine("실행되지 않는다.");
//            //    }
//            //    this.name = name;
//            //    Console.WriteLine("이름을 넣는다.");
//            //}
//            //catch (ArgumentException)
//            //{
//            //    Console.WriteLine("이름은 a가 될 수 없습니다.");
//            //}
//            //Console.WriteLine("무조건 실행된다.");

//            if (name == "a")
//            {
//                throw new ArgumentException();
//                Console.WriteLine("실행되지 않는다.");
//            }
//            this.name = name;
//            Console.WriteLine("이름을 넣는다.");
//        }

//        public string Name { get => name; set => name = value; }
//    }
//}