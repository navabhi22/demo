using System;

namespace FlipCoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the value for number of flips");
            //int flipCoin = Convert.ToInt32(Console.ReadLine());
            //FlipCoin.FlipTheCoin(flipCoin);

            //SwitchDemo.DisplayMonth();

            Console.WriteLine("enter the number");
            int N = Convert.ToInt32(Console.ReadLine());
            string num = EvenNumber.EvenNum(N);
            Console.WriteLine(num);
           
        }
    }
}