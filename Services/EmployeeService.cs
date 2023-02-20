using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blazorweb.Data;
using MySql.EntityFrameworkCore;
using MySql.Data;

namespace Blazorweb.Services
{
    public class EmployeeService 
    {
        private readonly AppDbContext _appDBContext;
        public EmployeeService(AppDbContext appDbContext)
        {
            _appDBContext = appDbContext;
        }

        public async Task<List<Employee>> GetAllEmployeesAsync() 
        {
            return await _appDBContext.users_api.Take(10).ToListAsync();
        }

        public async Task<bool> Insertusers(Employee users_api)
        {
            await _appDBContext.users_api.AddRangeAsync(users_api);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        public async Task<Employee> GetEmployeeAsync(int id)
        {
            Employee users_api = await _appDBContext.users_api.FirstOrDefaultAsync(c => c.id.Equals(id));
            return users_api;
        }

        public async Task<bool> UpdateusersAsync(Employee employee)
        {
            _appDBContext.users_api.Update(employee);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}