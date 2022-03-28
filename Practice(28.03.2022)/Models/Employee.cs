using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_28._03._2022_.Models
{
     public class Employee : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
       

        private  static int _id;
        public int Id { get;  }

        static Employee()
        {
            _id = 0;
        }
        private Employee()
        {
            _id++;
            Id = _id;
        }

        public Employee(string name,int age,double salary):this()
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        public string ShowInfo(int Id,string Name, int Age, double Salary)
        {

            return $" Id:{Id} Ad:{Name} Yas:{Age} Maas:{Salary}";
        }


        public override string ToString()
        {
            return ShowInfo(Id,Name,Age,Salary);
        }


       
        
    }
}
