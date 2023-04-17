using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_1_app
{
    class Boiler
    {
        public string Brand;
        public int Voltage;
        public int Temperature;


        public void PrintAll()
        {
            Console.WriteLine(Brand);
            Console.WriteLine(Voltage);
            Console.WriteLine(Temperature);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler
            {
                Brand = "귀뚜라미",
                Voltage = 200,
                Temperature = 45
            };
            kitturami.PrintAll();
        }
    }
}
