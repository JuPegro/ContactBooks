using Database.Models;
using SQLConnection.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace BusinessLayers
{
    public class ContactService
    {
        private ContactDataRepository repository;

        public ContactService(SqlConnection connection)
        {
            repository = new ContactDataRepository(connection);
        }

        #region "Methods"
        public bool Add(DataContacts item)
        {
            return repository.Add(item);
        }

        public bool Edit(DataContacts item)
        {
            return repository.Edit(item);
        }

        public bool Delete(int id)
        {
            return repository.Deleted(id);
        }

        public DataContacts GetById(int id)
        {
            return repository.GetById(id);
        }

        public DataTable GetAll()
        {
            return repository.GetAll();
        }

        #endregion
    }
}
