using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Orden
    {
        public int IdOrden { set; get; }
        public int NuemeroOrdenDiario { set; get; }
        public DateTime FechaRegistro { set; get; }
        public DateTime FechaCreacion { get; set; }
        public Usuario UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public Usuario UsuarioModificacion { get; set; }
        public float PrecioOrden {set; get;}
    }
}
