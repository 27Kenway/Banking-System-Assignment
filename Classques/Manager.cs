using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classques
{
    internal class Manager:Employee
    {
        public double OnsiteAllowance { get; set; }
        public double Bonus { get; set; }

        // Constructor for Manager
        public Manager(int id, string name, double salary, DateTime dob, double onsiteAllowance, double bonus)
            : base(id, name, salary, dob)
        {
            OnsiteAllowance = onsiteAllowance;
            Bonus = bonus;
        }

        // Override method to compute salary for Manager
        public override double ComputeSalary()
        {
            // Manager's salary includes base salary, onsite allowance, and bonus
            return Salary + OnsiteAllowance + Bonus;
        }    }
}
