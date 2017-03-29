//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Collection
//{
//    class StackEx
//    {
//        public static void Main()
//        {
//            Stack st = new Stack();

//            st.Push(1); //인자를 object로 다루기 때문에 박싱 발생
//            st.Push(2);
//            st.Push(3);
//            st.Push("강백호");
//            st.Push(7);

//            int last = (int)st.Pop(); //7제거하면서 last로 저장. 언박싱

//            st.Push(5);

//            last = (int)st.Peek(); //5 제거하지 않으면서 last로 저장. 언박싱

//            object[] arr = st.ToArray();
//            Util.PrintObjectArr(arr); //5, 강백호, 3, 2, 1 순으로 출력.  

//            st.Clear();
//            object[] arr2 = st.ToArray();
//            Util.PrintObjectArr(arr2); //clear() 해서 아무것도 없기 때문에 출력되는게 없다.
//        }
//    }
//}
