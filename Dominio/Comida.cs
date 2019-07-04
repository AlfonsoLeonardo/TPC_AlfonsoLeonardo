using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Dominio
{
    public class Comida
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public TipoComida TC { get; set; }
        public int Cantidad { get; set; }
        public DateTime F_Add { get; set; }
        public Usuario UserAdd { get; set; }
        public DateTime F_Mod { get; set; }
        public Usuario UserMod { get; set; }
        public bool Estado { get; set; }
    }

    public class ComidaM
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int C { get; set; }
        public DataGridViewButtonColumn R { get; set; }
        public DataGridViewButtonColumn M { get; set; }
        public string observacion { get; set; }
    }



}
