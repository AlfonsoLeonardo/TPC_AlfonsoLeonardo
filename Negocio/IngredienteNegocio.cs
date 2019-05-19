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
        private Usuario usuarioLogueado;
    
        public List<Ingrediente> ListarIngrediente()
        {
            
            List<Ingrediente> listado = new List<Ingrediente>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Ingrediente Ingre = new Ingrediente();
            try
            {
                accesoDatos.setearConsulta("select  i.Idingrediente , i.NombreIngrediente, i.PrecioIngrediente, u.Descripcioncorta,i.MasterPack,us.Usuario, i.FechaCreacion ,us2.Usuario as UserMod, i.FechaModificacion from INGREDIENTES as i inner join UNIDADDEMEDIDA as u on u.IdUnidad =i.UnidadMedida inner join USUARIOS as us on  us.IdUsuario=i.UsuarioCreacion inner join usuarios as us2 on us2.IdUsuario=i.UsuarioModificacion where i.Estado=1 ");
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
                    Ingre.UserAdd.IdUsuario= (int)accesoDatos.Lector["IdIngrediente"];
                    Ingre.UserAdd.NombreUsuario= accesoDatos.Lector["Usuario"].ToString();
                    Ingre.F_Add = (DateTime)accesoDatos.Lector["FechaCreacion"];
                    Ingre.UserMod = new Usuario();
                    Ingre.UserMod.IdUsuario = (int)accesoDatos.Lector["IdIngrediente"];
                    Ingre.UserMod.NombreUsuario = accesoDatos.Lector["UserMod"].ToString();
                  
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
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = "data source=(local); initial catalog=ALFONSO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SET DATEFORMAT 'DMY' insert into INGREDIENTES (NombreIngrediente, StockIngrediente, UnidadMedida, MasterPack, PrecioIngrediente, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, Estado) values ('" + nuevo.Nombre + "','" + nuevo.Stock + "','" + nuevo.UM.IdUnidad + "','" + nuevo.Precio + "','" + nuevo.Master + "','"+nuevo.F_Add+"','"+/*nuevo.UsuarioCreacion.IdUsuario*/1+ "','" + nuevo.F_Add + "','" + /*nuevo.UsuarioCreacion.IdUsuario*/1+ "','" + nuevo.estado+ "')";
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

                accesoDatos.setearConsulta("SET DATEFORMAT 'DMY' update INGREDIENTES Set NombreIngrediente=@Nombre, StockIngrediente=@StockIngrediente, PrecioIngrediente=@PrecioIngrediente, UnidadMedida=@UnidadMedida, MasterPack=@MasterPack,  FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion where IdIngrediente=" + modificar.Id);
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@StockIngrediente", modificar.Stock);
                accesoDatos.Comando.Parameters.AddWithValue("@PrecioIngrediente", modificar.Precio);
                accesoDatos.Comando.Parameters.AddWithValue("@UnidadMedida", modificar.UM.IdUnidad);
                accesoDatos.Comando.Parameters.AddWithValue("@MasterPack", modificar.Master);
                accesoDatos.Comando.Parameters.AddWithValue("@FechaModificacion", modificar.F_Mod);
                accesoDatos.Comando.Parameters.AddWithValue("@UsuarioModificacion", 1);


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
    }
}