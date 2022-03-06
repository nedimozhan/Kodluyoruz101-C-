using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion 

            byte t1 = 1;
            ushort t2 = 2;
            short t3 = 3;

            int t4 = t1 + t2 + t3;
            Console.WriteLine(t4);

            long t5 = t4;

            float t6 = t5;

            Console.WriteLine(t6);

            // Explicit Conversion

            int x = 5;
            byte y = (byte)x;

            float f = 3.2f;
            byte ft = (byte)f;

            //
            int st = 45;
            String t10 = st.ToString();

            int newi = Convert.ToInt16(t10);




        }
    }
}