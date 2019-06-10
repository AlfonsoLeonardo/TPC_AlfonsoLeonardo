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
        public List<Ingrediente> ListarIngredientecc(int id)
        {
            List<Ingrediente> listado = new List<Ingrediente>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Ingrediente Ingre = new Ingrediente();
            TipoComida tipoComida = new TipoComida();
            try
            {
                accesoDatos.setearConsulta("select DISTINCT i.Idingrediente, i.NombreIngrediente, ic.IdComidas,  ic.Cantidad from INGREDIENTES as i left join INGREDIETESPORCOMIDAS as ic on I.IdIngrediente=ic.IdIngredientes and ic.IdComidas=@comida	where  i.Estado=1 and ic.IdComidas is null");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@comida", id);

                accesoDatos.abrirConexion();

                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    Ingre = new Ingrediente();
                    Ingre.Id = (int)accesoDatos.Lector["Idingrediente"];
                    Ingre.Nombre = accesoDatos.Lector["NombreIngrediente"].ToString();
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


        public List<IngreditePorComida> ListarIngredienteporcomida(int id)
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
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    Ingre = new IngreditePorComida();
                    Ingre.Ingrediente = new Ingrediente();
                    Ingre.Ingrediente.Id = (int)accesoDatos.Lector["IdIngrediente"];
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
