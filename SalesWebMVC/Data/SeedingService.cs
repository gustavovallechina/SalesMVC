using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Data;
using Sales.Models;
using SalesWebMVC.Data;
using SalesWebMVC.Models;
using Sales.Models.Enums;

namespace Sales.Data
{
    public class SeedingService
    {
        private SalesContext _context;

        public SeedingService(SalesContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any()||
                _context.Seller.Any()||
                _context.SallesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1984, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "bob@gmail.com", new DateTime(1984, 4, 21), 2000.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "bob@gmail.com", new DateTime(1984, 4, 21), 1000.0, d3);
            Seller s4 = new Seller(4, "Martha Red", "bob@gmail.com", new DateTime(1984, 4, 21), 1000.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "bob@gmail.com", new DateTime(1984, 4, 21), 1000.0, d1);
            Seller s6 = new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(1984, 4, 21), 1000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 1100.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 25), 1100.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 25), 1100.0, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 25), 1100.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 25), 1100.0, SaleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 25), 1100.0, SaleStatus.Billed, s6);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SallesRecord.AddRange(r1,r2,r3,r4,r5,r6);
            _context.SaveChanges();
        }
    }
}
