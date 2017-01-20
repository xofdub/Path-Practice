using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunClassFun
{
   public class DatabaseExamples
    {
        public static void InsertUsingSqlString()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();


                var cmd = new SqlCommand("INSERT INTO UserData (Email) VALUES ('somethingdifferent@poop.com')", conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();

            }

        }
        private const string ConnectionString = "Server = (localdb)\\ProjectsV13; Database = funWithMatt; Trusted_Connection = True; ";

        public static void InsertUsingStoredProcedure()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                var cmd = new SqlCommand("sp_InsertUser", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@email", System.Data.SqlDbType.NVarChar, 100).Value = "someStuff";

                cmd.ExecuteNonQuery();

            }
        


        }

        public static List<User> ReadAllUsers()
        {
            var users = new List<User>();

            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                var cmd = new SqlCommand("sp_ReadFunUser", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var email = reader["email"].ToString();
                        var userID = Convert.ToInt32(reader["userID"]);
                        int stophere = 7;

                        var user = new User();
                        user.Email = email;
                        user.UserID = userID;

                        users.Add(user);

            
                    }
                }
                reader.Close();
            }

            return users;
        }
    }
}
