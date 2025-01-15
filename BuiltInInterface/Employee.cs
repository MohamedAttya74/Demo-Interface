using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.BuiltInInterface
{
    internal class Employee : ICloneable, IComparable  //         Immplement This Interface   بس دا اثبات انك بت   :ICloneable  ممكن تشيل 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public Department? Department { get; set; }

        public Employee()
        {
            
        }


        // Copy Constrctor : Is A Spicial Constructor Used  To Make Deep Copy For The ReferanceType  Object  
        public Employee(Employee employeecopy )
        {
            this.Id = employeecopy.Id;
            this.Name = employeecopy.Name;
            this.Salary = employeecopy.Salary;
            this.Department =   (Department?) employeecopy.Department?.Clone();
            
        }

        public object Clone()
        {


              return  new Employee (this );  // new Employee (employee01 )  --->  يعني ممكن تعمل كدا وهي هي الي تحت مفيش فرق 
         ///return new Employee()
         ///{
         ///    Id = this.Id,
         ///    Name = this.Name,    // ف مش هتفرق معايا كتبت كدا  Name فالحالتين هيشاور علي نفس ال 
         ///    //Name =  (string?) this.Name?.Clone(), 
         ///    Salary = this.Salary,
         ///
         ///    Department = (Department?)this.Department?.Clone()
         ///    //Department = this.Department     // :   Sallow copy   دا اسمه    

            //};
        }

        public override string ToString()
        {
            return    ($" ID : {Id}  ,   Name : {Name}   ,  Salary : {Salary}   ")        ;
        }



        // +V(1) :this.Salary > obj.Salary
        // -V(-1) :this.Salary < obj.Salary
        // 0 :this.Salary = obj.Salary

        public int CompareTo(object? obj)
        {
            Employee? other =  (Employee?) obj;  // Explict Casting 
                                                 // Unsave Casting [May throw Exeption ]
                                     //     ولسه هنعرفهم  is - as          والافضل اننا نستخدم ال 
            return this.Salary.CompareTo(other?.Salary);  //  implement the interface IComparable  بت  decimal  ودا علشان ال 
            //return   -  this.Salary.CompareTo(other?.Salary);// لو عايز ارتب من الكبير للصغير 

            /// if (this.Salary > other?.Salary)
            /// 
            ///     return 1;
            /// else if (this.Salary < other?.Salary)
            ///     return -1;
            /// else 
            ///     return 0;
            ///    


        }
    }



    




}
