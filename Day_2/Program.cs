using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee o1 = new Employee("sumedh", 12345, 10);
			Console.WriteLine("net salary for for {0} is {1} {2}", o1.Name, o1.GetNetSalary(), o1.EmpNo);
			Employee o2 = new Employee("Akshay", 15000);
			Console.WriteLine("net salary for for {0} is {1} {2}", o2.Name, o2.GetNetSalary(), o2.EmpNo);
			Employee o3 = new Employee("tejas");
			Console.WriteLine("net salary for for {0} is {1} {2}", o2.Name, o2.GetNetSalary(), o3.EmpNo);
			Employee o4 = new Employee();


			Console.ReadLine();
		}
	}

	public class Employee
	{
		public static int tempno;

		private int empNo;
		public int EmpNo
		{
			get;
		}
		public Employee()
		{

			tempno++;
			this.EmpNo = tempno;
		}

		public Employee(string name, float basic, short deptNo)
		{
			tempno++;
			this.EmpNo = tempno;
			this.Basic = basic;
			this.Name = name;
			this.DeptNo = deptNo;

		}
		public Employee(string name, float basic)
		{
			tempno++;
			this.EmpNo = tempno;
			this.Basic = basic;
			this.Name = name;


		}
		public Employee(string name)
		{
			tempno++;
			this.EmpNo = tempno;

			this.Name = name;


		}
		private string name;
		public string Name
		{
			set
			{
				if (value == " ")
				{
					Console.WriteLine("invalid");
					
				}
				else
					name = value;

			}

			get
			{
				return name;
			}
		}



		private float basic;
		public float Basic

		{
			set
			{
				if (value > 5000 && value < 20000)
				{
					basic = value;
				}
				else
					Console.WriteLine("invalid");
			}

			get
			{
				return basic;
			}
		}

		private short deptNo;
		public short DeptNo
		{
			set
			{
				if (value < 0)
				{
					Console.WriteLine("enter valid data");
				}
				else
					deptNo = value;
			}

			get
			{
				return deptNo;
			}
		}

		public decimal GetNetSalary()
		{
			decimal NetSalary = Convert.ToDecimal(Basic + (0.03 * Basic) + (0.05 * Basic) - (0.04 * Basic) - (0.05 * Basic));
			return NetSalary;

		}
	}

}