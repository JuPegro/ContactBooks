using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using SQLConnection.Models;
using System.Data;

namespace Database.Models
{
    public class ContactDataRepository
    {
        private SqlConnection _Connection;

        public ContactDataRepository(SqlConnection connection)
        {
            _Connection = connection;
        }

        #region "CRUD"

        public bool Add(DataContacts item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Contacts(Name,LastName,Address,Phone,PhoneWork) VALUES(@name,@lastname,@address,@phone,@phonework)", _Connection);

            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@lastname", item.LastName);
            command.Parameters.AddWithValue("@address", item.Address);
            command.Parameters.AddWithValue("@phone", item.Phone);
            command.Parameters.AddWithValue("@phonework", item.PhoneWork);

            return ExecuteDml(command);
        }

        public bool Edit(DataContacts item)
        {
            SqlCommand command = new SqlCommand("UPDATE Contacts set Name=@name,LastName=@lastname,Address=@address,Phone=@phone,PhoneWork=@phonework WHERE Id = @id",_Connection);

            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@lastname", item.LastName);
            command.Parameters.AddWithValue("@address", item.Address);
            command.Parameters.AddWithValue("@phone", item.Phone);
            command.Parameters.AddWithValue("@phonework", item.PhoneWork);
            command.Parameters.AddWithValue("@id", item.Id);

            return ExecuteDml(command);
        }

        public bool Deleted(int id)
        {
            SqlCommand command = new SqlCommand("DELETE Contacts WHERE Id = @id ", _Connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public DataContacts GetById(int id)
        {
            try
            {
                _Connection.Open();

                SqlCommand command = new SqlCommand("SELECT Id,Name,LastName,Address,Phone,PhoneWork FROM Contacts WHERE Id = @id", _Connection);

                command.Parameters.AddWithValue("@id",id);

                SqlDataReader reader = command.ExecuteReader();

                DataContacts data = new DataContacts();

                while(reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Name = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.LastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Address = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.Phone = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.PhoneWork = reader.IsDBNull(5) ? "" : reader.GetString(5);
                }

                reader.Close();
                reader.Dispose();

                _Connection.Close();

                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT Id as Codigo,Name as Nombre,LastName as Apellido,Address as Dirección,Phone as Télefono,PhoneWork as TélefonoTrabajo FROM Contacts", _Connection);

            return LoadData(query);
        }

        #endregion

        #region "Main Methods"

        private DataTable LoadData(SqlDataAdapter query)
        {
            try
            {
                DataTable data = new DataTable();

                _Connection.Open();

                query.Fill(data);

                _Connection.Close();

                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private bool ExecuteDml(SqlCommand query)
        {
            try
            {
                _Connection.Open();

                query.ExecuteNonQuery();

                _Connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion
    }
}
