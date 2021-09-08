using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProBE;

namespace ProDAL
{
    public class PersonalDetailDAL
    {
        string _connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        /// <summary>
        /// Loads all records from the database
        /// </summary>
        /// <returns></returns>
        public DataTable LoadAll()
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = _connStr;
                string sql = "SELECT * FROM PersonalDetail ORDER BY FirstName";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        ad.Fill(table);
                    }
                }
            }

            return table;
        }

        /// <summary>
        /// Searches the data from the database based on First name
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public DataTable Search(string firstName)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = _connStr;
                string sql = "SELECT * FROM PersonalDetail WHERE FirstName LIKE @firstName ORDER BY FirstName";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    firstName = firstName + "%";

                    cmd.Parameters.AddWithValue("@firstName", firstName);

                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        ad.Fill(table);
                    }
                }
            }

            return table;
        }



        /// <summary>
        /// insert a record into the PersonalDetail table
        /// </summary>
        /// <param name="person">PersonalDetail object</param>
        /// <returns></returns>
        public int AddRecord(PersonalDetail person)
        {
            int returnResult = 0;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = _connStr;
                string sql = "INSERT INTO PersonalDetail (FirstName, LastName, Age, Active) VALUES " + 
                    "(@FirstName, @LastName, @Age, @isActive)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", person.LastName);
                    cmd.Parameters.AddWithValue("@Age", person.Age);
                    cmd.Parameters.AddWithValue("@IsActive", person.Active);
                    conn.Open();
                    returnResult= cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            return returnResult;
        }


    }
}
