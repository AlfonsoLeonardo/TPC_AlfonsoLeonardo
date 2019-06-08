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
       /* public List<IngreditePorComida> validarIngredientepc(IngredienteC nuevo, int id)
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
                    return nuevo.Cantidad = (decimal)conexion.Lector["Cantidad"];   

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
            

        }*/


        public List<IngreditePorComida> ListarIngredienteporcomida( int id)
        {
            

            List<IngreditePorComida> listado = new List<IngreditePorComida>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
          
            IngreditePorComida Ingre = new IngreditePorComida();
            TipoComida tipoComida = new TipoComida();
            try
            {
                accesoDatos.setearConsulta("select i.IdIngrediente, i.NombreIngrediente,  ic.Cantidad  from INGREDIENTES as i inner join INGREDIETESPORCOMIDAS as ic on i.IdIngrediente= ic.IdIngredientes	where IdComidas=@Idcomida and ic.Estado=1");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Idcomida", id);
               // accesoDatos.Comando.Parameters.AddWithValue("@IdIngrediente", nuevo.Id);

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    
                   Ingre = new IngreditePorComida();
                    Ingre.Ingrediente = new Ingrediente();

                    Ingre.Ingrediente.Id= (int)accesoDatos.Lector["IdIngrediente"];
                    Ingre.Ingrediente.Nombre = accesoDatos.Lector["NombreIngrediente"].ToString();
                    Ingre.Cantidad = (decimal)accesoDatos.Lector["Cantidad"];


                  
                   

                 

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
