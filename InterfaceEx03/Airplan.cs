using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.InterfaceEx03
{
    internal class Airplan : Vechile , IMoveable ,IFlyable
    {
        public override int Speed { get; set ; }

        void IMoveable.Backword()
        {
            Console.WriteLine(" I Am Moveable Backword  ");
        }
        // By Defult is private 
        void IFlyable.Backword()
        {
            Console.WriteLine(" I Am Flyable Backword  ");

        }

        void IMoveable.Forword()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Forword()
        {
            throw new NotImplementedException();
        }

        void IMoveable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMoveable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
