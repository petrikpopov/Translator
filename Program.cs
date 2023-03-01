using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _28._02._2023HM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Dictionary<string, string> translator = new Dictionary<string, string>();
            Dictionary<string, string> translator1 = new Dictionary<string, string>();
            translator.Add("Бразилия", "Brazil");
            translator.Add("Болгария", "Bulgaria");
            translator.Add("Италия", "Italy");
            translator.Add("Украина","Ukraine");
            translator.Add("Мальдивы", "Maldives");
            //////////////////////////////////////
            translator1.Add("Brazil", "Бразилия");
            translator1.Add("Bulgaria","Болгария");
            translator1.Add("Italy", "Италия");
            translator1.Add("Ukraine", "Украина");
            translator1.Add("Maldives", "Мальдивы");
            Console.WriteLine("1)Перевести на английский\t2)Перевести на русский");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите название страны которую хотите перевести:");
            string Enter = Convert.ToString(Console.ReadLine());
            if (A==1)
            {
                if (translator.ContainsKey(Enter))
                {
                    Console.WriteLine(Enter + "-------->" + translator[Enter]);
                }
                else
                {
                    Console.WriteLine("Такой страны нету в списке!!!");
                }
            }
            if (A==2)
            {
                if (translator1.ContainsKey(Enter)) 
                {
                    Console.WriteLine(Enter+"-------->"+translator1[Enter]);
                }
                else
                {
                    Console.WriteLine("Такой страны нету в списке!!!");
                }
            }
            
            
        }
    }
}
