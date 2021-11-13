using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayers
{
    public sealed class ContactRepository
    {

        public static ContactRepository Instance { get; } = new ContactRepository();

        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public int? SelectIndex = null;

        private ContactRepository()
        {

        }


    }
}
