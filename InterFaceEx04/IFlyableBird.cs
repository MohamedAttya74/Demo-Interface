using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.InterFaceEx04
{
    internal interface IFlyableBird : IBird      //   تاني عادي  inherate From interface    ي  interface   عادي 
    {

        void Fly();
    }
}
