using EmployeeManager.Api.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Api.Repositories
{
    //public class EmployeeSqlRepository : IEmployeeRepository
    //{
    //    private readonly AppDbContext db = null;

    //    public EmployeeSqlRepository(AppDbContext db)
    //    {
    //        this.db = db;
    //    }

    //    public List<Employee> SelectAll()
    //    {
    //        List<Employee> data = db.Employees.FromSqlRaw("Select EmployeeID, FirstName from Employees").ToList();

    //        return data;
    //    }

    //}
}
