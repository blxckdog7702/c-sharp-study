//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Collection
//{
//    class BackNumberComparer : IComparer //IComparer를 구현하는 등번호 내림차순 정렬하는 클래스를 만든다.
//    {
//        public int Compare(object x, object y)
//        {
//            Person person1 = x as Person;
//            Person person2 = y as Person;

//            if (person1.BackNumber > person2.BackNumber) return -1;
//            else if (person1.BackNumber == person2.BackNumber) return 0;
//            else return 1;            
//        }
//    }

//    class Person //Person의 속성은 등번호와 이름이다.
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
//    }

//    class CollectionComparerEx
//    {
//        public static void Main()
//        {
//            ArrayList al = new ArrayList(); //ArrayList에 5개의 데이터를 입력한다.

//            al.Add(new Person(10, "강백호"));
//            al.Add(new Person(11, "서태웅"));
//            al.Add(new Person(4, "채치수"));
//            al.Add(new Person(14, "정대만"));
//            al.Add(new Person(7, "송태섭"));

//            al.Sort(new BackNumberComparer()); //BackNumberComparer를 인자로 전달한다.

//            foreach (Person person in al)
//            {
//                Console.WriteLine(person.BackNumber + "번 " + person.Name); //등번호 내림차순으로 정렬되어 나온다.
//            }
//        }
//    }
//}
