using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public TipoUsuario Tipo { get; set; }
        public bool Estado { get; set; }

        public static Usuario UsuarioLogin { get; set; }



        public override string ToString()
        {
            return User;
        }
    }

}


