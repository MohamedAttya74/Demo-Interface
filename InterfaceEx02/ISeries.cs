using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.InterfaceEx02
{
    internal interface ISeries
    {
        public int Currnt  { get; set; }
        public void GetNext();
        public void Reset()
        {
            Currnt = 0; 
        }
        // Reset() : Defult Implemented Method ==>       ومش بتتغير class   علشان بتتكر ف كل 


    }
}
