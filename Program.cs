using System;

namespace UserDefinedException
{
    class Addition
    {
         public void sum()
        {
            int a = 0, b = 0;
            int sum = 0;
            Console.WriteLine("Enter First Operand");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Operand");
            b = Convert.ToInt32(Console.ReadLine());
          


            try
            {
                if (b == 0 || b >1000)
                {
                    Console.WriteLine("second variable must be greater than zero or less than 10000");
                }
                else {
                    sum = a + b;
                    
                }
            }
            catch(SecondNumbercannotBeZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(" Addition is{0}", sum);
            }
            finally 
            {

                Console.WriteLine(" Addition is{0}",sum);
            }



        }
    }
    public class SecondNumbercannotBeZeroException : ApplicationException
    {
        public  SecondNumbercannotBeZeroException(string message):base(message)
            {
            
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Addition add = new Addition();
            add.sum();
        }
    }
}
