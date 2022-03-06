using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number");
            int number = int.Parse(Console.ReadLine());
            int counter=1;
            int sum=0;

            while(counter<=number){
                sum+=counter;
                counter++;
            }   

            Console.WriteLine(sum/number);

            char character='a';

            while(character<'z'){
                character++;
            }


            string[] cars = {"a","b","c"};


            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }


        }
    }
}