using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_2_app
{
    class Boiler
    {
        public string Brand;
        private int voltage;
        private int temperature;

        public int Voltage
        {
            get { return this.voltage; }
            set
            {
                if (value != 110 && value != 220)
                {
                    Console.WriteLine("전압 설정을 다시해주세요");
                    value = 0;
                }
                else
                {
                    this.voltage = value;
                }
            }
        }
        public int Temperature
        {
            get { return this.temperature; }
            set
            {
                if (value <= 5)
                {
                    value = 5;
                    this.temperature = value;
                }
                else if (value >= 70)
                {
                    value = 70;
                    this.temperature = value;
                }
                else
                {
                    this.temperature = value;
                }
            }
        }
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
