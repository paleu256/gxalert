﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GxAlert
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GxAlertEntities : DbContext
    {
        public GxAlertEntities()
            : base("name=GxAlertEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<country> countries { get; set; }
        public DbSet<device> devices { get; set; }
        public DbSet<devicedeploymenthistory> devicedeploymenthistories { get; set; }
        public DbSet<lga> lgas { get; set; }
        public DbSet<person> people { get; set; }
        public DbSet<rawmessage> rawmessages { get; set; }
        public DbSet<region> regions { get; set; }
        public DbSet<resulttestcode> resulttestcodes { get; set; }
        public DbSet<state> states { get; set; }
        public DbSet<test> tests { get; set; }
        public DbSet<testresult> testresults { get; set; }
        public DbSet<notificationcountry> notificationcountries { get; set; }
        public DbSet<notificationdeployment> notificationdeployments { get; set; }
        public DbSet<notificationlga> notificationlgas { get; set; }
        public DbSet<notificationperson> notificationpersons { get; set; }
        public DbSet<notificationregion> notificationregions { get; set; }
        public DbSet<notificationresult> notificationresults { get; set; }
        public DbSet<notificationstate> notificationstates { get; set; }
        public DbSet<notification> notifications { get; set; }
        public DbSet<notificationlog> notificationlogs { get; set; }
        public DbSet<deployment> deployments { get; set; }
        public DbSet<apilog> apilogs { get; set; }
        public DbSet<partner> partners { get; set; }
        public DbSet<devicetype> devicetypes { get; set; }
        public DbSet<testtype> testtypes { get; set; }
    }
}
