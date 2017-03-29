//using System;

//namespace ConsoleApplication1
//{
//    class Animal
//    {
//        public void PrintSound()
//        {
//            Console.WriteLine("소리를 낸다.");
//        }

//        public void PrintSound(Dog dog) //개를 받으면 멍멍소리를 낸다.
//        {
//            Console.WriteLine(dog.Sound);
//        }

//        public void PrintSound(Cat cat) //고양이를 받으면 야옹소리를 낸다.
//        {
//            Console.WriteLine(cat.Sound);
//        }

//        public void PrintSound(Whale whale) //고래를 받으면 고래소리를 낸다.
//        {
//            Console.WriteLine(whale.Sound);
//        }
//    }

//    class Dog : Animal
//    {
//        string sound = "멍멍";

//        public string Sound { get => sound; set => sound = value; }
//    }

//    class Cat : Animal
//    {
//        string sound = "야옹";

//        public string Sound { get => sound; set => sound = value; }
//    }

//    class Whale : Animal
//    {
//        string sound = "고래고래";

//        public string Sound { get => sound; set => sound = value; }
//    }

//    class OverloadEx
//    {
//        public static void Main()
//        {
//            Animal animal = new Animal();
//            Dog dog = new Dog();
//            Cat cat = new Cat();
//            Whale whale = new Whale();

//            animal.PrintSound(); //소리를 낸다. 출력
//            animal.PrintSound(dog); //멍멍 출력
//            animal.PrintSound(cat); //야옹 출력
//            animal.PrintSound(whale); //고래고래 출력
//        }
//    }
//}
