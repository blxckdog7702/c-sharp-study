//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.FileDirectoryPath
//{
//    class FileStreamEx
//    {
//        public static void Main()
//        {
//            using (FileStream fs = new FileStream("test.log", FileMode.OpenOrCreate))//test.log라는 파일을 없으면 생성하고 있으면 연다.
//            {
//                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

//                sw.WriteLine("Hello World!");
//                sw.WriteLine("Blackdog!");
//                sw.WriteLine(32000);
//                sw.Flush();
//            }

//            using (FileStream fs = new FileStream("test2.log", FileMode.Append, FileAccess.Write, FileShare.None))
//            //test2.log라는 파일을 없으면 만들고 있으면 기존 내용에 덧붙인다.
//            //실행 횟수만큼 반복해서 뒤에 덧붙여진다.
//            //단어의 길이를 나타내는 바이트가 앞에 덧붙여지기 때문에 메모장으로 열면 그 바이트도 문자로 인식되어 메모장에서 보인다.
//            {
//                BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
//                bw.Write("Hello World!" + Environment.NewLine);
//                bw.Write("Blackdog" + Environment.NewLine);
//                bw.Write(32000); //32000도 2진 데이터로 변환되었다가 문자열로 취급당해서 } 로 출력된다.
//                bw.Flush();

//                //using (FileStream fs2 = new FileStream("test2.log", FileMode.Append, FileAccess.Write))
//                ////FileShare.None으로 설정된 블록 안에서 다시 그 파일을 접근하려 하면 
//                ////파일은 다른 프로세스에서 사용 중이므로 프로세스에서 액세스할 수 없습니다. 라는 System.IOException 예외 출력.    
//                //{

//                //}

//                Console.ReadLine();
//                //프로세스 중에 윈도우에 열어보기 위해 ReadLine으로 잠시 프로그램이 종료되는 것을 막는다.
//                //윈도우에서 접근 시, 다른 프로세스가 파일을 사용 중이기 때문에 프로세스가 액세스 할 수 없습니다. 라는 메시지가 출력된다.
//                //메모장에서 여는 건 Read이기 때문에 막힌다. FileShare.Write로 설정해도 역시 막힌다.
//                //FileShare.Read로 설정하고 메모장으로 열면 잘 열린다.
//            }

//            using (FileStream fs2 = new FileStream("test2.log", FileMode.Open, FileAccess.Write))
//            {
//                BinaryWriter bw = new BinaryWriter(fs2, Encoding.UTF8);
//                bw.Write("adf adfadf!" + Environment.NewLine); //open으로 했으므로 이 내용이 메모장 제일 앞에 덮어서 기록됨.
//                bw.Flush();
//            }

//            //using (FileStream fs2 = new FileStream("test2.log", FileMode.Append, FileAccess.ReadWrite)) 
//            ////Append는 쓰기 전용 모드에서만 사용 가능.
//            ////Argument Exception 발생
//            //{

//            //}


//        }
//    }
//}
