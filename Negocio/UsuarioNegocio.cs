using Dominio;
using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {
      
        public bool validarUsuario(Usuario usuario)
        {
            
            AccesoDatosManager conexion;
            try
            {
                conexion = new AccesoDatosManager();
                conexion.setearConsulta("select IdUsuario, Usuario, Pass, NombreUsuario, ApellidoUsuario, IdTipoUsuario from USUARIOS Where Usuario=@usuario and Pass=@pass");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@usuario", usuario.User);
                conexion.Comando.Parameters.AddWithValue("@pass", usuario.Pass);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                if (conexion.Lector.Read())
                {
                    usuario.IdUsuario = (int)conexion.Lector["IdUsuario"];
                    usuario.User = (string)conexion.Lector["Usuario"];
                    usuario.Pass = (string)conexion.Lector["Pass"];
                    usuario.Nombre = (string)conexion.Lector["NombreUsuario"];
                    usuario.Apellido = (string)conexion.Lector["ApellidoUsuario"];
                    usuario.Tipo = new TipoUsuario();
                    usuario.Tipo.Id = (int)conexion.Lector["IdTipoUsuario"];

                    Usuario.UsuarioLogin = usuario;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
