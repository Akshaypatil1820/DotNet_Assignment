using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    class Employee1
    {
        static void Main(string[] args)
        {

            Employee e = new Employee();
            Employee e1 = new Employee();
            Employee e2 = new Employee();


            List<Employee> list = new List<Employee>();

            e.set(10, "Sumedh", 1000);
            list.Add(e);

            e1.set(11, "Tejas", 1000);
            list.Add(e1);

            e2.set(12, "Akshay", 1000);
            list.Add(e2);

            Employee[] Arr = list.ToArray();

            foreach (Employee T in list)
            {
                Console.WriteLine(T);
            }

            Console.ReadLine();
        }

    }
    class Employee
    {
        int Ro_No;
        String Name;
        decimal Fee;

        public void set(int Ro_No, String Name, decimal Fee)
        {
            this.Ro_No = Ro_No;
            this.Name = Name;
            this.Fee = Fee;

        }


        public override string ToString()
        {
            Console.WriteLine("Emlpoyee details");
            return Ro_No + " " + Name + " " + Fee;
        }

    }
}