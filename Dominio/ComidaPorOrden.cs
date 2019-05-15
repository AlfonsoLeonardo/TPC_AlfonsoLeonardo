using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ComidadPorOrden
    {
        public Orden orden { set; get; }
        public List<Comida> Comida { set; get; }
        public DateTime FechaCreacion { get; set; }
        public Usuario UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public Usuario UsuarioModificacion { get; set; }
        public float Cantidad { set; get; }
    }
}
