using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.InterfaceEx02
{
    internal class TypeD : ISeries
    {
        public int Currnt  { get; set; }
        public void GetNext()
        {
            Currnt += 4;
        }

    }
}
