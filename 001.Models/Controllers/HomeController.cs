using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _001.Models;

namespace _001.Controlles
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    ThickModel model = new ThickModel("CBS", 100, 6000);
        //    int totalSalary = model.TotalSalary();
        //    string company = $"Company: {model.Company}\n";
        //    string empoyees = $"Employees: {model.Employees}\n";
        //    string salary = $"Total Salary: {totalSalary}\n";
        //    return company + empoyees + salary;
        //}

        public string Index()
        {
            PlainModel model = new PlainModel()
            {
                Company = "Microsoft",
                Employees = 100000,
                Salary = 10000
            };

            int totalSalary = model.Employees * model.Salary;
            string company = $"Company: {model.Company}\n";
            string empoyees = $"Employees: {model.Employees}\n";
            string salary = $"Total Salary: {totalSalary}\n";
            return company + empoyees + salary;
        }
    }
}
