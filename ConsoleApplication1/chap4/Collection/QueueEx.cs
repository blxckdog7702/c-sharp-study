//using System;
//using System.Collections;

//namespace ConsoleApplication1.chap4.Collection
//{
//    class QueueEx
//    {
//        public static void Main()
//        {
//            Queue q = new Queue();

//            q.Enqueue(1); //매개변수를 object로 받기 때문에 박싱 발생.
//            q.Enqueue(2);
//            q.Enqueue(3);
//            q.Enqueue(4);

//            int last = (int)q.Dequeue(); //언박싱
//            Console.WriteLine(last); //1 출력.

//            q.Enqueue(5);

//            Console.WriteLine();
//            int[] copyArr = new int[5];
//            q.CopyTo(copyArr, 0); //2,3,4,5 복사.
//            Util.PrintIntArr(copyArr); //2,3,4,5,0 출력됨.

//            Console.WriteLine(q.Contains("강백호")); //false 출력

//            last = (int)q.Peek(); //맨 앞인 2를 삭제하지 않고 last에 저장.
//            Console.WriteLine(last); //2 출력.

//            Console.WriteLine();
//            object[] arr = q.ToArray();
//            Util.PrintObjectArr(arr); //2,3,4,5 출력

//            q.Clear();

//            Console.WriteLine();
//            arr = q.ToArray();
//            Util.PrintObjectArr(arr); //clear되었기 때문에 아무것도 출력하지 않는다.
//        }
//    }
//}
