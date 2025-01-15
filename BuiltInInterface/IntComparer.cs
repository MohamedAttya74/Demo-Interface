using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.BuiltInInterface
{
    internal class IntComparer : IComparer
    {
        public int Compare(object? X, object? Y)
        {
           int? NumberX = (int?)X;
            int? NumberY = (int?)Y;
            
            
            return  - NumberX.Value.CompareTo(NumberY.Value);
        }
    }
}
