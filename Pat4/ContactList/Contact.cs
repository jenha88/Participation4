using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }

        public Contact()
        {
            FirstName = String.Empty;
            LastName = String.Empty;
            Email = String.Empty;
        }
        public Contact(string data)
        {
            var file = data.Split('|');
            FirstName = file[1];
            LastName = file[2];
            Email = file[3];
            Photo = file[4];
        }
        public override string ToString()
        {
            return $"{LastName}  {FirstName}";

        }
    }
}
