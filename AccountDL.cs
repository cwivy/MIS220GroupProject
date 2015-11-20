using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace MIS220GroupProject
{
    public static class AccountDL
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["Data Source = mis220.eil - server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide"].ConnectionString;

        public static string ConnectionString
        {
            get {  return AccountDL.connectionString; }
            set { AccountDL.connectionString = value; }
        }

        //-----------Methods-----------

    }
}
