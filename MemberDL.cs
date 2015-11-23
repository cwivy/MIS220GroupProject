using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace MIS220GroupProject
{
    /*public static*/ class MemberDL
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["Data Source = mis220.eil - server.cba.ua.edu; Initial Catalog = MovieRental; user id =uamis; password=RollTide"].ConnectionString;
        
        public static string ConnectionString
        {
            get {  return MemberDL.connectionString; }
            set { MemberDL.connectionString = value; }
        }

        //-----------Methods-----------

        public int CreateAccount(string fName, string lName, string address1, string address2, string phone, string city, string state, string zip, DateTime dateOfBirth)
        {
            string sqlText;


            sqlText = "INSERT INTO Member(FirstName, LastName, DOB, Address1, Address2, City, State, Zip, Phone)";
            sqlText += "VALUES(@firstName, @lastName, @DOB, @address1, @address2, @city, @state, @zip, @phone)";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sqlText, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@FirstName", fName);
            command.Parameters.AddWithValue("@LastName", lName);
            command.Parameters.AddWithValue("@BirthDate", dateOfBirth);
            command.Parameters.AddWithValue("@Address1", address1);
            command.Parameters.AddWithValue("@Address2", address2);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@State", state);
            command.Parameters.AddWithValue("@Zip", zip);
            command.Parameters.AddWithValue("@Phone", phone);

            connection.Open();

            int result = command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();

            return result;
        }
    }
}
