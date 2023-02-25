using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Miras-İnheritance
    class CompanyCustomer:Customer
    {
        //Coorporate
        public int Id { get; set; }
        public string CompanyNumber { get; set; }

        public string CompanyName { get; set; }

        public string TaxNumber { get; set; }
    }
}
