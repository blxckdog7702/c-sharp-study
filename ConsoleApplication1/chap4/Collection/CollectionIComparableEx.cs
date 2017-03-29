//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Collection
//{
//    class Person : IComparable //Person의 속성은 등번호와 이름이다.
//    {
//        int backNumber;
//        string name;

//        public Person()
//        {
//            this.backNumber = 0;
//            this.name = "무명";
//        }

//        public Person(int backNumber, string name)
//        {
//            this.backNumber = backNumber;
//            this.name = name;
//        }

//        public int BackNumber { get => backNumber; set => backNumber = value; }
//        public string Name { get => name; set => name = value; }

//        public int CompareTo(object obj) //CompareTo가 자동으로 호출되면서 비교작업을 수행한다.
//        {
//            Person person = obj as Person;

//            if (this.BackNumber > person.BackNumber) return -1;
//            else if (this.BackNumber == person.BackNumber) return 0;
//            else return 1;
//        }

//        public override string ToString()
//        {
//            return string.Format("{0}번 {1}", BackNumber, Name);
//        }
//    }

//    class CollectionIComparableEx
//    {
//        public static void Main()
//        {
//            ArrayList al = new ArrayList(); //ArrayList에 5개의 데이터를 입력한다.

//            al.Add(new Person(10, "강백호"));
//            al.Add(new Person(11, "서태웅"));
//            al.Add(new Person(4, "채치수"));
//            al.Add(new Person(14, "정대만"));
//            al.Add(new Person(7, "송태섭"));

//            al.Sort(); //안의 요소들이 IComparable을 구현하기 때문에 해당 요소의 CompareTo 메서드를 자동으로 호출해서 비교작업을 수행한다.

//            foreach (Person person in al)
//            {
//                Console.WriteLine(person); //등번호 내림차순으로 정렬되어 나온다.
//            }
//        }
//    }
//}
