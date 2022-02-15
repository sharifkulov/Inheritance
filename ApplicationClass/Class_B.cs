using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationClass
{
    class Class_B:Class_A
    {
        public Class_B(int Value1,double Value2, string Value3,int Value4):base(Value1,Value2, Value3)
        {
            this.Value1 = Value4;
        }
    }
}
