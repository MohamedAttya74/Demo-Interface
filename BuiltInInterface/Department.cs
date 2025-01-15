using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.BuiltInInterface
{
    internal class Department : ICloneable
    {
        public int code  { get; set; }
        public string? Title { get; set; }

        public object Clone()
        {
            return new Department() { 
            
            Title =this.Title,
            code = this.code
            
            };
        }
    }
}
