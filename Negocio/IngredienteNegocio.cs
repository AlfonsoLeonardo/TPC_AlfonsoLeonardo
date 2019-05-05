using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using Negocio;
using AccesoDatos;


namespace Negocio
{
    public class IngredienteNegocio
    {
        public List<Ingrediente> ListarIngrediente()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader Lector;
            List<Ingrediente> listado = new List<Ingrediente>();
            //AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Ingrediente Ingre = new Ingrediente();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //accesoDatos.setearConsulta( 
                comando.CommandText = ("select Id, Nombre, StockIngrediente, MasterPack, Precio From INGREDIENTES");
                comando.Connection = conexion;
                conexion.Open();
                Lector = comando.ExecuteReader();
                //accesoDatos.abrirConexion();
                // accesoDatos.ejecutarConsulta();
                while (Lector.Read())
                {
                    Ingre = new Ingrediente();
                    Ingre.IdIngrediente = (int)Lector["Id"];
                    Ingre.NombreIngrediente = Lector["Nombre"].ToString();
                    Ingre.StockIngrediente = (decimal)Lector["StockIngrediente"];
                    Ingre.MasterPack = (decimal)Lector["MasterPack"];
                    Ingre.PrecioIngrediente = (decimal)Lector["Precio"];
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
                conexion.Close();
                //accesoDatos.cerrarConexion();
            }
        }


        public void agregarIngrediente(Ingrediente nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = "data source=(local); initial catalog=ALFONSO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into INGREDIENTES (Nombre, StockIngrediente, MasterPack, Precio, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) values ('" + nuevo.NombreIngrediente + "','" + nuevo.StockIngrediente + "','" + nuevo.PrecioIngrediente + "','" + nuevo.MasterPack + "','"+nuevo.FechaCreacion+"','"+nuevo.UsuarioCreacion+ "','" + nuevo.FechaCreacion + "','" + nuevo.UsuarioCreacion+  "')";
                comando.Connection = conexion;
                conexion.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
        public void modificarIngrediente(Ingrediente modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update INGREDIENTES Set Nombre=@Nombre, StockIngrediente=@StockIngrediente, Precio=@PrecioIngrediente, MasterPack=@MasterPack,  FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion where Id=" + modificar.IdIngrediente.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.NombreIngrediente);
                accesoDatos.Comando.Parameters.AddWithValue("@StockIngrediente", modificar.StockIngrediente);
                accesoDatos.Comando.Parameters.AddWithValue("@PrecioIngrediente", modificar.PrecioIngrediente);
                accesoDatos.Comando.Parameters.AddWithValue("@MasterPack", modificar.MasterPack);
                accesoDatos.Comando.Parameters.AddWithValue("@FechaModificacion", modificar.FechaModificacion);
                accesoDatos.Comando.Parameters.AddWithValue("@UsuarioModificacion", modificar.UsuarioModificacion);


                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();

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