using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySql.Data;

namespace Blazorweb.Data 
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Employee> users_api {get; set;}
    }
}