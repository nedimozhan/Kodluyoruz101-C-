using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            
            int x=5;
            int y=3;
            Console.WriteLine(x);
            x+=2;
            Console.WriteLine(x);
            y+=x;
            Console.WriteLine(y);

            bool success=true;
            bool isComplated=false;

            if(isComplated && success){
                Console.WriteLine("Perfect");
            }

            if(isComplated || success){
                Console.WriteLine("Great");
            }

            int a = 5;
            int b = 6;

            bool result = a>b;
            Console.WriteLine(result);
        }
    }
}