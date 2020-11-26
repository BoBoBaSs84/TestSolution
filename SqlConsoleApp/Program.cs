using System;
using System.Linq;

namespace SqlConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LoadingAllData
            using (var context = new SqlContext.Data.SqlContext())
            {
                var gei = context.GetEmployeInfo.ToList();
                foreach (var item in gei)
                {
                    Console.WriteLine($"{item.NameShortPhone}");
                }
            }
            #endregion
        }
    }
}