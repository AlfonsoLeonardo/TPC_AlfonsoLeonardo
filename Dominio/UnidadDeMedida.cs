using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class UnidadDeMedida
    {
        public int IdUnidad { get; set; }
        public string DescripcionCorta { get; set; }
        public string DescripcionLarga { get; set; }    
        public bool Estado { get; set; }

        public override string ToString()
        {
            return DescripcionCorta;
        }
    }
}
