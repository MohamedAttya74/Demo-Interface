using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.InterfaceEx01
{
    internal interface IType
    {
        // public :  access modifired  is the  defult access modifire inside the interface 
        // privte  :  access modifired  is not allowed fpr the segnatures only ( propety,method  )    


        // what ypu can write inside the interface ?

        // 1- segnature  for  propety 
        public int MyProperty { get; set; }

        // 2- segnature  for  Method

        public void myType();

        // 3- Defult immplemented method [ C# 8.0 New feature (.NET core 3.1 [2019]) ]

        void prinit() {

            Console.WriteLine("My Defult  immplemented method ");    //    وبيكون ليها استخدامات  privete  عادي احطلها   
        
        
        }




        // Static member  [ C# 8.0 New feature (.NET core 3.1 [2019]) ]  
        // static fields 
        // static Methods 
        // static properties 
        // static Events 


    }
}
