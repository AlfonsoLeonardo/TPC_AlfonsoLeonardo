using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Stock { get; set; }
        public decimal Master { get; set; }
        public UnidadDeMedida UM { get; set; }
        public decimal Precio { get; set; }
        public DateTime F_Add { get; set; }
        public Usuario UserAdd { get; set; }
        public DateTime F_Mod { get; set; }
        public Usuario UserMod { get; set; }
        public bool estado { get; set; }


    }
}
