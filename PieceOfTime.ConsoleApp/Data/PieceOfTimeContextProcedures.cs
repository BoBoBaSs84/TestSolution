﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using PieceOfTime.SqlContext.Models;

namespace PieceOfTime.SqlContext.Data
{
    public partial class PieceOfTimeContextProcedures
    {
        private readonly PieceOfTimeContext _context;

        public PieceOfTimeContextProcedures(PieceOfTimeContext context)
        {
            _context = context;
        }

        public async Task<CGetPresenceAbscenceOverviewResult[]> GetPresenceAbscenceOverview(string Login, DateTime? DateFrom, DateTime? DateTill, OutputParameter<int> returnValue = null)
        {
            var parameterLogin = new SqlParameter
            {
                ParameterName = "Login",
                Size = 256,
                Value = Login ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
            };

            var parameterDateFrom = new SqlParameter
            {
                ParameterName = "DateFrom",
                Value = DateFrom ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Date,
            };

            var parameterDateTill = new SqlParameter
            {
                ParameterName = "DateTill",
                Value = DateTill ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Date,
            };

            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var _ = await _context.SqlQuery<CGetPresenceAbscenceOverviewResult>("EXEC @returnValue = [app].[GetPresenceAbscenceOverview] @Login, @DateFrom, @DateTill", parameterLogin, parameterDateFrom, parameterDateTill, parameterreturnValue);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
