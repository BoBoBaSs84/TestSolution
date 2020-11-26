﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.IdentityModel.Protocols;
using SqlConsoleApp.SqlContext.Models;

namespace SqlConsoleApp.SqlContext.Data
{
    public partial class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmployeeAvailableVacation> EmployeeAvailableVacation { get; set; }
        public virtual DbSet<EmployeeWeeklyWorkingHours> EmployeeWeeklyWorkingHours { get; set; }
        public virtual DbSet<GetEmployeInfo> GetEmployeInfo { get; set; }
        public virtual DbSet<GetPresenceAbscenceOverview> GetPresenceAbscenceOverview { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["SqlDatabase"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeAvailableVacation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmployeeAvailableVacation", "app");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTill).HasColumnType("date");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<EmployeeWeeklyWorkingHours>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmployeeWeeklyWorkingHours", "app");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTill).HasColumnType("date");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<GetEmployeInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetEmployeInfo", "app");

                entity.Property(e => e.Gid)
                    .HasColumnName("GID")
                    .HasMaxLength(8);

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameShortPhone).HasMaxLength(100);

                entity.Property(e => e.Organisation).HasMaxLength(200);

                entity.Property(e => e.PeopleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeopleSurname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Scdcompany)
                    .HasColumnName("SCDCompany")
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(30);
            });

            modelBuilder.Entity<GetPresenceAbscenceOverview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetPresenceAbscenceOverview", "app");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DayName).HasMaxLength(30);

                entity.Property(e => e.DayType).HasMaxLength(50);

                entity.Property(e => e.MonthName).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}