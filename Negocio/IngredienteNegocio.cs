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
        public void setusuario(Usuario usuario)
        {
            this.usuarioLogueado = usuario;
        }
        public List<Ingrediente> ListarIngrediente()
        {
            
            List<Ingrediente> listado = new List<Ingrediente>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Ingrediente Ingre = new Ingrediente();
            try
            {
                accesoDatos.setearConsulta("select  i.Idingrediente, i.NombreIngrediente, i.PrecioIngrediente, u.Descripcioncorta,i.MasterPack,us.Usuario, i.FechaCreacion ,us2.Usuario as UserMod, i.FechaModificacion from INGREDIENTES as i inner join UNIDADDEMEDIDA as u on u.IdUnidad =i.UnidadMedida inner join USUARIOS as us on  us.IdUsuario=i.UsuarioCreacion inner join usuarios as us2 on us2.IdUsuario=i.UsuarioModificacion");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    Ingre = new Ingrediente();
                    Ingre.IdIngrediente = (int)accesoDatos.Lector["IdIngrediente"];
                    Ingre.NombreIngrediente = accesoDatos.Lector["NombreIngrediente"].ToString();
                    Ingre.PrecioIngrediente = (decimal)accesoDatos.Lector["PrecioIngrediente"];
                    Ingre.MasterPack = (decimal)accesoDatos.Lector["MasterPack"];
                    Ingre.UnidadPorIngrediente = new UnidadDeMedida();
                    Ingre.UnidadPorIngrediente.IdUnidad = (int)accesoDatos.Lector["IdIngrediente"];
                    Ingre.UnidadPorIngrediente.DescripcionCorta = accesoDatos.Lector["Descripcioncorta"].ToString();
                  
                    Ingre.UsuarioCreacion = new Usuario();
                    Ingre.UsuarioCreacion.IdUsuario= (int)accesoDatos.Lector["IdIngrediente"];
                    Ingre.UsuarioCreacion.NombreUsuario= accesoDatos.Lector["Usuario"].ToString();
                    Ingre.FechaCreacion = (DateTime)accesoDatos.Lector["FechaCreacion"];
                    Ingre.UsuarioModificacion = new Usuario();
                    Ingre.UsuarioModificacion.IdUsuario = (int)accesoDatos.Lector["IdIngrediente"];
                    Ingre.UsuarioModificacion.NombreUsuario = accesoDatos.Lector["usm"].ToString();
                  
                     Ingre.FechaModificacion = (DateTime)accesoDatos.Lector["FechaModificacion"];
              
                     
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
                comando.CommandText = "SET DATEFORMAT 'DMY' insert into INGREDIENTES (Nombre, StockIngrediente, UnidadMedida, MasterPack, Precio, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) values ('" + nuevo.NombreIngrediente + "','" + nuevo.StockIngrediente + "','" + nuevo.UnidadPorIngrediente.IdUnidad + "','" + nuevo.PrecioIngrediente + "','" + nuevo.MasterPack + "','"+nuevo.FechaCreacion+"','"+nuevo.UsuarioCreacion.IdUsuario+ "','" + nuevo.FechaCreacion + "','" + nuevo.UsuarioCreacion.IdUsuario+  "')";
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

                accesoDatos.setearConsulta("SET DATEFORMAT 'DMY' update INGREDIENTES Set Nombre=@Nombre, StockIngrediente=@StockIngrediente, Precio=@PrecioIngrediente, UnidadMedida=@UnidadMedida, MasterPack=@MasterPack,  FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion where Id=" + modificar.IdIngrediente.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.NombreIngrediente);
                accesoDatos.Comando.Parameters.AddWithValue("@StockIngrediente", modificar.StockIngrediente);
                accesoDatos.Comando.Parameters.AddWithValue("@PrecioIngrediente", modificar.PrecioIngrediente);
                accesoDatos.Comando.Parameters.AddWithValue("@UnidadMedida", modificar.UnidadPorIngrediente.IdUnidad);
                accesoDatos.Comando.Parameters.AddWithValue("@MasterPack", modificar.MasterPack);
                accesoDatos.Comando.Parameters.AddWithValue("@FechaModificacion", modificar.FechaModificacion);
                accesoDatos.Comando.Parameters.AddWithValue("@UsuarioModificacion", modificar.UsuarioModificacion.IdUsuario);


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