using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time<=18){
                Console.WriteLine("Hello");
            }
            else{
                Console.WriteLine("Good Night");
            }

            string result = time<=18 ? "Hi":"good evening";
            Console.WriteLine(result);


        }
    }
}