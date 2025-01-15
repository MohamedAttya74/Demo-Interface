using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.InterfaceEx03
{
    internal class Car : Vechile , IMoveable
    {

        public override int Speed { get ; set; } //   ومتنسهاش   override  خلي بالك من ال  
                                                 //    immplement abstract Property استخدمناها علشان ن  
        public void Backword()
        {
            throw new NotImplementedException();
        }

        public void Forword()
        {
            throw new NotImplementedException();
        }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }
    }                                        
}
