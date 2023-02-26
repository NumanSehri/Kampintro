using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDeneme
{
    class SchoolService 
    {
        

        public void Add(IMember member)
        { 
           
            Console.WriteLine(member.FirstName + " Veri Eklendi");
        }
    }
}
