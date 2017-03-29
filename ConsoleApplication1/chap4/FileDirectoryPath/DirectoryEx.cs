//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.FileDirectoryPath
//{
//    class DirectoryEx
//    {
//        public static void Main()
//        {
//            Directory.CreateDirectory("만들어볼까!");
//            //이미 경로에 똑같은 이름의 디렉토리가 존재하면 아무것도 안한다.
//            //Directory.CreateDirectory("만들어볼까?");
//            //'?' 때문에 System.ArgumentException: 경로에 잘못된 문자가 있습니다. 예외 출력.

//            //Directory.Delete("지워볼까!");
//            //경로에 존재하지 않는 디렉터리를 삭제할 경우 DirectoryNotFoundException 예외 출력.

//            Console.WriteLine(Directory.Exists("진짜있어!")); //true 출력.

//            string[] paths = Directory.GetDirectories("/");
//            //경로의 형식이 잘못된 경우  System.ArgumentException 예외 출력.
//            foreach (string path in paths) Console.WriteLine(path); //경로 내의 디렉터리 목록을 출력한다.  

//            Console.WriteLine();

//            string[] files = Directory.GetFiles("/");
//            foreach (string file in files) Console.WriteLine(file); //경로 내의 파일 목록을 출력한다.  

//            foreach (string txt in Directory.GetLogicalDrives()) Console.WriteLine(txt); //시스템에 설치된 디스크 드라이브의 문자 목록 출력.

//            //특정 폴더와 그 하위 폴더를 검색해서 파일 찾기
//            string targetPath = @"C:\Users\DH\Documents\Visual Studio 2015\Projects\ConsoleApplication1\ConsoleApplication1\bin\Debug";
//            foreach (string txt in Directory.GetFiles(targetPath, "*.???", SearchOption.AllDirectories)) Console.WriteLine(txt);
//            //검색하려는 파일명, 확장자와 맨 위 디렉토리만 검색할지, 그 하위도 검색할지 설정가능.
//        }
//    }
//}
