using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace Mytems.Clases
{
    class Compradores
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set;  }

        public String nameBuyer { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{nameBuyer} - {Address} - {PhoneNumber}- {LastName}";
        }
    }
}
