using Audit.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Web.Models;

namespace Web.Data
{
    public class ApplicationDbContext : AuditIdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Audit_Employee> Audit_Employees { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmergencyContact> EmergencyContact { get; set; }
        public DbSet<OnboardingItem> OnboardingItem { get; set; }
        public DbSet<Placement> Placement { get; set; }
        public DbSet<SalaryHistory> SalaryHistory { get; set; }
        public DbSet<Dropdown> Dropdowns { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Audit_Company> Audit_Companies { get; set; }
    }
}
