using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cs12_methods.Calculator
{
    class Calc
    {
        public static int Plus (int a, int b)
        { 
            return a + b; 
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    internal class Program
    {
        /// <summary>
        /// 실행시 메모리에 최초 올라가야 하기때문에 static이 되어야 하고
        /// 메서드 이름이 Main이면 실행될때 알아서 제일 처음에 시작된다.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int result = Calc.Plus(1, 2);
            // static은 최초실행때 메모리에 바로 올라가기 때문에
            // 클래스를 객체를 만들 필요가 없다 like new Calc();

            // Calc.Minus(3, 2);    Minus는 static이 아니기때문에 접근불가( 객체생성해야 접근가능)
            result = new Calc().Minus(3, 2);
            Console.WriteLine(result);

            int x = 13; int y = 3;
            Swap(ref x, ref y); // x, y가 가지고 있는 주소를 전달하라 Call by reference == pointer

            Console.WriteLine("x = {0}, y = {1}", x, y);

            Console.WriteLine(GetNumber());

            #region < out 매개변수 >

            int divid = 30;
            int divor = 2;
            int rem = 0;
            Divide(divid, divor, ref result, out rem);  // ref쓰든 out쓰든 결과차이 없음
            Console.WriteLine("나누기값 {0}, 나머지 {1}", result, rem);

            (result, rem) = Divide(20, 6);
            Console.WriteLine("나누기값 {0}, 나머지 {1}", result, rem);
            #endregion
            #region< 가변길이 매개변수 >

            int resSum = Sum(1, 3, 5, 7, 9);
            Console.WriteLine(resSum);

            #endregion


        }

        //static int Divide(int x, int y)
        //{
        //    return x / y; 
        //}
        //static int Reminder( int x, int y)
        //{
        //    return (x % y);
        //} // 매서드 두개 만들걸 아래처럼 하나로
        //static void Divide(int x, int y, ref int val, ref int rem)
        static void Divide(int x, int y, ref int val, out int rem)
        {
            val = x / y;
            rem = x % y;
        }

        static (int result, int rem) Divide(int x, int y)
        {
            return (x / y, x % y);  // C# 7.0
        }

        static (float result, float rem) Divide(float x, float y)
        {
            return (x / y, x % y);
        }

        // Main 메서드와 같은 레벨이 있는 메서드들은 전부 static이 되어야 함(무조건!)
        public static void Swap(ref int a, ref int b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
        }

        static int val = 100;
        public static ref int GetNumber()
        {
            return ref val; // static 메서드에 접근할 수 있는 변수는 static밖에 없음
        }

        public static int Sum(params int[] args)
        {
            int sum = 0;

            foreach (var item in args)
            {
                sum += item;
            }
            return sum;
        }
    }
}
