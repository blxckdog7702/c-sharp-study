//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Collection
//{
//    public class GenericStack<T> //제네릭 클래스, 형식 매개변수 이름은 임의지정 가능.
//    {
//        T[] objList;
//        int pos;

//        public GenericStack(int size)
//        {
//            objList = new T[size];
//        }

//        public void Push(T newValue)
//        {
//            objList[pos] = newValue;
//            pos++;
//        }

//        public T Pop()
//        {
//            pos--;
//            return objList[pos];
//        }
//    }

//    public class TwoGeneric<K, V> //2개 이상도 가능하다.
//    {
//        K key;
//        V value;

//        public void Set(K key, V value)
//        {
//            this.key = key;
//            this.value = value;
//        }
//    }

//    class GenericEx1
//    {
//        public static void Main()
//        {
//            GenericStack<int> intStack = new GenericStack<int>(10);
//            //CLR이 T에 대응되는 타입으로 대체해서 확장한다.

//            intStack.Push(1);
//            intStack.Push(2);
//            //intStack.Push("ㅁㅇㄹ"); 타입 에러가 난다.
//            intStack.Push(3);

//            Console.WriteLine(intStack.Pop());
//            Console.WriteLine(intStack.Pop());
//            Console.WriteLine(intStack.Pop());

//            WriteLog<int>(10);
//            WriteLog<bool>(true);
//            WriteLog<double>(20.158);
//            WriteLog<string>("logTest");

//        }

//        public static void WriteLog<T>(T item) //제네릭 메서드.
//        {
//            string output = string.Format("{0}: {1}", DateTime.Now, item);
//            Console.WriteLine(output);
//        }

//        //where 예약어를 이용해서 형식 매개변수의 제약조건을 정할 수 있다.
//        //T타입으로 지정된 item1,item2가 IComparable을 상속받은 타입이라고 가정하고 CompareTo를 호출 가능하게 한다.
//        //형식 매개변수의 수만큼 where 조건을 걸 수 있다.
//        public static T Max<T>(T item1, T item2) where T : IComparable
//        {
//            if (item1.CompareTo(item2) >= 0)
//            {
//                return item1;
//            }
//            else
//            {
//                return item2;
//            }
//        }

//        public class MyType<T> where T : ICollection, IConvertible //매개변수 2개에 제약조건을 건 경우
//        {

//        }

//        public class Dict<K, V> where K: ICollection
//                                where V: IComparable //이렇게 매개변수 각각에 제약조건을 걸 수 있다.
//        {

//        }

//        //Where T: struct : T 형식 매개변수는 반드시 값 형식만 가능하다.
//        //Where T: class : T 형식 매개변수는 반드시 참조 형식만 가능하다.
//        //Where T: new() : T 형식 매개변수의 타입에는 반드시 기본 생성자가 정의돼 있어야 한다.
//        //Where T: U : T 형식 매개변수는 반드시 U 형식 인수(사용자가 지정한 다른 형식 매개변수)에 해당하는 타입이거나, 상속을 받은 클래스만 가능하다.
//    }
//}
