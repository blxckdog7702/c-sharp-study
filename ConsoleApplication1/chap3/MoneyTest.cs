//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1
//{
//    class Currency
//    {
//        decimal money;

//        public Currency(decimal money)
//        {
//            this.Money = money;
//        }

//        public decimal Money { get => money; set => money = value; }
//    }

//    class Won : Currency
//    {
//        public Won(decimal money) : base(money) { }

//        static public explicit operator Dollar(Won won) //원을 달러로 환전시 명시적 형변환만 가능.
//        {
//            return new Dollar(won.Money / 1154m); //1달러 = 1154원
//        }

//    }

//    class Dollar : Currency
//    {
//        public Dollar(decimal money) : base(money) { }

//        static public implicit operator Won(Dollar dollar) //달러를 원으로 환전시 암시적/명시적 형변환 가능.
//        {
//            return new Won(dollar.Money * 1154m); //1달러 = 1154원
//        }
//    }

//    abstract class Shape
//    {
//        public abstract void Draw(); //추상 메서드는 자식 클래스에서 구현해야만 함

//        public void Move() { Console.WriteLine("움직인다."); }
//    }

//    class Line : Shape
//    {
//        public override void Draw() //구현하지 않으면 에러발생
//        {
//            Console.WriteLine("선을 그린다.");
//        }
//    }

//    class Circle : Shape
//    {
//        public override void Draw() //구현하지 않으면 에러발생
//        {
//            Console.WriteLine("원을 그린다.");
//        }
//    }


//    class MoneyTest
//    {
//        public static void Main()
//        {
//            Dollar dollar1 = new Dollar(5); //5달러
//            Dollar dollar2 = new Dollar(10); //10달러
//            Won won1 = dollar1; //implicit로 선언하면 암시적 명시적 형변환 둘 다 가능.
//            Won won2 = (Won)dollar2;
//            Console.WriteLine(won1.Money);
//            Console.WriteLine(won2.Money);

//            Won won3 = new Won(1154);
//            Dollar dollar3 = (Dollar)won3; //explicit로 선언하면 명시적 형변환만 가능.
//            Console.WriteLine(dollar3.Money);
//        }

//    }
//}
