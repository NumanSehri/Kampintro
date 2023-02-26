using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDeneme
{
    class ManagerDal
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
