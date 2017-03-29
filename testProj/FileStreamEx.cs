//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace testProj
//{
//    internal class Bee
//    {

//    }
//    class FileStreamEx
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Environment.CurrentDirectory);
//            Environment.CurrentDirectory = @"C:\Users\DH\Documents\Visual Studio 2015\Projects\ConsoleApplication1\ConsoleApplication1\bin\Debug";
//            Console.WriteLine(Environment.CurrentDirectory);

//            using (FileStream fs3 = new FileStream(Environment.CurrentDirectory + "\\test2.log", FileMode.Open, FileAccess.ReadWrite))
//            {
//                BinaryWriter bw = new BinaryWriter(fs3, Encoding.UTF8);
//                bw.Write("??" + Environment.NewLine);//프로세스 중에는 다른 프로세스에서 열리지 않는다.
//                bw.Flush();
//            }
//        }
//    }
//}
