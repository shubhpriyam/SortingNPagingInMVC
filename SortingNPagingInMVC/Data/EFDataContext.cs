using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SortingNPagingInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingNPagingInMVC.Data
{
    public class EFDataContext : DbContext
    {
        public EFDataContext(DbContextOptions<EFDataContext> opt) : base(opt)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Employee> Employees { get; set; }


        //public Employee GetEmployeeById(int employeeId)
        //{
        //    IQueryable<Employee> data = this.Employees.FromSqlRaw<Employee>(
        //        "Exec [dbo].uspGetEmployee " +
        //            "@p_EmployeeId", new SqlParameter("p_EmployeeId", employeeId));

        //    if (data != null)
        //        return data.FirstOrDefault();
        //    else
        //        return new Employee();
        //}
    }
}
