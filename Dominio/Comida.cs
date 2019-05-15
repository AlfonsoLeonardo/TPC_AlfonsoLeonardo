using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Comida
    {
        public int IdComida { get; set; }
        public string NombreComida { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Usuario UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public Usuario UsuarioModificacion { get; set; }
        //public List<IngreditePorComida> ingreditePorComidas { get; set; }
      


    }
}
