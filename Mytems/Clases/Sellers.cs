using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Mytems.Clases
{
    class Sellers
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public object CredenciaImage { get; set; }
        public object proof_of_address { get; set; }

        public override string ToString()
        {
            return $"{FirstName}-{LastName}-{Address}-{PhoneNumber}-{CredenciaImage}-{proof_of_address}";
        }

    }
}
