using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "training"; // limitless
            
            byte b = 5;       // byte takes 1 byte from memory
            
            short sh = 10;    // short takes 2 byte from memory
            
            Int16 a = 5;      // 2 byte 
            
            int i = 2;        // 4 byte
            
            Int32 i32 = 5;    // 4 byte
              
            Int64 i64 = 5;    // 8 byte

            uint ui = 2;      // 4 byte

            long l = 20;      // 8 byte

            float f = 5;      // 4 byte

            double d = 0;     // 8 byte

            decimal dec = 20; // 16 byte  

            char c = 'x';     // 2 byte

            DateTime dt = DateTime.Now;

            object o1 = 2;
            object o2 = "asdasd";
            object o3 = 'a';

            bool control = true;

            string temp = "30";
            int temp1 = 20;

            string new_temp = temp + temp1.ToString();
            int temp3=  temp1 + Convert.ToInt32(temp);
            //Console.WriteLine(temp3);


        }
    }
}