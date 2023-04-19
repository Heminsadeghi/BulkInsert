using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkInsertWithAdoNet.Model
{
    public class Person
    {

        public int ID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Suffix { set; get; }
        public string Email { set; get; }
        public string AdditionalContactInfo { set; get; }
        public DateTime ModifiedDate { set; get; }
        public DateTime CreateDate { set; get; }
        

    }
}
