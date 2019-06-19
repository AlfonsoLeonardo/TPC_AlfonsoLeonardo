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

            List<Ingrediente> listado = new List<Ingrediente>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Ingrediente Ingre = new Ingrediente();
            TipoComida tipoComida = new TipoComida();
            try
            {
                accesoDatos.setearConsulta("select* from  DINGREDIENTES");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    Ingre = new Ingrediente();
                    Ingre.Id = (int)accesoDatos.Lector["Idingrediente"];
                    Ingre.Nombre = accesoDatos.Lector["NombreIngrediente"].ToString();
                    Ingre.Precio = (decimal)accesoDatos.Lector["PrecioIngrediente"];
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
        public void agregarIngrediente(Ingrediente nuevo)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearSP("AgregarIngrediente");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@NombreIngrediente", nuevo.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@StockIngrediente", nuevo.Precio);
                accesoDatos.Comando.Parameters.AddWithValue("@UnidadMedida", nuevo.UM.IdUnidad);
                accesoDatos.Comando.Parameters.AddWithValue("@MasterPack", nuevo.Master);
                accesoDatos.Comando.Parameters.AddWithValue("@PrecioIngrediente",nuevo.Precio);
                accesoDatos.Comando.Parameters.AddWithValue("@FechaCreacion", nuevo.F_Add);
                accesoDatos.Comando.Parameters.AddWithValue("@UsuarioCreacion",nuevo.UserAdd.IdUsuario);
                accesoDatos.Comando.Parameters.AddWithValue("@FechaModificacion",nuevo.F_Mod);
                accesoDatos.Comando.Parameters.AddWithValue("@UsuarioModificacion", nuevo.UserMod.IdUsuario);
                accesoDatos.Comando.Parameters.AddWithValue("@Estado",nuevo.estado);

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
        public void modificarIngrediente(Ingrediente modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("SET DATEFORMAT 'DMY' update INGREDIENTES Set NombreIngrediente=@Nombre, StockIngrediente=@StockIngrediente, PrecioIngrediente=@PrecioIngrediente, UnidadMedida=@UnidadMedida, MasterPack=@MasterPack,  FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, Estado=@Estado where IdIngrediente=" + modificar.Id);
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@StockIngrediente", modificar.Stock);
                accesoDatos.Comando.Parameters.AddWithValue("@PrecioIngrediente", modificar.Precio);
                accesoDatos.Comando.Parameters.AddWithValue("@UnidadMedida", modificar.UM.IdUnidad);
                accesoDatos.Comando.Parameters.AddWithValue("@MasterPack", modificar.Master);
                accesoDatos.Comando.Parameters.AddWithValue("@FechaModificacion", modificar.F_Mod);
                accesoDatos.Comando.Parameters.AddWithValue("@UsuarioModificacion", modificar.UserMod.IdUsuario);
                accesoDatos.Comando.Parameters.AddWithValue("@Estado", modificar.estado);

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
        public void eliminarIngrediente(Ingrediente nuevo)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();

            try
            {
                accesoDatos.setearConsulta("update INGREDIENTES Set Estado = @Estado where IdIngrediente = " + nuevo.Id);

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
        public bool validarIngrediente(Ingrediente nuevo)
        {

            AccesoDatosManager conexion;
            try
            {
                conexion = new AccesoDatosManager();
                conexion.setearConsulta("select IdIngrediente, Estado, NombreIngrediente from INGREDIENTES Where NombreIngrediente=@Nombre");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre);

                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                if (conexion.Lector.Read())
                {

                    nuevo.estado = (bool)conexion.Lector["Estado"];
                    if (false == nuevo.estado)
                    {
                        // nuevo.Id = (int)conexion.Lector["IdIngrediente"];
                        nuevo.Id = (int)conexion.Lector["IdIngrediente"];
                        nuevo.estado = true;
                        modificarIngrediente(nuevo);
                        return false;

                    }
                    return true;
                }
                else
                {
                    nuevo.estado = true;
                    agregarIngrediente(nuevo);

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