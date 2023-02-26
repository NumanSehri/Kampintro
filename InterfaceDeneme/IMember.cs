using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDeneme
{
    interface IMember
    {
        public int Id { get; set; }
        public string NationalIdenty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
