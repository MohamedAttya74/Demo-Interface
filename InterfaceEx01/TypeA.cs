using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.InterfaceEx01
{
    internal class TypeA : IType      //      Two Options     وبعد كدا عندك    ctr+.  اعمل  
    {                                 //   implement interface 
                                      //   implement interface explicitly:    عندهم نفس الحاجه بنفس الاسماء   interface  اكتر من  implement    بي   class     وهنا بعمل دي لما يكون ال 
        //public int MyProperty1 { get; set; } // Automatic Prooerty 
        //private int MyAttreibute;
        public int MyProperty { get; set; }

        //public int MyProperty {
        //    get { return  MyAttreibute; }
        //    set {   MyAttreibute  = value ; }
        //    }

        public void myType()
        {
            Console.WriteLine("Hello World");
        }
    }
}
