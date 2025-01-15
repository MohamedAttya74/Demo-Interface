
//using Demo_Interface.Interface_Ex01;
using Demo_Interface.BuiltInInterface;
using Demo_Interface.InterfaceEx01;
using Demo_Interface.InterfaceEx02;
using Demo_Interface.InterfaceEx03;
using System.Diagnostics.Metrics;


namespace Demo_Interface
{
    internal class Program
    {
        #region Interface Ex:02

        static void PrintNumberFromSeries(ISeries series)
        {
            if (series is null)
                return;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{series.Currnt}\t");
                series.GetNext();
            }
            series.Reset();
        }


        #endregion


        static void Main(string[] args)
        {
            #region   Interface EX:01
            //IType Referance;
            //// Declare for  Reference of type "IType ",containing Garbag value 
            //// this Reference "Reference" can refer  to an  object of type "Type implemented  Itype  interface " 
            //// clr will Allocte 4 unintinalized  Bytes in Stack for this Reference
            //// clr will Allocte  0 bytes in Heap 


            ////Referance = new IType(); // InValide ==>  can`t  initionate object from interface 
            ////Referance.myType(); 

            //Referance = new TypeA();
            //Referance.MyProperty = 10;
            //Referance.myType(); // "Hello World"
            //Referance.prinit(); //  Defult  immplemented method 


            //TypeA typeA = new TypeA();
            //typeA.MyProperty = 10;
            //typeA.myType();
            ////typeA.prinit(); // InValide : Not Inheretance from interface 

            #endregion


            #region Interface EX:02

            //TypeB SeriesByTwo = new TypeB();
            //PrintNumberFromSeries(SeriesByTwo);


            //TypeC SeriesByThree = new TypeC();
            //PrintNumberFromSeries(SeriesByThree);


            //TypeD SeriesByFour = new TypeD();
            //PrintNumberFromSeries(SeriesByFour);

            #endregion


            #region Interface EX:03
            Airplan airplan = new Airplan();
            airplan.Speed = 480;

            //IFlyable Flyable = airplan;
            //Flyable.Backword();

            //IMoveable Moveable = airplan;
            //Moveable.Backword();
            #endregion

            #region Shallow Copy Vs Deep Copy 

            //int[] Arr01 = [1, 2, 3];
            //int[] Arr02 = [4, 5, 6];


            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());


            #region Shallow Copy 
            //Arr02 = Arr01; Console.WriteLine("After Shallow Copy --> Arr02 = Arr01");

            // Shallow Copy [ سطحي ] : to بيأثر ف الاصل  Copy  التأثير ف ال       
            // this object [1, 2, 3] has 2 referances[اسمين دلع]
            // this object  [4, 5, 6]  Became Unreachable object  
            #endregion

            #region Deep Copy
            //  Arr02 = (int[])Arr01.Clone(); //  علشان مش عارفه انت عايو اي   return Object    بت  Clone() علشان ال  
            // Console.WriteLine("After Deep Copy -- >Arr02 = (int[])Arr01.Clone()");
            // Deep Copy :    بس ملهوش علاقه بالاصل  State  من ال Copy  التأثير ف النسخه مش بيأثر ف الاصل علشان هو بياخد 
            // Clone Method : Will Generate New Object With New and Different Idendity 
            //              : this Object Will Have the same State [data] of caller object 
            // Clone() : الي جوه   Items   لل  Shallow Copy  بيعمل 

            #endregion

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());


            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]);  // 100


            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("**************************");


            //foreach (int Number in Arr01)
            //{
            //    Console.WriteLine(Number);
            //}

            //Console.WriteLine("******************");

            //foreach (int Number in Arr02)
            //{
            //    Console.WriteLine(Number);
            //}


            #endregion

            #region Why Clone Method Description Saye It Make Shallow Copy?

            //string[] Names01 = ["Amr", " Mona "];
            //string[] Names02 = ["Ahmed", "Yassmen"];

            //Console.WriteLine($"Names01.GetHashCode() = {Names01.GetHashCode()}");
            //Console.WriteLine($"Names02.GetHashCode()= {Names02.GetHashCode()}");

            //Names02 = (string[])Names01.Clone(); Console.WriteLine("After Deep Copy --> Names02 = (string[])Names01.Clone() ");
            //// Clone Method : Will Generate New Object With New and Different Idendity 
            ////              : this Object Will Have the same State [data] of Origimal  object [Shallow copy for items ]


            //Console.WriteLine($"Names01.GetHashCode() = {Names01.GetHashCode()}");
            //Console.WriteLine($"Names02.GetHashCode()= {Names02.GetHashCode()}");

            //Names02[0] = "Khaled";
            ////Names02[0] =new string("Khaled");
            //Console.WriteLine(Names01[0]);




            #endregion

            #region Built-In interface [ICloneable]


            //Employee employee01 = new Employee() { Id = 10, Name = " Ahmed ", Salary = 80000, Department = new Department() { code = 1001, Title = "Sales " } };
            //Employee employee02 = new Employee() { Id = 20, Name = " Omniaa ", Salary = 10000, Department = new Department() { code = 1002, Title = "HR " } };


            //Console.WriteLine($"employee01.GetHashCode() ={employee01.GetHashCode()}");
            //Console.WriteLine($"employee02.GetHashCode() ={employee02.GetHashCode()}");
            //// Employee not Implemented Member Method Clone() 
            //employee02 = (Employee)employee01.Clone();  // 2.1 Deep Copy Using Clone 
            ///// Clone Method : Will Generate New Object With New and Different Idendity 
            ////              : this Object Will Have the same State [data] of Origimal  object [Shallow copy for items ]

            //employee02.Salary = 50000;  //    بس  employee02 هيغير ف 


            //if (employee02.Department != null)
            //    employee02.Department.Title = "new";


            //employee02 = new Employee(employee01);  // 2.2 Deep Copy Using Copy Constructor  
            //                                        // بتعمله   Clone() دي الطريقه التانيه وهو ان انا الي اعمل ال 

            //Console.WriteLine("After  Deep Copy Using Clone");

            //Console.WriteLine($"employee01.GetHashCode() ={employee01.GetHashCode()}");
            //Console.WriteLine($"employee02.GetHashCode() ={employee02.GetHashCode()}");



            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine($"Employee 1 -->{employee01}");
            //Console.WriteLine($"Employee 2 -->{employee02}");

            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine(employee01.Department.Title); // Sales



            //Console.WriteLine("----------------------------------------------"); // After the Copy Constructor 
            //Console.WriteLine($"Employee 1 -->{employee01}");
            //Console.WriteLine($"Employee 2 -->{employee02}");



            //// String  مش هيعمل اتنين  Clr  عندهم نفس القيمه ال  Two String   حتي لو عندي   Heap   واحد بس فال  Ahmed  خلي بالك انا عندي 


            #endregion


            /// int[] Number = [10,5,1,9,3,7];
            ///
            /// Array.Sort(Number);  // هرتبهم عادي 
            ///
            ///foreach (int number in Number) 
            ///     Console.WriteLine(number);
            ///
            #region Built-In InterFace ICloneable, IComparable

            //Employee[] employees = {
            //
            //
            // new Employee(){Id = 40 , Name = "Omar" , Salary = 8000},
            // new Employee(){Id = 10 , Name = "Ahmed" , Salary = 8000},
            // new Employee(){Id = 30 , Name = "Nada" , Salary = 15000},
            // new Employee(){Id = 20 , Name = "Omniaa" , Salary = 2000},
            //
            //
            //};
            // Array.Sort(employees ,new EmployeeComparer() ); // Expetion :   based on ?  علشان  مش قادر يقارن اي حاجه مهو هيقارن  
            //                        //    Implement interface --> (IComparable)   يكون بي  Employee class علشان اعمل كدا لازم ال 
            //                        //    based on (Salary )  هنا من الصغير للكبير Sort  ف هو هي     implemente to IComparable   وبما ان انا عملت 
            //
            //
            //foreach (Employee employee in employees) {
            //    Console.WriteLine(employee);
            //}
            //
            // 
            #endregion

            int[] Numbers = [9, 10, 8, 2, 1, 6];
            
            Array.Sort(Numbers, new IntComparer());
            foreach (int Number in Numbers)
            {
                Console.WriteLine(Number);
            }
        }
    }
}
