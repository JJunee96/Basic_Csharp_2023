using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cs09_nullconditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo myfoo = null;   // new Foo();
            //myfoo.member = 30;

            //int? bar;
            //if (myfoo != null)
            //{
            //    bar = myfoo.member;
            //}
            //else
            //{
            //    bar = null;
            //}
            
            int? bar = myfoo?.member;   // 위의 아홉줄(주석부분)을 모두 축약
        }
    }

    class Foo
    {
        public int member;
    }
}
