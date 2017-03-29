//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1
//{
//    delegate bool CompareDelegate(object arg1, object arg2); //비교 함수를 불러올 델리게이트

//    class SortObject
//    {
//        object[] things;

//        public SortObject() : this(null)
//        {
//        }

//        public SortObject(object[] things)
//        {
//            this.things = things;
//        }

//        public void Sort(CompareDelegate compareMethod) //델리게이트가 어떤 함수를 참조하냐에 따라서 정렬 기준이 달라진다.
//        {
//            object temp;

//            for (int i = 0; i < things.Length; i++)
//            {
//                int lowPos = i;

//                for (int j = i + 1; j < things.Length; j++)
//                {
//                    if (compareMethod(things[j], things[lowPos]))
//                    {
//                        lowPos = j;
//                    }
//                }

//                temp = things[i]; //스왑
//                things[i] = things[lowPos];
//                things[lowPos] = temp;
//            }
//        }

//        public void display()
//        {
//            Type type = things[0].GetType();
//            string typeName = type.Name;

//            if (typeName.Equals("Person")) //Person 객체 배열 출력
//            {
//                foreach (Person person in things)
//                {
//                    Console.WriteLine(person.Name + " " + person.Age);
//                }

//            }

//        }

//    }

//    class Person
//    {
//        string name;
//        int age;

//        public Person(string name, int age)
//        {
//            this.name = name;
//            this.age = age;
//        }

//        public string Name { get => name; set => name = value; }
//        public int Age { get => age; set => age = value; }
//    }

//    class SortProgram
//    {

//        public static bool DescByName(object arg1, object arg2) //이름 내림차순 정렬
//        {
//            Person person1 = arg1 as Person;
//            Person person2 = arg2 as Person;

//            return person1.Name.CompareTo(person2.Name) > 0; //1의 이름이 앞 : -, 1의 이름이 뒤 : +, 같음 : = 
//        }

//        public static bool DescByAge(object arg1, object arg2) //나이 내림차순 정렬
//        {
//            Person person1 = arg1 as Person;
//            Person person2 = arg2 as Person;

//            return person1.Age > person2.Age;
//        }


//        public static void Main()
//        {
//            Person[] personArray = new Person[] //비교를 실행할 사람 객체 배열
//            {
//                new Person("박도현", 24),
//                new Person("손의범", 25),
//                new Person("강윤구", 27),
//                new Person("검둥개", 4),
//                new Person("서태웅", 20)
//            };

//            SortObject sortObject = new SortObject(personArray);
//            sortObject.Sort(DescByName); //DescByName으로 하면 이름 내림차순으로 정렬.
//            sortObject.display();
//        }
//    }
//}
