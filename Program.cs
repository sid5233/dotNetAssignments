using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee("Amol", 123465, 10);
            obj.Display();
            Console.WriteLine("net_salary: "+obj.net_salary()); 
            Console.ReadLine();
           
            Employee obj1 = new Employee("Amol", 123465);
            obj1.Display();
            Console.WriteLine("net_salary: " + obj1.net_salary());
            Console.ReadLine();

            Employee obj2 = new Employee("Amol");
            obj2.Display();
            Console.WriteLine("net_salary: " + obj2.net_salary());
            Console.ReadLine();

            Employee obj3 = new Employee();
            obj3.Display();
            Console.WriteLine("net_salary: " + obj3.net_salary());
            Console.ReadLine();
        }
    }

    class Employee
    {
       private string Name;
       private static int EmpNo;
       private decimal Basic;
       private short DeptNo;


        public string NAME
        {
            set {
                    if (value == "" || value == null  )
                    {
                    
                    }
                    else
                    {
                    Name = value;
                    }
                }
            get
            {
                return Name;
            }
        }

        public decimal BASIC
        {
            set
            {
                if (value >=0 && value <= 20000)
                {
                    Basic = value;
                }
                
            }
            get
            {
                return Basic;
            }
        }
        public decimal DEPTNO
        {
            set
            {
                if (value > 0 )
                {
                    Basic = value;
                }
                
            }
            get
            {
                return DeptNo;
            }
        }
        public int EMPNO {  get; }

        public Employee(string Name="",decimal Basic=0,short DeptNo=0)
        {
            NAME = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
            EmpNo++;
        }


       public decimal net_salary()
        {
            decimal da = Basic *(decimal) 0.52;
            decimal gross_salary = Basic + da;
            decimal it = gross_salary *(decimal) 0.30;
            decimal net_salary = (Basic + da) - it;
            return net_salary;
        }



        public void Display()
        {
            Console.WriteLine("Emp No: "+EmpNo+"\nName: "+Name+"\nBasic "+Basic+"\nDeptNo: "+DeptNo);
        }

    }
}
