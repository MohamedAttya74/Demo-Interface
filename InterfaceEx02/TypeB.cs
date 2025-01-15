using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.InterfaceEx02
{
    internal class TypeB : ISeries
    {


        public int Currnt { get; set; }
        //public int Currnt {
        //    get => throw new NotImplementedException(); 
        //    set => throw new NotImplementedException();
        //}

        public void GetNext()
        {
            Currnt += 2;
        }

      
    }
}
