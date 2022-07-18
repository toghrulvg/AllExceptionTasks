//using System;
//using System.Collections.Generic;

//namespace ExceptionsPractise
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                //int a = 5;
//                //int b = 0;
//                //var result = a / b;

//                int[] arr = new int[3];
//                arr[7] = 8;



//            }
//            catch (Exception ex)
//            {

//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                Console.WriteLine("Handled Exception");
//            }

//            Divide(4, 2);


//            List<string> list = new List<string>() { "bir", "iki", "uc", "dord" };
//            string searchText = "bir";
//            FindName(list, searchText);



//        }

//        public static void Divide(int a, int b)
//        {
//            try
//            {
//                if (b == 2)
//                {
//                    throw new DivideExceptions("incorrect");
//                }
//                Console.WriteLine(a / b);

//            }
//            catch (Exception ex)
//            {

//                Console.WriteLine(ex.Message);
//            }
//        }

//        public static void FindName(List<string> names, string name)
//        {
//            try
//            {
//                //if (!names.Contains(name))
//                //{
//                //    throw new FindingName("no");
//                //}
//                //Console.WriteLine("yes");

//                var data = names.Find(m => m == name);
//                if (data is null) throw new FindingName("noo");
//                Console.WriteLine("varr");
//            }

//            catch (Exception ex)
//            {

//                Console.WriteLine(ex.Message);
//            }
//        }


//        class DivideExceptions : Exception
//        {
//            public DivideExceptions(string message) : base(message)
//            {

//            }

//        }

//        class FindingName : Exception
//        {
//            public FindingName(string message) : base(message)
//            {

//            }

//        }
//    }
//}