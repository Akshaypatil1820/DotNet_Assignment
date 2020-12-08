using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
	class Program
	{
		static void Main(string[] args)
		{

			GeneralManager g = new GeneralManager("akshay", 10, 40000, "m");


			CEO c = new CEO("akshay", 10, 55000);



			Console.ReadLine();

		}
	}
	interface IDbFunction
	{
		void Insert();
		void Update();
		void Delete();

	}

	public abstract class Employee
	{
		public static int tempno = 0;

		private string name;
		private int empNo;
		private short deptNo;
		protected decimal basic;

		public Employee(string Name = "noName", short DeptNo = 10, decimal Basic = 32000)
		{
			Console.WriteLine("Employee Department");
			EmpNo = ++tempno;
			this.Name = Name;
			this.DeptNo = DeptNo;
			this.Basic = Basic;

		}

		public int EmpNo
		{
			get;
		}

		public abstract decimal Basic { set; get; }


		public short DeptNo
		{
			set
			{
				if (value <= 0)
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


		public abstract decimal GetNetSalary(decimal Basic);
	}

	public class Manager : Employee, IDbFunction
	{
		private string designation;

		public Manager(string Name = "noName", short DeptNo = 10, decimal Basic = 32000, string Designatio = "M") : base(Name, DeptNo, Basic)
		{
			Console.WriteLine("This is manager department");
			//this.EmpNo = ++tempno;
			this.Designation = Designation;
			Update();
			Delete();
			Insert();
		}

		public override decimal Basic
		{
			set
			{
				if (value > 15000 && value < 35000)
				{
					basic = value;
				}
				else
				{ Console.WriteLine("Enter valid Basic"); }
			}
			get { return basic; }

		}

		public string Designation
		{
			set
			{
				if (value != " ")
				{
					designation = value;
				}
				else
					Console.WriteLine("enter valid designation");
			}

			get
			{
				return designation;
			}

		}

		public void Delete()
		{
			Console.WriteLine("delete from manager");
		}

		public override decimal GetNetSalary(decimal Basic)
		{
			decimal HRA = ((Basic * 3) / 100);
			decimal TA = ((Basic * 4) / 100);
			decimal IT = ((Basic * 5) / 100);
			decimal PF = ((Basic * 4) / 100); ;

			decimal NetSalary = Basic + HRA + TA - PF - IT;
			return NetSalary;
		}

		public void Insert()
		{
			Console.WriteLine("insert from manager");
		}

		public void Update()
		{
			Console.WriteLine("update from manager");
		}
	}


	public class GeneralManager : Manager, IDbFunction
	{
		private string perks;

		public GeneralManager(string Name = "noName", short DeptNo = 10, decimal Basic = 32000, string Designation = "DM", string perks = "none") : base(Name, DeptNo, Basic, Designation)
		{
			Console.WriteLine("This is General_Manager department");

			this.Perks = Perks;
			Update();
			Delete();
			Insert();
		}

		public override decimal Basic
		{
			set
			{
				if (value > 35000 && value < 50000)
				{
					basic = value;
				}
				else
				{ Console.WriteLine("Enter valid Basic"); }
			}
			get { return basic; }
		}
		public string Perks
		{
			set { perks = value; }
			get { return perks; }
		}

		public override decimal GetNetSalary(decimal Basic)
		{
			decimal HRA = ((Basic * 3) / 100);
			decimal TA = ((Basic * 4) / 100);
			decimal IT = ((Basic * 5) / 100);
			decimal PF = ((Basic * 4) / 100); ;

			decimal NetSalary = Basic + HRA + TA - PF - IT;
			return NetSalary;
		}

		public new void Delete()
		{
			Console.WriteLine("delete from general_manager");
		}

		public new void Insert()
		{
			Console.WriteLine("insert from general_manager");
		}

		public new void Update()
		{
			Console.WriteLine("update from general_manager");
		}


	}

	public class CEO : Employee, IDbFunction
	{
		public CEO(string Name = "noName", short DeptNo = 10, decimal Basic = 32000) : base(Name, DeptNo, Basic)
		{
			Console.WriteLine("This is CEO department");
			Update();
			Delete();
			Insert();
		}
		public override decimal Basic
		{
			set
			{
				if (value > 50000 && value < 60000)
				{
					basic = value;
				}
				else
				{ Console.WriteLine("Enter valid Basic"); }
			}
			get { return basic; }
		}

		public void Delete()
		{
			Console.WriteLine("delete from ceo");
		}

		public sealed override decimal GetNetSalary(decimal Basic)
		{
			decimal HRA = ((Basic * 3) / 100);
			decimal TA = ((Basic * 4) / 100);
			decimal IT = ((Basic * 5) / 100);
			decimal PF = ((Basic * 4) / 100); ;

			decimal NetSalary = Basic + HRA + TA - PF - IT;
			return NetSalary;
		}

		public void Insert()
		{
			Console.WriteLine("insert from ceo");
		}

		public void Update()
		{
			Console.WriteLine("update from ceo");
		}
	}

}

