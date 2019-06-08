    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class TipoComidaNegocio
    {
        public List<TipoComida> ListarTipoComida()
        {

            List<TipoComida> listado = new List<TipoComida>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            TipoComida tipoComi = new TipoComida();
            try
            {

                accesoDatos.setearConsulta("select * from DTIPOCOMIDAS");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    tipoComi = new TipoComida();
                    tipoComi.Id = (int)accesoDatos.Lector["IdTipoComida"];
                    tipoComi.Nombre = accesoDatos.Lector["NombreTipoComida"].ToString();


                    tipoComi.UserAdd = new Usuario();
                    tipoComi.UserAdd.IdUsuario = (int)accesoDatos.Lector["IdTipoComida"];
                    tipoComi.UserAdd.User = accesoDatos.Lector["Usuario"].ToString();
                    tipoComi.F_Add = (DateTime)accesoDatos.Lector["FechaCreacion"];
                    tipoComi.UserMod = new Usuario();
                    tipoComi.UserMod.IdUsuario = (int)accesoDatos.Lector["IdTipoComida"];
                    tipoComi.UserMod.User = accesoDatos.Lector["UserMod"].ToString();
                    tipoComi.F_Mod = (DateTime)accesoDatos.Lector["FechaModificacion"];


                    listado.Add(tipoComi);
                }


                return listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}
