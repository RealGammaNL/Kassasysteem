using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DAL
{
    static public class UserDAL
    {
        private static string ConnectionString = "Data Source=LAPTOP-MDHQ0DL3;Initial Catalog = KassasysteemDB; Persist Security Info=True;User ID = sa; Password=123max";
        public static void AddUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "INSERT INTO Users (SecurityLevel, Firstname, Lastname, Email, Password, Birthdate) VALUES (@SecurityLevel, @Firstname, @Lastname, @Email, @Password, @Birthdate)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@SecurityLevel", user.SecurityLevel);
                        command.Parameters.AddWithValue("@Firstname", user.Firstname);
                        command.Parameters.AddWithValue("@Lastname", user.Lastname);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.Parameters.AddWithValue("@Birthdate", user.Birthdate);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex;  }

        }

        public static void DeleteUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "DELETE Users WHERE id = @Id";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", user.Id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static void UpdateUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT * FROM Users";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                users.Add(new User((int)reader["ID"]
                                                    , reader["SecurityLevel"].ToString()
                                                    , reader["Firstname"].ToString()
                                                    , reader["Lastname"].ToString()
                                                    , reader["Email"].ToString()
                                                    , reader["Password"].ToString()
                                                    , (DateTime)reader["Birthdate"]
                                                    ));
                            }
                        }
                    }
                }
                return users;
            }
            catch (SqlException ex) { throw ex; }
        }
    }
}
