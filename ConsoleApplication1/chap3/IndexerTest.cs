//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1
//{
//    class IndexerEx
//    {
//        private const int MAX = 10;
//        private string name;

//        private int[] arr = new int[MAX];

//        public int this[int index] //int형으로 인덱스 지정
//        {
//            get
//            {
//                if (index < 0 || index >= MAX)
//                {
//                    throw new IndexOutOfRangeException();
//                }
//                else
//                {
//                    return arr[index]; //범위에 벗어나지 않으면 arr[] 배열에서 get
//                }
//            }
//            set
//            {
//                if (index < 0 || index >= MAX)
//                {
//                    throw new IndexOutOfRangeException();
//                }
//                else
//                {
//                    arr[index] = value; //범위에 벗어나지 않으면 arr[] 배열에 set
//                }
//            }
//        }
//    }

//    class Program
//    {
//        public static void Main()
//        {
//            IndexerEx ex = new IndexerEx();

//            ex[1] = 1024; //인덱서 set 사용

//            int i = ex[1]; //인덱서 get 사용
//        }
//    }
//}
