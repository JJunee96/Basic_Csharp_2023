using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dicNumbers = new Dictionary<string, string>();
            dicNumbers["red"] = "빨간색";
            dicNumbers["orange"] = "주황색";
            dicNumbers["yellow"] = "노란색";
            dicNumbers["green"] = "초록색";
            dicNumbers["blue"] = "파란색";
            dicNumbers["indigo"] = "남색";
            dicNumbers["purple"] = "보라색";

            RanbowColor();
            //KeyValueChk("보라색");

            void RanbowColor()
            {
                Console.Write("무지개 색은 ");
                foreach (string i in dicNumbers.Values)
                {
                    Console.Write(i + ", ");
                }
                Console.WriteLine("입니다.");
            }
            
            //void KeyValueChk(string key)
            //{
            //    Console.WriteLine("Key와 Value확인");
            //    Console.WriteLine(key + "는" + dicNumbers[key] + "입니다.");
            //}


        }
    }
}
