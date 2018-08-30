using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace granjaElvin.Models
{
    public class Cerda
    {
        public int idCerda { get; set; }
        public string raza { get; set; }

        public Cerda(int idCerda, string raza)
        {
            this.idCerda = idCerda;
            this.raza = raza;
        }
    }
}
