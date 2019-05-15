using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class IngreditePorComida
    {
        public List<Ingrediente> ingrediente { set; get; }
        public DateTime FechaCreacion { get; set; }
        public Usuario UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public Usuario UsuarioModificacion { get; set; }
        public decimal Cantidad { set; get; }

    }
}
