using System;
using System.Collections.Generic;

namespace EmployeeDelegate
{   //unicast delegates
    class Program
    {
        static void PromoteEmp(List<Emp> emps)
        {
            foreach (var e in emps)
            {
                if (e.DateOfJoin > 5 && e.Salary > 25000)
                {
                    Console.WriteLine("{0} is promoted..",e.Name);
                } 
            }
        }
        public delegate void Promotion(List<Emp> emps);
        static void Main(string[] args)
        {
            List<Emp> EmpList = new List<Emp>();
            EmpList.Add(new Emp { DateOfJoin = 4, Salary = 26000, Name = "tanmay" });
            EmpList.Add(new Emp { DateOfJoin = 6, Salary = 27000, Name = "niket" });
            EmpList.Add(new Emp { DateOfJoin = 7, Salary = 26500, Name = "damodar" });

            Promotion p = new Promotion(PromoteEmp);
            p(EmpList);


        }
        public class Emp
        {
            public int DateOfJoin { get; set; }
            public double Salary { get; set; }
            public string Name { get; set; }
        }
    }
}
