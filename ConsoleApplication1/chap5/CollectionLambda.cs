using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.chap5
{
    class CollectionLambda
    {
        public static void Main()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            //ForEach 메서드를 이용해 간단하게 컬렉션에서의 연산 가능.
            //컬렉션에서 요소를 하나씩 꺼내서 element로 전달. Action<T> 연산 수행.
            list.ForEach((element) => { Console.WriteLine(element + " * 2 == " + (element * 2)); });

            Array.ForEach(list.ToArray(), (element) => { Console.WriteLine(element + " * 2 == " + (element * 2)); });

            //FindAll 메서드를 이용하면 특정 조건에 맞는 요소만 고를 수 있다.
            List<int> evenList = list.FindAll((element) => element % 2 == 0);
            evenList.ForEach(Console.WriteLine);

            //Count 메서드를 이용해서 특정 조건을 만족하는 요소들의 개수를 셀 수 있다.
            int count = list.Count((element) => element > 3);
            Console.WriteLine("3보다 큰 요소의 개수 : " + count);

            //public static IEnumerable<TSource> Where<TSource>(
            //this IEnumerable<TSource> source, Func< TSource, bool> predicate) 
            //Where 메서드는 IEnumerable<T> 인터페이스를 지원하는 모든 타입에 사용 가능하다.
            //predicate가 True를 리턴하는 요소만 모아서 IEnumerable<T>로 열거형을 반환한다.
            IEnumerable<int> enumList = list.Where((element) => element % 2 == 0);
            Array.ForEach(enumList.ToArray(), (element) => { Console.WriteLine(element); });

            var enumList2 = list.Where((element) => element % 2 == 1);
            enumList2.ToList<int>().ForEach(n => Console.WriteLine("홀수는 = " + n));

            //public static TSource FirstOrDefault<TSource>(
            //this IEnumerable<TSource> source)
            //FirstOrDefault 메서드는 조건식에 맞는 처음 요소를 찾는 경우에 사용한다. 
            //조건에 맞는 요소가 여러 개일 경우 첫 요소만 반환하며, 하나도 없을 경우는 기본값(보통 null)을 반환한다.
            List<string> stringList = new List<string>() { "Apple", "AOA", "Banana", "Grape" };
            var result = stringList.Where((element) => element.StartsWith("A")).FirstOrDefault();
            Console.WriteLine("A로 시작하는 첫 번째 요소는 : " + result);

            var result2 = stringList.Where((element) => element.StartsWith("C")).FirstOrDefault();
            //그냥 null로 체크하는 것 보다는 default(type)으로 체크하는게 더 안전하다.
            //밸류 타입의 경우는 null로 체크하면 에러를 반환한다.
            if (result2 == default(string))
            {
                Console.WriteLine("C로 시작하는 요소가 없습니다.");
            }
            else
            {
                Console.WriteLine("C로 시작하는 첫 번째 요소는 : " + result2);
            }
        }
    }
}
