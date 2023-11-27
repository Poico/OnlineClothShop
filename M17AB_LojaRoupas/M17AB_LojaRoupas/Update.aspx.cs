using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace M17AB_LojaRoupas
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            BaseDados BD = new BaseDados();
            DataTable dt =BD.devolve_consulta("Select * From Modelo Where IDModelo='" + Text1.Value+"'");
            Nome.Value = dt.Rows[0][1].ToString();
            Tipo.Value = dt.Rows[0][2].ToString();
            Promocao.Value = dt.Rows[0][3].ToString();
            Designer.Value = dt.Rows[0][6].ToString();
            Preco.Value = dt.Rows[0][7].ToString();
            Descrisao.Value = dt.Rows[0][5].ToString();
        }
        protected void Submit(object sender, EventArgs e)
        {
            BaseDados BD = new BaseDados();
            string StrSql = "Update Modelo SET Nome="+ Nome.Value + ",Tipo="+Tipo.Value+",Descricao="+Descrisao.Value+",Designer="+Designer.Value+",Preco="+Preco.Value;
            BD.executa_SQL(StrSql);
        }
    }
}