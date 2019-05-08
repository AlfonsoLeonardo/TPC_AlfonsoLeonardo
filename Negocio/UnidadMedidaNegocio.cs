using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;

namespace Negocio
{
    public class UnidadMedidaNegocio
    {
        public List<UnidadDeMedida> listarUnidadMedida()
        {
            List<UnidadDeMedida> listado = new List<UnidadDeMedida>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            UnidadDeMedida uniMed = new UnidadDeMedida();
            try
            {
                accesoDatos.setearConsulta("Select Id, Descripcioncorta from UNIDADDEMEDIDA");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    uniMed = new UnidadDeMedida();
                    uniMed.IdUnidadMedida = (int)accesoDatos.Lector["Id"];
                    uniMed.DescripcionCorta = accesoDatos.Lector["Descripcioncorta"].ToString();
                    listado.Add(uniMed);
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

