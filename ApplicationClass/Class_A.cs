using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationClass
{
    class Class_A
    {
        public int Value1;
        public double Value2;
        public string Value3;
        public Class_A(int Value1, double Value2, string Value3)
        {
            this.Value1 = Value1;
            this.Value2 = Value2;
            this.Value3 = Value3;
        }
        public void Print()
        {
            Console.WriteLine(Value1);
            Console.WriteLine(Value2);
            Console.WriteLine(Value3);
        }

    }
}
