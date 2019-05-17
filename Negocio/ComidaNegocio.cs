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
        private Usuario usuarioLogueado;
        public void setusuario(Usuario usuario)
        {
            this.usuarioLogueado = usuario;
        }
        public List<Comida> ListarComida()
        {
           
            List<Comida> listado = new List<Comida>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Comida Comi = new Comida();
            try
            {
                
                accesoDatos.setearConsulta("select IdComida, NombreComida, PrecioComida From COMIDAS");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
               ;
                while (accesoDatos.Lector.Read())
                {
                    Comi= new Comida();
                    Comi.IdComida=(int)accesoDatos.Lector["IdComida"];
                    Comi.NombreComida = accesoDatos.Lector["NombreComida"].ToString();
               
                    Comi.Precio = (decimal)accesoDatos.Lector["PrecioComida"];
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
               accesoDatos.cerrarConexion();
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
                comando.CommandText = "SET DATEFORMAT 'DMY' insert into COMIDAS (NombreComida, PrecioComida, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) values ('" + nuevo.NombreComida + "','" + nuevo.Precio + "','" + nuevo.FechaCreacion + "','" + /*nuevo.UsuarioCreacion*/1 + "','" + nuevo.FechaCreacion + "','" + /*nuevo.UsuarioCreacion*/1 + "')";
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
        public void modificarComida(Comida modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("SET DATEFORMAT 'DMY' update COMIDAS Set NombreComida=@Nombre,  PrecioComida=@Precio=" + modificar.IdComida.ToString());
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
        public void eliminarComida(Comida nuevo)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();

            try
            {
                accesoDatos.setearConsulta("DELETE FROM COMIDAS WHERE IdComida=" + nuevo.IdComida);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

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

