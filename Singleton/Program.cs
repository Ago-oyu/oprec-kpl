using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankData Data1 = BankData.GetInstance();
            BankData Data2 = BankData.GetInstance();

            Console.WriteLine("Apakah Data1 sama dengan Data2");
            if (Data1 == Data2)
            {
                Console.WriteLine("Keduanya adalah objek yang sama");
            }
            else
            {
                Console.WriteLine("Berbeda");
            }
        }
    }
}