using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Api.Model
{
    public class WebApiConfig
    {
        public string BaseUrl { get; set; }
        public string EmployeesApiUrl { get; set; }
        public string CountriesApiUrl { get; set; }
    }
}
