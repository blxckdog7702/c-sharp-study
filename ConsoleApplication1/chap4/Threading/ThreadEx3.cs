//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Threading
//{
//    class ThreadEx3
//    {
//        public static void Main()
//        {
//            Console.WriteLine("입력한 숫자까지의 소수 개수 출력 (종료: 'x' + Enter)");

//            while(true)
//            {
//                Console.WriteLine("숫자를 입력하세요.");
//                string userNumber = Console.ReadLine();

//                if(userNumber.Equals("x", StringComparison.OrdinalIgnoreCase) == true) //대소문자 관계없이 x입력 시 종료.
//                {
//                    Console.WriteLine("프로그램 종료");
//                    break;
//                }

//                Thread t = new Thread(CountPrimeNumbers); //소수 계산을 다른 쓰레드로 넘기면 중간에도 프로그램 종료 가능.
//                t.IsBackground = true; //t 쓰레드를 배경 쓰레드로 바꿔야 주스레드에서 프로세스 종료 가능.
//                t.Start(userNumber);
//            }
//        }

//        static void CountPrimeNumbers(object initialNumbers) //소수 개수 더해주는 메서드.
//        {
//            int primeCandidate = int.Parse((string)initialNumbers);

//            int totalPrimes = 0;

//            for (int i = 2; i < primeCandidate; i++)
//            {
//                if (Util.IsPrime(i) == true) totalPrimes++;
//            }

//            Console.WriteLine("숫자 {0}까지의 소수 개수? {1}", primeCandidate, totalPrimes);
//        }
//    }
//}
