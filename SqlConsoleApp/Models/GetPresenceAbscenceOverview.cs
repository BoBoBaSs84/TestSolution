﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace SqlConsoleApp.SqlContext.Models
{
    public partial class GetPresenceAbscenceOverview
    {
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string MonthName { get; set; }
        public int? Week { get; set; }
        public DateTime? Date { get; set; }
        public string DayName { get; set; }
        public string DayType { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public double? WorkingHours { get; set; }
        public double? OverHours { get; set; }
        public int? IdCalendarTable { get; set; }
        public int? IdMitarbeiter { get; set; }
        public int? IdOrganisation { get; set; }
    }
}