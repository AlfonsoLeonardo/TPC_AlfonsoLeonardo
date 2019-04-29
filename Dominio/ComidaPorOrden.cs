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
        public Comida Comida { set; get; }
        public float Cantidad { set; get; }
    }
}
