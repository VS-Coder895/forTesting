using System;

namespace DataAccessLayer
{
    internal static class DataAccessSettings
    {
        public static readonly string ConnectionString =
            //"Server=.;Database=Car_Rental_DB;User Id=sa;Password=123456;";
            "Server=.;Database=Car_Rental_DB; Trusted_Connection=true;";
    }
}