using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    public abstract class Employee
    {

        public Employee(string name = "no", short deptno = 0, decimal Basic = 2000)
        {

            this.EmpName = name;
            this.DeptNumber = deptno;
            this.Basic = Basic;


            Console.WriteLine(EmpName);
            Console.WriteLine(DeptNumber);
            
        }

        public decimal basic;
        public abstract decimal Basic
        {
            get;
            set;
        }
        public static int lastempNo = 0;
        public string name;

        public string EmpName
        {

            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Invalid name");
                }

            }

            get
            {

                return name;

            }

        }

        public int empno;
        public int Empno
        {
            set
            {
                empno = value;

            }
            get
            {
                return empno;
            }
        }

        public short deptno;

        public short DeptNumber
        {
            set
            {
                if (value >= 0)
                {
                    deptno = value;
                }

                else
                {
                    Console.WriteLine("wrong number");
                }

            }

            get
            {
                return deptno;
            }
        }
        public abstract decimal CalcNetSalary(decimal basic);

    }

    public interface IDFunction
    {
        void insert();
        void update();

        void delete();
    }


    public class Manager : Employee ,IDFunction
    {

        public Manager(string name = "no", short deptno = 0, decimal Basic = 0, string design = "Manager") : base(name, deptno, Basic)
        {

            this.Designation = design;
            Console.WriteLine(Designation);

            
        }

        public string design;

        public string Designation
        {
            set
            {
                if (value != null)
                {
                    design = value;
                }
                else
                {
                    Console.WriteLine("Invalid");

                }

            }

            get
            {
                return design;
            }
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

        public override decimal CalcNetSalary(decimal basic)
        {

            decimal DA = ((basic * 40) / 100);
            decimal HRA = ((basic * 20) / 100);
            decimal Gross_Salary = basic + DA + HRA;

            return Gross_Salary;

        }

        public void insert()
        {
            Console.WriteLine("Manager insert");
        }

        public void update()
        {
            Console.WriteLine("Manager update");
        }

        public void delete()
        {
            Console.WriteLine("Manager delete");
        }
    }

    public class GeneralManager : Manager ,IDFunction
    {


        public string perks;

        public GeneralManager(string name = "no", short deptno = 0, decimal Basic = 0, string design = "GM", string perks = "none")

            : base(name, deptno, Basic, design)
        {

            this.Perks = perks;

            Console.WriteLine(Perks);

            insert();
            update();
            delete();

        }


        public string Perks
        {
            set
            {
                perks = value;
            }
            get
            {
                return perks;
            }
        }

        public  new void insert()
        {
            Console.WriteLine("GM insert");
        }

        public new void update()
        {
            Console.WriteLine("GM update");
        }

        public new void delete()
        {
            Console.WriteLine("GM delete");
        }

    }

    public class CEO : Employee,IDFunction
    {
        public CEO() 
        {
            insert();
            update();
            delete();
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

        public override sealed decimal CalcNetSalary(decimal basic)
        {

            decimal DA = ((basic * 40) / 100);
            decimal HRA = ((basic * 20) / 100);
            decimal Gross_Salary = basic + DA + HRA;

            return Gross_Salary;

        }

        public void delete()
        {
            Console.WriteLine("CEO delete");
        }
        public void insert()
        {
            Console.WriteLine("CEO insert");
        }

        public void update()
        {
            Console.WriteLine("CEO update");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {         
            GeneralManager g1 = new GeneralManager("Sid", 15, 4000, "GM", "Micros");
            Console.WriteLine(g1.CalcNetSalary(g1.Basic));
            Console.ReadLine();
        }
    }
}
