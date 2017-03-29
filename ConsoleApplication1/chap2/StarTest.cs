//using System;

//namespace ConsoleApplication1
//{
//    class StarTest
//    {
//        static void Main(string[] args)
//        {
//            int num;

//            Console.WriteLine("반복 횟수를 입력하세요.");

//            for (;;)
//            {
//                try
//                {
//                    num = Convert.ToInt32(Console.ReadLine());

//                    if (num <= 0)
//                    {
//                        Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
//                    }
//                    else
//                    {
//                        for (int i = 0; i < num; i++)
//                        {
//                            for (int j = 0; j < i + 1; j++)
//                            {
//                                Console.Write("*");
//                            }
//                            Console.WriteLine();
//                        }
//                        break;
//                    }
//                }
//                catch (FormatException)
//                {
//                    Console.WriteLine("정수값을 입력해주세요.");
//                }
//                catch (OverflowException)
//                {
//                    Console.WriteLine("int 범위의 값을 입력해주세요.");
//                }
//                Console.WriteLine("다시 입력해주세요.");
//            }
            
//            //for (int i = 0; i < num; i++)             //*****
//            //{                                       //****
//            //    for (int j = num; j > i; j--)         //***
//            //    {                                   //**
//            //        Console.Write("*");             //*
//            //    }
//            //    Console.WriteLine();
//            //}
//        }
//    }
//}
