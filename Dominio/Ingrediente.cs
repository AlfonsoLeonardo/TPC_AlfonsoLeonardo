using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ingrediente
    {
        public int IdIngrediente { get; set; }
        public string NombreIngrediente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public decimal StockIngrediente { get; set; }
        public decimal MasterPack { get; set; }
        public decimal PrecioIngrediente { get; set; }
      
    }
}
