using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Web
{
    public partial class Pedidos : System.Web.UI.Page
    {
       
        public List<Comida> comidas = new List<Comida>();
       

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void cargar(int yy, int xx)
        {
            ComidaPorOrdenNegocio comidaPorOrdenNegocio = new ComidaPorOrdenNegocio();

            comidas = comidaPorOrdenNegocio.ListarComida(xx, yy);
        }
    }   
}