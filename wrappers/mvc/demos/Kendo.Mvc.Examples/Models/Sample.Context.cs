﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kendo.Mvc.Examples.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SampleEntities : DbContext
    {
        public SampleEntities()
            : base("name=SampleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Category> Categories { get; set; }
        public DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Intraday> Intradays { get; set; }
        public DbSet<MeetingAttendee> MeetingAttendees { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Order_Detail> Order_Details { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Territory> Territories { get; set; }
        public DbSet<Weather> Weathers { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<GanttDependency> GanttDependencies { get; set; }
        public DbSet<GanttTask> GanttTasks { get; set; }
        public DbSet<UrbanArea> UrbanAreas { get; set; }
        public DbSet<EmployeeDirectory> EmployeeDirectory { get; set; }
        public DbSet<OrgChart> OrgCharts { get; set; }
        public DbSet<OrgChartConnection> OrgChartConnections { get; set; }
    }
}
