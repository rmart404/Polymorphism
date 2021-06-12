using System;
using Employees;

Manager chucky = new Manager("Chucky", 50, 92, 100_000, "333-23-2322", 9_000);
chucky.GiveBonus(300);
chucky.DisplayStats();
Console.WriteLine();

SalesPerson fran = new SalesPerson("Fran", 43, 93, 3_000, "333-23-2322", 31);
fran.GiveBonus(200);
fran.DisplayStats();
Console.ReadLine();

//Employee x = new Employee();