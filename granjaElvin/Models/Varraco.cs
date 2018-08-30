using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace granjaElvin.Models
{
    public class Varraco
    {
        public int idVarraco { get; set; }
        public string raza { get; set; }

        public Varraco(int idVarraco, string raza)
        {
            this.idVarraco = idVarraco;
            this.raza = raza;
        }
    }
}
