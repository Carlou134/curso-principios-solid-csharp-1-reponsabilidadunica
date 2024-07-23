﻿using Liskov;

CalculateSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160, 10),
    new EmployeeContractor("Manuel Lopera", 180, 0)
});

void CalculateSalaryMonthly(List<Employee> employees) 
{
    foreach (var item in employees)
    {
        decimal salary = item.CalculateSalary((item is EmployeeFullTime));
        Console.WriteLine($"The {item.Fullname}'s salary is {salary}");
        
    }
}