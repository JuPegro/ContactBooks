using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayers
{
    public class ContactService
    {
        #region "Methods"
        public void Add(Contact item)
        {
            ContactRepository.Instance.Contacts.Add(item);
        }

        public void Edit(int index, Contact item)
        {
            ContactRepository.Instance.Contacts[index] = item;
        }

        public void Delete(int index)
        {
            ContactRepository.Instance.Contacts.RemoveAt(index);
        }

        public Contact GetById(int index)
        {
            return ContactRepository.Instance.Contacts[index];
        }

        public List<Contact> GetAll()
        {
            return ContactRepository.Instance.Contacts;
        }

        #endregion
    }
}
