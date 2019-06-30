using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class ComidaPorOrdenNegocio
    {
        public List<Comida> ListarComida(int x,int y)
        {

            List<Comida> listado = new List<Comida>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Comida Comi = new Comida();
            TipoComida tipoComida = new TipoComida();
            try
            {
                if (y == 9999)
                {
                    accesoDatos.setearConsulta("select c.IdComida, c.NombreComida, c.PrecioComida, TC.NombreTipoComida  from COMIDAS as c inner join  TIPOCOMIDA as tc on tc.IdTipoComida=c.TC where tc=@Tipo order by TC");
                    accesoDatos.Comando.Parameters.Clear();
                    accesoDatos.Comando.Parameters.AddWithValue("@Tipo", x);
                    
                }
                else
                {                    
                    accesoDatos.setearConsulta("select c.IdComida, c.NombreComida, c.PrecioComida, TC.NombreTipoComida  from COMIDAS as c inner join  TIPOCOMIDA as tc on tc.IdTipoComida=c.TC where c.TC=@Tipo or c.TC=@Tipo2  order by TC");
                    accesoDatos.Comando.Parameters.Clear();
                    accesoDatos.Comando.Parameters.AddWithValue("@Tipo", x);
                    accesoDatos.Comando.Parameters.AddWithValue("@Tipo2", y);
                }
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
    }
}
