using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try{
            
                Console.Write("Please enter a number : ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number that you have entered : "+number);

            }
            catch(Exception ex){
                Console.WriteLine("Error : "+ex.Message.ToString());
            }
            finally{
                Console.WriteLine("Complated");
            }

            try{
                int a = int.Parse("test");  
            }
            catch(FormatException ex){
                Console.WriteLine("Format error !");
                Console.WriteLine(ex);
            }



        }
    }
}