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
    public class EmployeeEFRepository : IEmployeeRepository
    {
        private readonly AppDbContext db = null;

        public EmployeeEFRepository(AppDbContext db)
        {
            this.db = db;
        }

        public List<Employee> SelectAll()
        {
            List<Employee> data = (from e in db.Employees
                                   orderby e.UsernameID
                                   select e).ToList();
            return data;


        }

        public Employee SelectByID(int id)
        {
            Employee model = db.Employees.FirstOrDefault(x => x.UsernameID == id);

            return model;
        }

        public void Insert(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
        }

        public void Update(Employee emp)
        {
            db.Employees.Update(emp);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Employee emp = db.Employees.Where(x => x.UsernameID == id).FirstOrDefault();
            db.Employees.Remove(emp);
            db.SaveChanges();
        }

    }
}
