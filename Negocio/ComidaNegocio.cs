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
            TipoComida tipoComida = new TipoComida();
            try
            {

                accesoDatos.setearConsulta("select * from DCOMIDAS");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
              
                while (accesoDatos.Lector.Read())
                {
                    Comi = new Comida();
                    Comi.Id = (int)accesoDatos.Lector["IdComida"];
                    Comi.Nombre = accesoDatos.Lector["NombreComida"].ToString();
                    Comi.Precio = (decimal)accesoDatos.Lector["PrecioComida"];
                    Comi.TC = new TipoComida();
                    Comi.TC.Id = (int)accesoDatos.Lector["IdComida"];
                    Comi.TC.Nombre = accesoDatos.Lector["NombreTipoComida"].ToString();
                    Comi.UserAdd = new Usuario();
                    Comi.UserAdd.IdUsuario = (int)accesoDatos.Lector["IdComida"];
                    Comi.UserAdd.User = accesoDatos.Lector["Usuario"].ToString();
                    Comi.F_Add = (DateTime)accesoDatos.Lector["FechaCreacion"];
                    Comi.UserMod = new Usuario();
                    Comi.UserMod.IdUsuario = (int)accesoDatos.Lector["IdComida"];
                    Comi.UserMod.User = accesoDatos.Lector["UserMod"].ToString();
                    Comi.F_Mod = (DateTime)accesoDatos.Lector["FechaModificacion"];

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
        public void agregarComida(Comida nuevo)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearSP("AgregarComida");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@NombreComida", nuevo.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@PrecioComida", nuevo.Precio);
                accesoDatos.Comando.Parameters.AddWithValue("@FechaCreacion", nuevo.F_Add);
                accesoDatos.Comando.Parameters.AddWithValue("@UsuarioCreacion", nuevo.UserAdd.IdUsuario);
                accesoDatos.Comando.Parameters.AddWithValue("@FechaModificacion", nuevo.F_Mod);
                accesoDatos.Comando.Parameters.AddWithValue("@UsuarioModificacion", nuevo.UserMod.IdUsuario);
                accesoDatos.Comando.Parameters.AddWithValue("@Estado", nuevo.Estado);
                accesoDatos.Comando.Parameters.AddWithValue("@TC", nuevo.TC.Id);

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
        public void modificarComida(Comida modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("SET DATEFORMAT 'DMY' update COMIDAS Set NombreComida=@Nombre,  PrecioComida=@Precio,  FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, Estado=@Estado where IdComida=" + modificar.Id);
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@Precio", modificar.Precio);
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
                    agregarComida(nuevo);

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