using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Baithi.Models
{
    public class Employee
    {
        string name;
        string role;
        string birthyear;

        public Employee()
        {
        }

        public Employee(string name, string role, string birthyear)
        {
            Name = name;
            Role = role;
            Birthyear = birthyear;
        }

        public string Name { get => name; set => name = value; }
        public string Role { get => role; set => role = value; }
        public string Birthyear { get => birthyear; set => birthyear = value; }
    }
    public class Root
    {
        public List<Employee> employees { get; set; }
    }
}
