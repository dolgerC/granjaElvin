using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace granjaElvin.Models
{
    public class Medicamento
    {
        public string nombre { get; set; }

        public Medicamento(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
