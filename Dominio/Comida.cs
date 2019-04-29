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
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public List<IngreditePorComida> ingreditePorComidas { get; set; }
        public float Precio { get; set; }


    }
}
