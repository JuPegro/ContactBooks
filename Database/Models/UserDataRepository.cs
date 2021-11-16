using SQLConnection.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Database.Models
{
    public class UserDataRepository
    {
        private SqlConnection _connection;

        public UserDataRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        #region "Methods"

        public bool Add(DataUser item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Users(Name,LastName,UserName,Password) VALUES(@name,@lastname,@username,@password)", _connection);

            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@lastname", item.LastName);
            command.Parameters.AddWithValue("@username", item.UserName);
            command.Parameters.AddWithValue("@password", item.Password);

            return ExecuteDml(command);
        }

        public bool CheckUser(string username)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("SELECT UserName FROM Users WHERE UserName = @username)", _connection);

                command.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = command.ExecuteReader();

                DataUser data = new DataUser();

                while (reader.Read())
                {
                    data.UserName = reader.IsDBNull(0) ? "" : reader.GetString(0);
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return data;

            }
            catch (Exception ex)
            {
                return default;
            }
        }

        public bool Login(string username, string password)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("SELECT UserName,PassWord FROM Users WHERE UserName = @username and PassWord = @password", _connection);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();

                DataUser data = new DataUser();

                while (reader.Read())
                {
                    data.UserName = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    data.Password = reader.IsDBNull(1) ? "" : reader.GetString(1);
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion


        #region "Main Methods"

        private bool ExecuteDml(SqlCommand query)
        {
            try
            {
                _connection.Open();

                query.ExecuteNonQuery();

                _connection.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        #endregion
    }
}
