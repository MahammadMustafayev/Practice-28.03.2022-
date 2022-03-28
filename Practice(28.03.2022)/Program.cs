using System;
using Practice_28._03._2022_.Models;

namespace Practice_28._03._2022_
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Adinizi Daxil edin");
            string name = Console.ReadLine();
            int age;
            do
            {
                Console.WriteLine("Yasinizi daxil edin");
                age = int.Parse(Console.ReadLine());
            } while (age<18 || age>65);
            double salary;
            try
            {
                Console.WriteLine("Maasinizi daxil edin");
                salary = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
           
            int employeelimit;
            try
            {
                Console.WriteLine("Isci sayi daxil edin");
                employeelimit = int.Parse(Console.ReadLine());
            }
            catch (CapacityLimitException)
            {
                goto Start;
            }
            Department department = new Department(name, employeelimit);

            Employee employee1 = new Employee(name,age,salary);
            Employee employee2 = new Employee(name,age,salary);
            Employee employee3 = new Employee(name,age,salary);
            Employee employee4 = new Employee(name,age,salary);

            department.AddEmployee(employee1);
            department.AddEmployee(employee2);
            department.AddEmployee(employee3);
            Console.WriteLine(employee1.ToString());

            Console.WriteLine(department[0]);
            Console.WriteLine(department[1]);
            Console.WriteLine(department[2]);

            
        }
    }
}
