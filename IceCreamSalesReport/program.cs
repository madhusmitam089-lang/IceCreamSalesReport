using System;
using System.Collections.Generic;
using IceCreamSalesReport.Models;
using IceCreamSalesReport.Services;

namespace IceCreamSalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SaleRecord> records = new List<SaleRecord>
            {
                new SaleRecord
                {
                    Date = DateTime.Parse("2019-01-01"),
                    SKU = "Death by Chocolate",
                    UnitPrice = 180,
                    Quantity = 5,
                    TotalPrice = 900
                },
                new SaleRecord
                {
                    Date = DateTime.Parse("2019-01-01"),
                    SKU = "Cake Fudge",
                    UnitPrice = 150,
                    Quantity = 1,
                    TotalPrice = 150
                }
            };

            ReportService reportService = new ReportService();

            Console.WriteLine("Total Sales: " + reportService.GetTotalSales(records));

            var monthlySales = reportService.GetMonthlySales(records);
            foreach (var item in monthlySales)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}