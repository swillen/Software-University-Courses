﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _05.CallStoredProcedure
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SoftUniEntities : DbContext
    {
        public SoftUniEntities()
            : base("name=SoftUniEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
    
        public virtual ObjectResult<usp_ProjectsForGivenEmployee_Result> usp_ProjectsForGivenEmployee(string empFirstName, string empLastName)
        {
            var empFirstNameParameter = empFirstName != null ?
                new ObjectParameter("empFirstName", empFirstName) :
                new ObjectParameter("empFirstName", typeof(string));
    
            var empLastNameParameter = empLastName != null ?
                new ObjectParameter("empLastName", empLastName) :
                new ObjectParameter("empLastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ProjectsForGivenEmployee_Result>("usp_ProjectsForGivenEmployee", empFirstNameParameter, empLastNameParameter);
        }
    }
}
