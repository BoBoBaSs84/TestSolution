﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PieceOfTime.SqlContext.Models
{
    public partial class GetEmployeInfo
    {
        public string PeopleName { get; set; }
        public string PeopleSurname { get; set; }
        public string Gid { get; set; }
        public string Mail { get; set; }
        public string Telephone { get; set; }
        public string NameShortPhone { get; set; }
        public string Organisation { get; set; }
        public string Scdcompany { get; set; }
        public bool? IsExtern { get; set; }
        public bool? IsHead { get; set; }
        public int? IdMitarbeiter { get; set; }
        public int? IdOrganisation { get; set; }
        public double? OverHours { get; set; }
        public int? AbsenceDays { get; set; }
        public int? MissingPresenceDays { get; set; }
        public double? WeeklyWorkingHours { get; set; }
        public int? AvailableVacationDays { get; set; }
        public int? PlannedVacationDays { get; set; }
        public int? VacationDays { get; set; }
        public int? ShortTimeDays { get; set; }
        public int? SicknessDays { get; set; }
    }
}