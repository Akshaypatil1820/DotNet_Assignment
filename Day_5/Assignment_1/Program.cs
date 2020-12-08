using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter number of employees");
            int size = Convert.ToInt32(Console.ReadLine());
            Employee[] A = new Employee[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter Employee Number");
                int EmpNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name");
                String Name = (Console.ReadLine());
                Console.WriteLine("Enter Employee Salary");
                decimal Sal = Convert.ToDecimal(Console.ReadLine());


                Employee E = new Employee(EmpNo, Name, Sal);
                A[i] = E;

            }

            Console.WriteLine("Details of Employees");
            List<Employee> list = A.ToList<Employee>();

            foreach (Employee li in list)
            {
                Console.WriteLine(li);
            }



            Console.ReadLine();
        }


    }
    class Employee
    {
        public int EmpNo;
        public string Name;
        public decimal Sal;

        public Employee(int EmpNo, string Name, decimal Sal)
        {
            this.EmpNo = EmpNo;
            this.Name = Name;
            this.Sal = Sal;
        }


        public override string ToString()
        {
            return EmpNo + " " + Name + " " + Sal;
        }

    }

}
