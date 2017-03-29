//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Json;
//using System.IO;

//namespace ConsoleApplication1.chap4
//{
//    [DataContract] //직렬화하려는 클래스에 표시. public으로 선언되어 있으면 꼭 표시해주지 않아도 된다.
//    class Person //직렬화 대상 클래스의 접근 제한에 영향을 받는다. 다른 클래스의 inner 클래스가되서 private되면 예외가 발생한다.
//    {            //inner 클래스가 됐어도 [DataContract],[DataMember] 특성을 정의해주면 직렬화가 가능하다. 그 외 접근이 가능한 상황에서는 명시적으로 선언하지 않아도 작동한다.
//        [DataMember]
//        public int age;
//        [DataMember] //[DateContract]를 선언했을 때, [DataMember]를 선언하지 않으면 직렬화되지 않는다.
//        public string name;
//        [DataMember]
//        private int gender; //private은 직렬화되지 않는다.

//        public Person()
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

//    public class JsonSerializerEx
//    {
//        public static void Main()
//        {
//            DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(Person)); //참조관리자를 통해서 System.Runtime.Serialization 추가해야 사용가능.  

//            MemoryStream ms = new MemoryStream();

//            Person person = new Person(25, "Doh", 1);

//            dcjs.WriteObject(ms, person);

//            ms.Position = 0;

//            Person clone = dcjs.ReadObject(ms) as Person;

//            Console.WriteLine(clone);

//            byte[] arr = ms.ToArray();

//            Console.WriteLine(Encoding.UTF8.GetString(arr)); //{"age":25,"gender":1,"name":"Doh"}를 출력한다. 기본적으로 UTF-8로 인코딩하기 때문에
//                                                             //읽기 위해서 UTF-8로 인코딩한다.
//        }
//    }
//}

