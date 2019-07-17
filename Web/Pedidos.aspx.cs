using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Dominio;
using Negocio;

namespace Web
{
    public partial class Pedidos : System.Web.UI.Page
    {
        
        public List<Comida> comidas = new List<Comida>();
        public List<TipoComida> tipoComidas = new List<TipoComida>();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void cargar(int yy, int xx)
        {
            ComidaPorOrdenNegocio comidaPorOrdenNegocio = new ComidaPorOrdenNegocio();

            comidas = comidaPorOrdenNegocio.ListarComida(xx, yy);
        }
        public void listaTipoComidaw()
        {
            TipoComidaNegocio tipoComidaNegocio = new TipoComidaNegocio();
            tipoComidas = tipoComidaNegocio.ListarTipoComida();
        }
       
        public static List<Comida> listaComi()
        {
            ComidaPorOrdenNegocio comidaPorOrdenNegocio = new ComidaPorOrdenNegocio();

            List<Comida> lista = null;
            try
            {
                lista = comidaPorOrdenNegocio.ListarComida(22,22);

            }catch(Exception ex)
            {
                lista = null;
            }
            return lista;
        }
        [WebMethod]
        public static List<TipoComida> listaTipoComidas()
        {
            TipoComidaNegocio tipoComidaNegocio = new TipoComidaNegocio();

            List<TipoComida> lista = null;
            try
            {
                lista = tipoComidaNegocio.ListarTipoComida();
            }
            catch (Exception ex)
            {
                lista = null;
            }
            return lista;
        }
    }   
}