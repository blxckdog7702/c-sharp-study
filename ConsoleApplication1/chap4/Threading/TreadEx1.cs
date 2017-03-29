//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Threading
//{
//    class TreadEx1
//    {
//        public static void Main()
//        {
//            Thread thread = Thread.CurrentThread;
//            Console.WriteLine(thread.ThreadState); //현재 스레드의 상태를 리턴한다.

//            Console.WriteLine(DateTime.Now);
//            Thread.Sleep(1000); //1초간 멈춤
//            Console.WriteLine(DateTime.Now); //1초 차이가 나게 출력된다.

//            //스레드 생성  
//            Thread t = new Thread(ThreadFunc); //스레드에 실행될 메서드 이름(대리자)를 집어넣는다.
//                                               //t라는 스레드는 시작되면 ThreadFunc를 실행한다.

//            t.IsBackground = true;
//            //t가 배경스레드가 되면 ThreadFunc로 넘어가기 전에(엄밀히 말하면 넘어가는 동안) Main() 함수가 끝나고 프로세스가 종료된다.
//            //t 스레드가 운영체제의 스케쥴러에 선택되기 전에 주 스레드가 종료되었기 때문에 이런 현상이 발생한다.
//            //배경 스레드는 실행종료에 영향을 미치지 않는다. 그렇기 때문에 주 스레드가 종료되면 프로세스가 종료된다.
//            //실행 종료에 영향을 미치는 것은 전경 스레드(foreground thread)이다.
//            t.Start();
//            //더이상 실행할 명령어가 없으므로 주 스레드 종료.

//            //t.Join(); //t t스레드의 실행이 끝날 때 까지 주 스레드는 기다리게 된다.
//            //Console.WriteLine("주 스레드 종료!");
//        }

//        static void ThreadFunc()
//        {
//            Console.WriteLine("ThreadFunc가 동작합니다!");
//            //이 명령어가 끝나면 t 스레드 종료. 실행중인 스레드가 하나라도 있으면 프로세스는 종료되지 않는다.
//        }
//    }
//}
