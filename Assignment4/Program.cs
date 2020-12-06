using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the no of emp you want to add ");
            int no = int.Parse(Console.ReadLine());
            Employee[] emp = new Employee[no];

            for(int i =0; i< emp.Length; i++)
            {
                Console.WriteLine("\nEnter empno = ");
                int empno = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter Name = ");
                string empname = Console.ReadLine();

                Console.WriteLine("Enter Designation = ");
                string post = Console.ReadLine();

                Console.WriteLine("Enter salary = ");
                decimal salaray = decimal.Parse(Console.ReadLine());

                Employee temp = new Employee();
                temp.setValues(empno, empname, post, salaray);
                emp[i] = temp;



            }
            Console.WriteLine("\n Employees with deatils \n");
            for (int i = 0; i < emp.Length; i++)
            {
                  emp[i].display();

            }
            Console.ReadLine();
            decimal hs = emp[0].salary;
            Console.WriteLine("\n Highest salary : ");
            for (int i = 0; i < emp.Length; i++)
            {
                if(emp[i].salary > hs)
                {
                    hs = emp[i].salary;
                    //emp[i].display();
           
                    Console.WriteLine(emp[i].empName + " has the " + "maximum salary which is: " + hs);
                }
            }
            Console.ReadLine();

            Console.WriteLine("\n Enter the id to be serched : ");

            int search = int.Parse(Console.ReadLine());

            for (int i = 0; i < emp.Length; i++)
            {
                if (emp[i].empNo == search)
                {
                    emp[i].display();
                }
            }



            Console.ReadLine();

        }
    }
    class Employee
    {
        public int empNo;
        public string empName;
        public string post;
        public decimal salary;

        public void setValues(int empno, string empname, string post, decimal salary)
        {
            this.empName = empname;
            this.empNo = empno;
            this.post = post;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("EmpNo : " + empNo);
            Console.WriteLine("Emp Name : " +empName);
            Console.WriteLine("Post : " + post);
            Console.WriteLine("salary : "  + salary);
            Console.WriteLine();
        }
    }
}