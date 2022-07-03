using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> data;

        public string Name { get; set; }
        public int Capacity { get; set; }

        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Employee>();
        }

        public int Count => data.Count;

        public void Add(Employee employee)
        {
            if (data.Count < Capacity)
            {
                data.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            if (data.Any(x => x.Name == name))
            {
                Employee employeeToRemove = data.Where(x => x.Name == name).First();
                data.Remove(employeeToRemove);
                return true;
            }

            return false;
        }

        public Employee GetOldestEmployee()
        {
            Employee oldestEmployee = data.OrderByDescending(x => x.Age).First();
            return oldestEmployee;
        }

        public Employee GetEmployee(string name)
        {
            Employee employee = data.Where(x => x.Name == name).First();
            return employee;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {this.Name}:");
            foreach (Employee employee in data)
            {
                sb.AppendLine(employee.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
