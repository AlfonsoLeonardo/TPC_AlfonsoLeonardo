using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class ComidaPorOrdenNegocio
    {
        public List<ComidaM> ListarComidaMEmpanada()
        {

            List<ComidaM> listado = new List<ComidaM>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            ComidaM Comi = new ComidaM();
            TipoComida tipoComida = new TipoComida();
            try
            {

                accesoDatos.setearConsulta("select * from COMIDAS where tc=2");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    Comi = new ComidaM();
                    Comi.Id = (int)accesoDatos.Lector["IdComida"];
                    Comi.Nombre = accesoDatos.Lector["NombreComida"].ToString();
                    Comi.Precio = (decimal)accesoDatos.Lector["PrecioComida"];
                    Comi.Cantidad = 0;
                   

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
