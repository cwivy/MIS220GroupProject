using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace MIS220GroupProject
{
    public static class MemberDL
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["Data Source = mis220.eil - server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide"].ConnectionString;
<<<<<<< HEAD


        //-----------Methods-----------

=======
        
>>>>>>> origin/master
        public static string ConnectionString
        {
            get {  return MemberDL.connectionString; }
            set { MemberDL.connectionString = value; }
        }



        public static int CreateAccount(string fName, string lName, string address1, string address2, string phone, string city, string state, int zip, DateTime dateOfBirth)
        {
            string sqlText;

            sqlText = "INSERT INTO Member(FirstName, LastName, DOB, Address1, Address2, City, State, Zip, Phone)";
            sqlText += "VALUES(@firstName, @lastName, @DOB, @address1, @address2, @city, @state, @zip, @phone)";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sqlText, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@firstName", fName);
            command.Parameters.AddWithValue("@lastName", lName);
            command.Parameters.AddWithValue("@DOB", dateOfBirth);
            command.Parameters.AddWithValue("@address1", address1);
            command.Parameters.AddWithValue("@address2", address2);
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@state", state);
            command.Parameters.AddWithValue("@zip", zip);
            command.Parameters.AddWithValue("@phone", phone);

            connection.Open();

            int result = command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();

            return result;
        }

    }
}
