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

            List<Comida> listado = new List<Comida>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Comida Comi = new Comida();
            try
            {

                accesoDatos.setearConsulta("select IdComida, NombreComida, PrecioComida From COMIDAS where Estado=1");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                ;
                while (accesoDatos.Lector.Read())
                {
                    Comi = new Comida();
                    Comi.Id = (int)accesoDatos.Lector["IdComida"];
                    Comi.Nombre = accesoDatos.Lector["NombreComida"].ToString();

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
                comando.CommandText = "SET DATEFORMAT 'DMY' insert into COMIDAS (NombreComida, PrecioComida, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, Estado) values ('" + nuevo.Nombre + "','" + nuevo.Precio + "','" + nuevo.F_Add + "','" + nuevo.UserAdd.IdUsuario + "','" + nuevo.F_Add + "','" + nuevo.UserMod.IdUsuario + "','" + nuevo.Estado + "')";
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

                accesoDatos.setearConsulta("SET DATEFORMAT 'DMY' update COMIDAS Set NombreComida=@Nombre,  PrecioComida=@Precio=" + modificar.Id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@Precio", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@FechaModificacion", modificar.F_Mod);
                accesoDatos.Comando.Parameters.AddWithValue("@UsuarioModificacion", modificar.UserMod.IdUsuario);
                accesoDatos.Comando.Parameters.AddWithValue("@Estado", modificar.Estado);
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
                accesoDatos.setearConsulta("update COMIDAS Set Estado=@Estado where IdComida =" + nuevo.Id);

                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Estado", false);
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
        public bool validarComida(Comida nuevo)
        {

            AccesoDatosManager conexion;
            try
            {
                conexion = new AccesoDatosManager();
                conexion.setearConsulta("select IdComida, Estado, NombreComida from COMIDAS Where NombreComida=@Nombre");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);

                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                if (conexion.Lector.Read())
                {

                    nuevo.Estado = (bool)conexion.Lector["Estado"];
                    if (false == nuevo.Estado)
                    {

                        nuevo.Id = (int)conexion.Lector["IdComida"];
                        nuevo.Estado = true;
                        modificarComida(nuevo);
                        return false;

                    }
                    return true;
                }
                else
                {
                    nuevo.Estado = true;
                    agregarcomida(nuevo);

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