using EmployeeManager.Api.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Api.Repositories
{
    public class CountryStProcRepository : ICountryRepository
    {
        private AppDbContext db = null;

        public CountryStProcRepository(AppDbContext db) 
        {
            this.db = db; 
        }

        public List<Country> SelectAll()
        {
            //List<Country> data = db.Countries.FromSqlRaw("EXEC Countries_SelectAll").ToList();

            return Enumerable.Empty<Country>().ToList();
        }
    }
}
