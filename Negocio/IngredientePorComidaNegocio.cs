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
        public decimal validarIngredientepc(IngredienteC nuevo, int id)
        {
            
            AccesoDatosManager conexion;
            try
            {
                conexion = new AccesoDatosManager();
                conexion.setearConsulta("select i.IdIngrediente, ic.IdComidas, ic.Cantidad, ic.Estado from INGREDIENTES as i left join INGREDIETESPORCOMIDAS as ic on i.IdIngrediente= ic.IdIngredientes	where IdComidas=@Idcomida and IdIngredientes=@IdIngrediente");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@Idcomida", id);
                conexion.Comando.Parameters.AddWithValue("@IdIngrediente", nuevo.Id);

                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                if (conexion.Lector.Read())
                {

                    /*  id = (int)conexion.Lector["IdIngrediente"];
                  if (nuevo.Id ==id )
                      {
                      */

                    // conexion.cerrarConexion();            
                    return nuevo.Cantidad = (decimal)conexion.Lector["Cantidad"];   

                    //  }
                    // return false;
                }
                else
                {

                    //conexion.cerrarConexion();
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        public List<IngredienteC> ListarIngredienteporcomida(int xxx)
        {
            

            List<IngredienteC> listado = new List<IngredienteC>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
          
            IngredienteC Ingre = new IngredienteC();
            TipoComida tipoComida = new TipoComida();
            try
            {
                accesoDatos.setearConsulta("select IdIngrediente, NombreIngrediente from  INGREDIENTES where estado=1");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {

                   Ingre = new IngredienteC();
                   Ingre.Id = (int)accesoDatos.Lector["Idingrediente"];
                   Ingre.Nombre = accesoDatos.Lector["NombreIngrediente"].ToString();
                   Ingre.Cantidad  = validarIngredientepc(Ingre, xxx);

                    if (Ingre.Cantidad > 0)
                    {
                        Ingre.Agregar = true;
                    }
                    else { Ingre.Agregar = false; }

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
