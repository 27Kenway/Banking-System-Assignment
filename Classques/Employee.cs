using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classques
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Constructor for Employee
        public Employee(int id, string name, double salary, DateTime dob)
        {
            Id = id;
            Name = name;
            Salary = salary;
            DateOfBirth = dob;
        }

        // Method to compute salary for Employee
        public virtual double ComputeSalary()
        {
            // For simplicity, let's assume no additional calculations for the base employee
            return Salary;
        }
    }
}