using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class TipoComida
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime F_Add { get; set; }
        public Usuario UserAdd { get; set; }
        public DateTime F_Mod { get; set; }
        public Usuario UserMod { get; set; }
        public bool Estado { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
