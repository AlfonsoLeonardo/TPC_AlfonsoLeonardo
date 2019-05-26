using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
   public class IngredientePorComidaNegocio
    {
 

        
        public List<IngredienteC> ListarIngredienteporcomida()
        {
            

            List<IngredienteC> listado = new List<IngredienteC>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
          
         IngredienteC Ingre = new IngredienteC();
            TipoComida tipoComida = new TipoComida();
            try
            {
                accesoDatos.setearConsulta("select IdIngrediente, NombreIngrediente from  INGREDIENTES");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {

                   Ingre = new IngredienteC();
                   Ingre.Id = (int)accesoDatos.Lector["Idingrediente"];
                   Ingre.Nombre = accesoDatos.Lector["NombreIngrediente"].ToString();
                   /* Ingre.Precio = (decimal)accesoDatos.Lector["PrecioIngrediente"];
                    Ingre.Master = (decimal)accesoDatos.Lector["MasterPack"];
                    Ingre.UM = new UnidadDeMedida();
                    Ingre.UM.IdUnidad = (int)accesoDatos.Lector["IdIngrediente"];
                    Ingre.UM.DescripcionCorta = accesoDatos.Lector["Descripcioncorta"].ToString();
                    Ingre.UserAdd = new Usuario();
                    Ingre.UserAdd.IdUsuario = (int)accesoDatos.Lector["IdIngrediente"];
                    Ingre.UserAdd.User = accesoDatos.Lector["Usuario"].ToString();
                    Ingre.F_Add = (DateTime)accesoDatos.Lector["FechaCreacion"];
                    Ingre.UserMod = new Usuario();
                    Ingre.UserMod.IdUsuario = (int)accesoDatos.Lector["IdIngrediente"];
                    Ingre.UserMod.User = accesoDatos.Lector["UserMod"].ToString();
                    Ingre.F_Mod = (DateTime)accesoDatos.Lector["FechaModificacion"];
                    */

                    listado.Add(Ingre);
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
