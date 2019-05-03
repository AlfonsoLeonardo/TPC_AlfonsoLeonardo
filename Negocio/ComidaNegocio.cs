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
    public class ComidaNegocio
    {
        public List<Comida> ListarComida()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader Lector;
            List<Comida> listado = new List<Comida>();
            //AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Comida Comi = new Comida();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //accesoDatos.setearConsulta( 
                comando.CommandText = ("select Id, Nombre, Precio From COMIDAS");
                comando.Connection = conexion;
                conexion.Open();
                Lector = comando.ExecuteReader();
                //accesoDatos.abrirConexion();
                // accesoDatos.ejecutarConsulta();
                while (Lector.Read())
                {
                    Comi= new Comida();
                    Comi.IdComida=(int)Lector["Id"];
                    Comi.NombreComida = Lector["Nombre"].ToString();
               
                    Comi.Precio = (decimal)Lector["Precio"];
                    listado.Add(Comi);
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


        public void agregarcomida(Comida nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = "data source=(local); initial catalog=ALFONSO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into COMIDAS (Nombre, Precio, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) values ('" + nuevo.NombreComida + "','" + nuevo.Precio + "','" + nuevo.FechaCreacion + "','" + nuevo.UsuarioCreacion + "','" + nuevo.FechaCreacion + "','" + nuevo.UsuarioCreacion + "')";
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
        public void modificarIngrediente(Comida modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update COMIDAS Set Nombre=@Nombre,  MasterPack=@MasterPack, Precio=@Precio=" + modificar.IdComida.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.NombreComida);
                accesoDatos.Comando.Parameters.AddWithValue("@Precio", modificar.NombreComida);
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

