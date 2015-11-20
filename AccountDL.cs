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

        public static void CreateAccount(string fName, string lName, string address1, string address2, string phone, string city, string state, string zip, DateTime dateOfBirth)
        {
            string sqlText;
            sqlText = "EmployeeInsert";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sqlText, connection);
            command.CommandType = CommandType.StoredProcedure;

        }
    }
}
