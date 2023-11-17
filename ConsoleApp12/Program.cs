using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        public static int EnterNumber(string text)
        {
            Console.Write(text);
            int numF = Convert.ToInt32(Console.ReadLine());
            return numF;
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int numF = EnterNumber("Вкажіть число і вам виведе чи є це число в списку(10 - 99): ");

            int[] number = new int[100];
            int count = 1;

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(10, 100);

                if (number[i] == numF)
                {
                    count++;
                    Console.WriteLine("Ваше число знайдено!");
                }
            }
            Console.WriteLine("Воно повторюєься: " + count + " Разів!");
        }
    }
}
