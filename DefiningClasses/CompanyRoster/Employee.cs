using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Employee
{
    private string name;
    private decimal salary;
    private string position;
    private string department;
    private string email;
    private int age;

    public Employee(string name, decimal salary, string position, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = "n/a";
        this.age = -1;
    }

    public string Email
    {
        set { this.email = value; }
    }

    public int Age
    {
        set { this.age = value; }
    }

    public string Department { get { return this.department; } }

    public decimal Salary { get { return this.salary; } }

    public string PrintEmployeeInfo()
    {
        return $"{this.name} {this.salary:F2} {this.email} {this.age}";
    }
}

