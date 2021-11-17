using System;
using System.Collections.Generic;
using System.Text;

namespace SQLConnection.Models
{
    public class DataContacts
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string PhoneWork { get; set; }

        public int IdUser { get; set; }

    }
}
