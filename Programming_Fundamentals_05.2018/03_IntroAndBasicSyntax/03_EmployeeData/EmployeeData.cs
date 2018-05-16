using System;

namespace _03_EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employeeID = int.Parse(Console.ReadLine());
            decimal monthlySalary = decimal.Parse(Console.ReadLine());
            decimal roundedMonthlySalary = Math.Round(monthlySalary, 2, MidpointRounding.AwayFromZero);


            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {employeeID:D8}");
            Console.WriteLine($"Salary: {roundedMonthlySalary:0.00}");

        }
    }
}
