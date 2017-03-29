//using System;
//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;

//namespace ConsoleApplication1.chap4
//{
//    [Serializable] //Serializable 특성을 지정하면 사용자 정의 클래스 직렬화를 간편하게 할 수 있다.
//    class Person
//    {
//        [NonSerialized]     //Serializable 특성은 기본적으로 클래스 내 모든 프로퍼티를 대상으로 직렬화를 수행한다.
//        public int age;     //직렬화를 원치 않는 프로퍼티는 NonSerialized 특성을 지정하면 된다..

//        public string name;

//        private int gender; //private으로 선언하면 직렬화되지 않음.

//        public Person(int age, string name, int gender)
//        {
//            this.age = age;
//            this.name = name;
//            this.Gender = gender;
//        }

//        public int Gender { get => gender; set => gender = value; }

//        public override string ToString()
//        {
//            return string.Format("{0} {1}", this.age, this.name);
//        }
//    }

//    class BinaryFormatterEx
//    {
//        public static void Main()
//        {
//            Person person = new Person(25, "Doh", 1);

//            BinaryFormatter bf = new BinaryFormatter();
//            MemoryStream ms = new MemoryStream();
//            bf.Serialize(ms, person);

//            ms.Position = 0;

//            Person clone = bf.Deserialize(ms) as Person;

//            Console.WriteLine(clone); //age에 NonSerialized를 지정하면 0으로 출력, 지정하지 않으면 입력한 그대로 25 출력.

//            byte[] arr = ms.ToArray(); //이 바이트 배열을 네트워크를 통해 다른 컴퓨터로 전송 후 다시 역직렬화 가능.
//                                       //다만 직렬화 방식이 닷넷 내부에 고유하게 정의되어서 다른 플랫폼에서는 역직렬화 불가.
//            Util.PrintByteArr(arr);
//        }
//    }
//}
