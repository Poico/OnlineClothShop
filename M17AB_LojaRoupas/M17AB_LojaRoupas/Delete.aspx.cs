using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M17AB_LojaRoupas
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            BaseDados BD = new BaseDados();
            BD.executa_SQL("DELETE From Modelo Where IDModelo='" + Text1.Value + "'");
        }

    }
}