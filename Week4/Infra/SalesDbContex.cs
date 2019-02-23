using System;
using System.Collections.Generic;
using System.Text;
using Core;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class SalesDbContex : DbContext
    {
        public SalesDbContex(DbContextOptions<SalesDbContex> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Employee>().ToTable("Employees");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
