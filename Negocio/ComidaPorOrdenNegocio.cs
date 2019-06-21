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
        public List<ComidaM> ListarComida(int x,int y)
        {

            List<ComidaM> listado = new List<ComidaM>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            ComidaM Comi = new ComidaM();
            TipoComida tipoComida = new TipoComida();
            try
            {
                if (y == 9999)
                {
                    accesoDatos.setearConsulta("select * from COMIDAS where tc=@Tipo");
                    accesoDatos.Comando.Parameters.Clear();
                    accesoDatos.Comando.Parameters.AddWithValue("@Tipo", x);
                    
                }
                else
                {
                    
                    accesoDatos.setearConsulta("select * from COMIDAS where tc=@Tipo or TC=@Tipo2 order by TC");
                    accesoDatos.Comando.Parameters.Clear();
                    accesoDatos.Comando.Parameters.AddWithValue("@Tipo", x);
                    accesoDatos.Comando.Parameters.AddWithValue("@Tipo2", y);
                }
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    Comi = new ComidaM();
                    Comi.Id = (int)accesoDatos.Lector["IdComida"];
                    Comi.Nombre = accesoDatos.Lector["NombreComida"].ToString();
                    Comi.Precio = (decimal)accesoDatos.Lector["PrecioComida"];
                    Comi.C = 0;
                

                    Comi.observacion = "                               ";
                   

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
