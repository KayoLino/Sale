using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.SalesRecord.Any() || _context.Seller.Any()) 
            {
                return;
            }

            Department d1 = new Department { Name = "Computers" };
            Department d2 = new Department { Name = "Electronics" };
            Department d3 = new Department { Name = "Fashion" };
            Department d4 = new Department { Name = "Books" };

            Seller s1 = new Seller { Name = "Bob Brown", Email = "bob@gmail.com", BirthDate = new DateTime(1998, 4, 21), BaseSalary = 1000.0, Department = d1 };
            Seller s2 = new Seller { Name = "Maria Green", Email = "maria@gmail.com", BirthDate = new DateTime(1979, 12, 31), BaseSalary = 3500.0, Department = d2 };
            Seller s3 = new Seller { Name = "Alex Grey", Email = "alex.grey@gmail.com", BirthDate = new DateTime(1985, 7, 10), BaseSalary = 2200.0, Department = d3 };
            Seller s4 = new Seller { Name = "Lara White", Email = "lara.white@gmail.com", BirthDate = new DateTime(1992, 1, 5), BaseSalary = 3000.0, Department = d4 };
            Seller s5 = new Seller { Name = "John Black", Email = "john.black@gmail.com", BirthDate = new DateTime(1995, 9, 15), BaseSalary = 2800.0, Department = d1 };
            Seller s6 = new Seller { Name = "Sophie Red", Email = "sophie.red@gmail.com", BirthDate = new DateTime(1988, 11, 20), BaseSalary = 2700.0, Department = d2 };

            SalesRecord sr1 = new SalesRecord { Date = new DateTime(2024, 09, 25), Amount = 11000.0, Status = SalesStatus.Billed, Seller = s1 };
            SalesRecord sr2 = new SalesRecord { Date = new DateTime(2024, 10, 15), Amount = 7000.0, Status = SalesStatus.Pending, Seller = s2 };
            SalesRecord sr3 = new SalesRecord { Date = new DateTime(2024, 09, 10), Amount = 4000.0, Status = SalesStatus.Billed, Seller = s3 };
            SalesRecord sr4 = new SalesRecord { Date = new DateTime(2024, 09, 12), Amount = 3000.0, Status = SalesStatus.Canceled, Seller = s4 };
            SalesRecord sr5 = new SalesRecord { Date = new DateTime(2024, 09, 20), Amount = 8000.0, Status = SalesStatus.Billed, Seller = s5 };
            SalesRecord sr6 = new SalesRecord { Date = new DateTime(2024, 09, 22), Amount = 9000.0, Status = SalesStatus.Pending, Seller = s6 };
            SalesRecord sr7 = new SalesRecord { Date = new DateTime(2024, 10, 01), Amount = 2500.0, Status = SalesStatus.Billed, Seller = s1 };
            SalesRecord sr8 = new SalesRecord { Date = new DateTime(2024, 10, 03), Amount = 1000.0, Status = SalesStatus.Billed, Seller = s2 };
            SalesRecord sr9 = new SalesRecord { Date = new DateTime(2024, 10, 05), Amount = 6000.0, Status = SalesStatus.Canceled, Seller = s3 };
            SalesRecord sr10 = new SalesRecord { Date = new DateTime(2024, 10, 08), Amount = 7200.0, Status = SalesStatus.Pending, Seller = s4 };
            SalesRecord sr11 = new SalesRecord { Date = new DateTime(2024, 10, 10), Amount = 3500.0, Status = SalesStatus.Billed, Seller = s5 };
            SalesRecord sr12 = new SalesRecord { Date = new DateTime(2024, 10, 12), Amount = 6600.0, Status = SalesStatus.Billed, Seller = s6 };
            SalesRecord sr13 = new SalesRecord { Date = new DateTime(2024, 10, 14), Amount = 4900.0, Status = SalesStatus.Pending, Seller = s1 };
            SalesRecord sr14 = new SalesRecord { Date = new DateTime(2024, 10, 17), Amount = 8700.0, Status = SalesStatus.Billed, Seller = s2 };
            SalesRecord sr15 = new SalesRecord { Date = new DateTime(2024, 10, 20), Amount = 5300.0, Status = SalesStatus.Canceled, Seller = s3 };
            SalesRecord sr16 = new SalesRecord { Date = new DateTime(2024, 10, 23), Amount = 9100.0, Status = SalesStatus.Billed, Seller = s4 };
            SalesRecord sr17 = new SalesRecord { Date = new DateTime(2024, 10, 25), Amount = 1200.0, Status = SalesStatus.Pending, Seller = s5 };
            SalesRecord sr18 = new SalesRecord { Date = new DateTime(2024, 10, 27), Amount = 3100.0, Status = SalesStatus.Billed, Seller = s6 };
            SalesRecord sr19 = new SalesRecord { Date = new DateTime(2024, 11, 01), Amount = 7600.0, Status = SalesStatus.Billed, Seller = s1 };
            SalesRecord sr20 = new SalesRecord { Date = new DateTime(2024, 11, 04), Amount = 8500.0, Status = SalesStatus.Pending, Seller = s2 };
            SalesRecord sr21 = new SalesRecord { Date = new DateTime(2024, 11, 06), Amount = 5400.0, Status = SalesStatus.Billed, Seller = s3 };
            SalesRecord sr22 = new SalesRecord { Date = new DateTime(2024, 11, 08), Amount = 1800.0, Status = SalesStatus.Canceled, Seller = s4 };
            SalesRecord sr23 = new SalesRecord { Date = new DateTime(2024, 11, 10), Amount = 2900.0, Status = SalesStatus.Billed, Seller = s5 };
            SalesRecord sr24 = new SalesRecord { Date = new DateTime(2024, 11, 13), Amount = 4100.0, Status = SalesStatus.Pending, Seller = s6 };
            SalesRecord sr25 = new SalesRecord { Date = new DateTime(2024, 11, 15), Amount = 3600.0, Status = SalesStatus.Billed, Seller = s1 };
            SalesRecord sr26 = new SalesRecord { Date = new DateTime(2024, 11, 18), Amount = 4800.0, Status = SalesStatus.Billed, Seller = s2 };
            SalesRecord sr27 = new SalesRecord { Date = new DateTime(2024, 11, 20), Amount = 6100.0, Status = SalesStatus.Canceled, Seller = s3 };
            SalesRecord sr28 = new SalesRecord { Date = new DateTime(2024, 11, 23), Amount = 2750.0, Status = SalesStatus.Billed, Seller = s4 };
            SalesRecord sr29 = new SalesRecord { Date = new DateTime(2024, 11, 25), Amount = 3900.0, Status = SalesStatus.Pending, Seller = s5 };
            SalesRecord sr30 = new SalesRecord { Date = new DateTime(2024, 11, 28), Amount = 4300.0, Status = SalesStatus.Billed, Seller = s6 };


            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(
                 sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10,
                 sr11, sr12, sr13, sr14, sr15, sr16, sr17, sr18, sr19, sr20,
                 sr21, sr22, sr23, sr24, sr25, sr26, sr27, sr28, sr29, sr30
            );

            _context.SaveChanges();
        }

    }
}
