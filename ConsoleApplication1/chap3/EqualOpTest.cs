using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
//class EqualOpTest
//{
//    public static void Main()
//    {
//        string s1 = "검둥개";
//        string s2 = "검둥개";
//        string s3 = s1;

//        if (s1.Equals(s2)) Console.WriteLine("Equals1같음."); //출력
//        if (s1.Equals(s3)) Console.WriteLine("Equals2같음."); //출력

//        if (s1 == s2) Console.WriteLine("==같음1"); //출력 //string의 ==는 equals를 호출하기 때문에 equals와 기능적인 차이는 없다.
//        if (s1 == s3) Console.WriteLine("==같음2"); //출력

//        Dog dog1 = new Dog(10);
//        Dog dog2 = new Dog(10);
//        Dog dog3 = dog1;

//        if (dog1.Equals(dog2)) Console.WriteLine("dog1,dog2 equal."); //출력X //스택값이 다르기 때문에
//        if (dog1.Equals(dog3)) Console.WriteLine("dog1,dog3 equal."); //출력 //스택값이 같으므로

//        if (dog1 == dog2) Console.WriteLine("dog1,dog2 ==."); //출력X
//        if (dog1 == dog3) Console.WriteLine("dog1,dog3 ==."); //출력O

//        // == 연산자는 같은 형의 기본형에 대한 비교를 위한 연산자로서 양쪽의 자료형이 다르면 컴파일 단계에서 연산자 에러가 난다.
//        // Equals 메서드는 2개의 기본형이나 객체에 대한 비교를 수행하는 형으로서 2개의 형이 다르면 비교시 에러가 나지 않고, 형이 동일할 경우 값이 일치 여부까지 비교한다.
//    }
//}

//class Dog
//{
//    int age;

//    public Dog(int age)
//    {
//        this.age = age;
//    }

//    public override bool Equals(object obj)
//    {
//        Dog d = obj as Dog;
//        if ((object)d == null)
//        {
//            return false;
//        }

//        return base.Equals(obj) && age == d.age;
//    }

//    public int Age { get => age; set => age = value; }
//}
}
