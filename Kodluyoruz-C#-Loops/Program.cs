using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            Console.Write("Please enter a number");
            int number = int.Parse(Console.ReadLine());


            for (int i = 0; i < number; i++)
            {
                if(i%2==1){
                    Console.WriteLine(i);
                }
            }

            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 0; i < 1000; i++)
            {
                if(i%2==1){
                    sumOdd += i;
                }
                else{
                    sumEven += i;
                }
            }

            Console.WriteLine("sum odd : "+sumOdd);
            Console.WriteLine("sum even : "+sumEven);


            for (int i = 0; i < 10; i++)
            {
                if(i==4){
                    continue;
                }
            }




        }
    }
}