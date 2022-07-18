//using System;

//namespace LoginExceptionTask
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Login("username", 00000000);
//        }

//        public static void Login(string name, int pascode)
//        {
//            try
//            {
//                string n = "username";
//                int m = 00000000;

//                if (pascode == m && (name == n))
//                {
//                    throw new Account("Successfully logged in");
//                }
//                Console.WriteLine("Login failed");
//            }
//            catch (Exception ex)
//            {

//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//}