using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mytems.Clases;
using SQLite;


namespace Mytems.Clases
{
    class Registro
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set;  }
        public string Lastname { get; set; }
        public string Username { get; set;  }
        public string Email { get; set; }
        public string Password { get; set;  }

        public override string ToString()
        {
            return $"{Name} - {Lastname} - {Username} - {Email} - {Password}";
        }

    }

}


