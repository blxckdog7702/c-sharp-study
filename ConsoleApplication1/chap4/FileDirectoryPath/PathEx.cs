//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1.chap4.FileDirectoryPath
//{
//class PathEx
//{
//    public static void Main()
//    {
//        string samplePath = @"C:\Users\DH\Documents\Visual Studio 2015\Projects\ConsoleApplication1\ConsoleApplication1\bin\Debug\testProj.exe";

//        Console.WriteLine(Path.ChangeExtension(samplePath, ".dll")); //testProj.exe를 .dll로 바꾼 문자열 리턴.
//        Console.WriteLine(Path.GetDirectoryName(samplePath));
//        //문자열에서 파일의 이름이 포함되어있으면 부모 디렉터리 리턴, 디렉터리만 포함되어있으면 그 부모 디렉터리 리턴.
//        Console.WriteLine(Path.GetFullPath("testProj.exe")); //해당 파일의 모든 경로 문자열 리턴.
//        Console.WriteLine(Path.GetFileName(samplePath)); //문자열에서 파일명 리턴.
//        Console.WriteLine(Path.GetFileNameWithoutExtension(samplePath));//문자열에서 확장자를 뺀 파일명 리턴.
//        Console.WriteLine(Path.GetExtension(samplePath)); //확장자만 리턴.
//        Console.WriteLine(Path.GetPathRoot(samplePath)); //루트 드라이브만 리턴

//        string filePath = Path.Combine(@"C:\temp", "test", "myfile.dat"); //각 디렉터리 명을 조합한 파일 경로 문자열을 리턴한다.
//        Console.WriteLine(filePath);

//        string newDirName = "my?new"; //폴더명에 ? 들어갈 수 없음.

//        int include = newDirName.IndexOfAny(Path.GetInvalidFileNameChars()); 
//        //GetInvalidFileNameChars는 디렉터리 명에 포함되면 안되는 문자들의 배열
//        //그 배열이 문자들이 새로 만들 폴더명에 포함되지 않으면 IndexOfAny() 메서드가 -1를 리턴. 그 외 숫자가 리턴되면 포함되있다는 뜻
//        if (include != -1)
//        {
//            Console.WriteLine("폴더명에 적합하지 않은 문자가 있음");
//        }

//        string createdTempFilePath = Path.GetTempFileName(); //임시 폴더에 임시 파일을 생성하고 그 경로 반환
//        Console.WriteLine(createdTempFilePath);

//        string tempFilePath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
//        //임시 폴더 경로와, 랜덤으로 임시 파일을 생성한 그 파일명과 combine해서 리턴한다.
//        Console.WriteLine(tempFilePath);
//    }
//}
//}
