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
            GeneralManager gen = new GeneralManager("Sudarshan", 5, 15000, "GenMan", "COO");
            Console.WriteLine(gen.CalcNetSalary(gen.Basic));
            
            Manager Man = new Manager("Sid", 2, 12000, "GenMan");
            Console.WriteLine(Man.CalcNetSalary(Man.Basic));
            Console.ReadLine();
        }
    }

    public abstract class Employee
    {
        #region DataMember
        private string name;
        public string Name
        {
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("please enter valid input!!");
                }
            }
            get { return name; }
        }
        private static int lastemp = 0;
        private int empNO;
        public int EmpNo
        {
            get { return empNO; }
            private set { empNO = value; }
        }

        public decimal basic;
        public abstract decimal Basic
        { set; get; }

        private short deptNo;
        public short DEPTNO
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("invalid department no");
                }
            }
            get { return deptNo; }
        }
        #endregion

        #region Methods
        public abstract decimal CalcNetSalary(decimal basic);

        #endregion

        public Employee(string Name = "noname", short DeptNo = 10, decimal Basic = 10000)

        {

            empNO = ++lastemp;
            this.Name = Name;
            this.Basic = Basic;
            this.deptNo = DeptNo;

        }
    }
    public class Manager : Employee
    {
        public Manager(string name = "no", short deptno = 0, decimal Basic = 15000, string design = "Manager") : base(name, deptno, Basic)
        {

            this.Designation = design;

        }

        public string designation;
        public string Designation
        {
            set
            {
                if (value != null)
                {
                    designation = value;
                }
                else
                {
                    Console.WriteLine("Enter valid name :");
                }
            }
            get
            {
                return designation;
            }
        }
        public override decimal Basic
        { set
            {
                if (value > 10000 && value < 20000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("range is 10000 to 20000");
                }
            }
            get { return basic; }
        }

        public override decimal CalcNetSalary(decimal basic)
        {
            decimal DA = ((basic * 25) / 100);
            decimal Gross_Salary = basic + DA;

            return Gross_Salary;
        }
    }
    public class GeneralManager : Manager 
    {
        public string perks;
        public string Perks { get; set; }

        public GeneralManager(string name = "no", short deptno = 0, decimal Basic = 2000, string design = "GM", string perks = "none")

           : base(name, deptno, Basic, design)
        {

            this.Perks = perks;

        }
    }
    public class CEO : Employee
    {
        public CEO()
        {
            Console.WriteLine("Constructor From CEO class");
        }
        public override decimal Basic 
        {
            set
            {

                if (value > 1500 && value < 10000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            get
            {
                return basic;
            }
        }

        public sealed override decimal CalcNetSalary(decimal basic)
        {
            decimal DA = ((basic * 40) / 100);
            decimal Gross_Salary = basic + DA  ;

            return Gross_Salary;
        }
    }
}
