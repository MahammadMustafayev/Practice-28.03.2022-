using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_28._03._2022_.Models
{
    public class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }

        public Department(string name,int employeelimit)
        {
            Name = name;
            EmployeeLimit = employeelimit;
        }
        private Employee[] _employees = new Employee[0];

        public Employee this[int index] 
        {
            get 
            {
                return _employees[index];
            }
            set 
            {
                 _employees[index]=value;
            } 
        }

        public void AddEmployee(Employee employee)
        {
            if (_employees.Length < EmployeeLimit)
            {
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = employee;
            }
            else
            {
                throw new CapacityLimitException($"Isci sayi {EmployeeLimit} dan cox ola bilmez");
            }
            //Array.Resize(ref _employees, _employees.Length + 1);
            //_employees[_employees.Length - 1] = employee;
        }
        
    }
}

