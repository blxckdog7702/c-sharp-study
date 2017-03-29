//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4
//{
//    class NullableEx
//    {
//        Nullable<bool> isGetMarried;
//        //bool? isGetMarried; 로 쓸 수 있다.

//        public Nullable<bool> IsGetMarried { get => isGetMarried; set => isGetMarried = value; }
//        //public bool? IsGetMarried { get => isGetMarried; set => isGetMarried = value; } 로 쓸 수 있다.

//        public static void Main()
//        {
//            NullableEx ne = new NullableEx();
//            ne.isGetMarried = null; //이상없음.

//            int? intValue = null;

//            //Value를 get 할 때,
//            //int target = intValue.Value;
//            int target = intValue.GetValueOrDefault();
//            //GetValueOrDefault()메서드를 쓰면 더 편하게 사용가능하다.
//            Console.WriteLine(target);

//            //알아서 set된다.
//            intValue = target;

//            double? temp = null;

//            //HasValue로 값이 있는지 없는지 알 수 있다.
//            Console.WriteLine(temp.HasValue);
//        }
//    }
//}
