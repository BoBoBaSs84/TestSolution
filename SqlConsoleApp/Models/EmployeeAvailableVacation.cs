﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace SqlConsoleApp.SqlContext.Models
{
    public partial class EmployeeAvailableVacation
    {
        public int Id { get; set; }
        public int IdMitarbeiter { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTill { get; set; }
        public int VacationDays { get; set; }
    }
}