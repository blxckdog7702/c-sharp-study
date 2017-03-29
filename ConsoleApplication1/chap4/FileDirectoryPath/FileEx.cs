//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.Collection
//{
//    class FileEx
//    {
//        public static void Main()
//        {
//            File.Copy("복사전.txt", "복사후.txt"); //같은 폴더에 있는 복사전.txt를 복사후.txt로 복사한다.
//            //File.Copy("복사전.txt", "복사후.txt", true); //같은 폴더의 복사전.txt를 복사후.txt로 덮어쓴다.
//            //복사후.txt 파일이 있으면 System.IO.IOException: '복사후.txt' 파일이 이미 있습니다. 예외 출력
//            Console.WriteLine(File.Exists("복사전.txt")); //폴더 내에 복사전.txt가 존재하므르 true 없으면 false.

//            File.Move("복사후.txt", "..\\이동후.txt"); //상위 폴더에 이동후.txt라는 이름으로 바뀌어서 이동한다.
//            File.Move("복사후.txt", "이동후.txt"); //폴더가 동일하면 파일명 변경.
//            string target = "타겟.txt"; //Move 메서드는 덮어쓰기 같은 옵션이 없으므로 다음과 같이 덮어쓰기를 구현 가능.
//            if (File.Exists(target) == true)
//            {
//                File.Delete(target);
//            }
//            File.Move("전타겟.txt", target);

//            //이미 그 경로에 있으면, System.IO.IOException: 파일이 이미 있으므로 만들 수 없습니다. 예외 출력.
//            byte[] arr = File.ReadAllBytes("복사전.txt");
//            Util.PrintByteArr(arr); //복사전.txt를 읽어서 byte 배열로 출력.
//            Console.WriteLine(Encoding.UTF8.GetString(arr)); //test라는 내용 출력.

//            string[] txtArr = File.ReadAllLines("ReadAllLinesTest.txt", Encoding.Default); //줄마다 string 하나씩으로 배열에 들어간다.
//            foreach (string txtLine in txtArr) Console.WriteLine(txtLine); //모두 출력.

//            string txt = File.ReadAllText("ReadAllLinesTest.txt", Encoding.Default); //모든 텍스트가 string 하나에 들어간다.
//            Console.WriteLine(txt);

//            File.WriteAllBytes("바이트배열복사후.txt", arr); //그대로 test로 복사됨.

//            File.WriteAllLines("WriteAllLineTest.txt", txtArr);  //1줄 2줄 3줄 4줄 5줄 내용 모두 복사 됨.

//            File.WriteAllText("WriteAllTextTest.txt", txt); //1줄 2줄 3줄 4줄 5줄 내용 모두 복사 됨.

//            string c20Text = new string('c', 20); //c x 20개의 문자열 생성
//            File.WriteAllText("씨이십개.txt", c20Text);

//            string clone = File.ReadAllText("씨이십개.txt");
//            Console.WriteLine(clone);

//            //FileInfo 타입은 File 타입의 기능을 인스턴스 멤버로 일부 구현함.용법은 같다.
//            //FileInfo source = new FileInfo("소스.txt"); 로 소스 설정하고 사용하면 된다.


//        }
//    }
//}
