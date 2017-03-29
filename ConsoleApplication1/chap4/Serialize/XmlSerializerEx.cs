//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Serialization;

//namespace ConsoleApplication1.chap4
//{
//    public class Person //public 접근 제한자의 클래스여야 XmlSerializer를 쓸 수 있다.
//    {
//        public int age; //public 으로 선언된 프로퍼티만 직렬화/역직렬화가 가능하다.
//        public string name;
//        private int gender;

//        public Person() //기본 생성자를 포함하고 있어야 한다.
//        {
//        }

//        public Person(int age, string name, int gender)
//        {
//            this.age = age;
//            this.name = name;
//            this.gender = gender;
//        }

//        public override string ToString()
//        {
//            return string.Format("{0} {1}", this.age, this.name);
//        }
//    }
//    class XmlSerializerEx
//    {
//        public static void Main()
//        {
//            MemoryStream ms = new MemoryStream();
//            XmlSerializer xs = new XmlSerializer(typeof(Person)); //직렬화하려는 타입을 설정한다.

//            Person person = new Person(25, "Doh", 1);

//            //MemoryStream에 Person을 문자열로 직렬화.
//            xs.Serialize(ms, person); //public으로 선언한 age와 name만 직렬화된다.

//            ms.Position = 0;

//            Person clone = xs.Deserialize(ms) as Person;

//            Console.WriteLine(clone); //private으로 설정한 프로퍼티는 직렬화 되지 않아서 출력되지 않음.

//            byte[] buf = ms.ToArray();

//            Console.WriteLine(Encoding.UTF8.GetString(buf)); //Xml형식으로 된 문자열을 출력한다. 기본적으로 UTF-8 인코딩으로 객체를 문자열로 직렬화한다.
//            //XmlSerializer는 다른 플랫폼 사이에서 상호 운용성이 높다. 문제는 실제 전송되는 데이터에 비해 형식상 붙는 데이터가 많아서 크기가 커진다.
//        }
//    }
//}
