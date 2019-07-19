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
        public string Imagen { get; set; }
        public bool Estado { get; set; }

        public TipoComida() { }
        public TipoComida(int Id, string Nombre, DateTime F_Add, Usuario UserAdd, DateTime F_Mod, Usuario UserMod, string Imagen, bool Estado)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.F_Add = F_Add;
            this.UserAdd = UserAdd;
            this.F_Mod = F_Mod;
            this.UserMod = UserMod;
            this.Imagen = Imagen;
            this.Estado = Estado;
        }

        //public override string ToString()
        //{
        //    return Nombre;
        //}
    }
}
