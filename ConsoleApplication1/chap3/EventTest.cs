//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1
//{
//    //class CallbackArg { } //유연성을 위해 상속 구조를 만들어서 실행 메서드 내에서 다시 형변환 하는 방식.

//    class PrimeCallbackArgs : EventArgs //CallbackArg대신 닷넷에서 제공하는 EventArgs 상속.
//    {
//        public int prime;

//        public PrimeCallbackArgs(int prime)
//        {
//            this.prime = prime;
//        }
//    }

//    class PrimeGenerator //발행자 클래스.
//    {
//        //public delegate void PrimeDelegate(object sender, EventArgs arg);
//        //public event PrimeDelegate PrimeGenerated; //델리게이트를 정의하고 그 델리게이트를 위한 이벤트 정의가능.

//        public event EventHandler PrimeGenerated;
//        //닷넷에서 제공하는 EventHandler를 사용한 경우.

//        //콜백 메서드 추가/삭제하는 메서드. 이벤트를 사용하면 더 간결하게 쓸 수 있다.
//        //public void AddDelegate(PrimeDelegate callback)
//        //{
//        //    callbacks = Delegate.Combine(callbacks, callback) as PrimeDelegate;
//        //}

//        //public void RemoveDelegate(PrimeDelegate callback)
//        //{
//        //    callbacks = Delegate.Remove(callbacks, callback) as PrimeDelegate;
//        //}

//        public void Run(int limit)
//        {
//            for (int i = 2; i <= limit; i++)
//            {
//                if (IsPrime(i) == true && PrimeGenerated != null)
//                //이벤트 발생 조건과(여기에선 소수여부) 이벤트를 구독하는 구독자가 있는지 검사.
//                {
//                    PrimeGenerated(this, new PrimeCallbackArgs(i));
//                    //발행자 내부에서 이벤트 발생.
//                    //System.EventHandler는 두 개의 매개변수를 요구.
//                    //이벤트의 첫 번째 인자는 이벤트를 발생시킨 타입의 인스턴스.
//                    //이벤트의 두 번째 인자는 해당 이벤트에 속한 의미 있는 값.(여기에선 소수값)
//                }
//            }
//        }

//        private bool IsPrime(int candidate)
//        {
//            if ((candidate & 1) == 0)
//            {
//                return candidate == 2;
//            }

//            for (int i = 3; (i * i) <= candidate; i += 2)
//            {
//                if ((candidate % i) == 0) return false;
//            }

//            return candidate != 1;
//        }
//    }

//    class Program //구독자 클래스
//    {
//        static void PrintPrime(object sender, EventArgs arg)
//        {
//            Console.Write((arg as PrimeCallbackArgs).prime + ", ");
//        }

//        static int sum;

//        static void SumPrime(object sender, EventArgs arg)
//        {
//            sum += (arg as PrimeCallbackArgs).prime;
//        }

//        static void Main()
//        {
//            PrimeGenerator gen = new PrimeGenerator(); //이벤트 발행자 객체 행성. 이벤트 구독자는 현재 객체.
//            //gen.PrimeGenerated(this, new PrimeCallbackArgs(i)); //이벤트 선언 클래스 외에서 호출 시 에러.

//            //PrimeGenerator.PrimeDelegate callprint = PrintPrime;
//            //gen.AddDelegate(callprint);

//            //PrimeGenerator.PrimeDelegate callsum = SumPrime;
//            //gen.AddDelegate(callsum);
//            //이벤트를 쓰면 아래와 같이 코드를 줄일 수 있다.

//            //외부에서 구독/해지 가능
//            gen.PrimeGenerated += PrintPrime; //PrintPrime 메서드의 이벤트 등록
//            gen.PrimeGenerated += SumPrime; //SumPrime 메서드의 이벤트 등록

//            gen.Run(10);
//            Console.WriteLine();
//            Console.WriteLine(sum);

//            //gen.RemoveDelegate(callsum);
//            gen.PrimeGenerated -= SumPrime; //SumPrime 메서드의 이벤트 해지
//            gen.Run(15);
//        }
//    }
//}
