using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace M17AB_LojaRoupas
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void butaoComentario_ServerClick(object sender, EventArgs e)
        {

            BaseDados bd = new BaseDados();
            if (comentario.Value.Length!=0)
            {
                string strSQL = "Insert into Comentarios(IDCliente,IDModelo,Descrisao)";
                strSQL += "Values(@IDCliente,@IDModelo,@Descrisao)";
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@IDCliente",Session["user"].ToString()));
                parameters.Add(new SqlParameter("@IDModelo", Request.QueryString["Roupa"].ToString()));
                parameters.Add(new SqlParameter("@Descrisao", comentario.Value));

                bd.executa_SQL(strSQL, parameters);
                Page.Response.Redirect(Page.Request.Url.ToString(), true);
            }
            
        }

        protected void Favorito_ServerClick(object sender, EventArgs e)
        {
            BaseDados bd = new BaseDados();
            if (bd.devolve_consulta("Select count(ID) From Favoritos Where IDCliente="+ Session["user"].ToString()+ "and IDRoupa="+ Request.QueryString["Roupa"].ToString()).ToString()=="0")
            {
                string StrSql = "Insert into Favoritos(IDCliente, IDRoupa)";
                StrSql += "Values(@IDCliente, @IDRoupa)";
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(new SqlParameter("@IDCliente", Session["user"].ToString()));
                parametros.Add(new SqlParameter("@IDRoupa", Request.QueryString["Roupa"].ToString()));

                bd.executa_SQL(StrSql, parametros);
                Response.Redirect("Roupa.aspx?roupa="+ Request.QueryString["roupa"]);
            }
        }

        protected void Carrinho_ServerClick(object sender, EventArgs e)
        {
            BaseDados bd = new BaseDados();
            string sql = "Insert INTO Carrinho (IDModelo, IDCliente)";
            sql += "Values(@IDModelo, @IDCliente)";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IDModelo", Request.QueryString["Roupa"].ToString()));
            parametros.Add(new SqlParameter("@IDCliente", Session["user"].ToString()));
            bd.devolve_consulta(sql, parametros);
        }
        public void Media() 
        {
            DataTable dt = new DataTable();
            BaseDados bd = new BaseDados();
            dt = bd.devolve_consulta("Select AVG(Rating) From Rating where IDModelo='"+ Request.QueryString["Roupa"].ToString() + "'");

            bd.executa_SQL("UPDATE Modelo SET Rating=" + dt.Rows[0][0]+ " where IDModelo='" + Request.QueryString["Roupa"].ToString() + "'");
        }
        protected void Unnamed_ServerClick1(object sender, EventArgs e)
        {
            BaseDados bd = new BaseDados();
            string SQL;
            SQL= "Insert INTO Rating (IDModelo, Rating)";
            SQL += "Values(@IDModelo,@Rating)";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IDModelo", Request.QueryString["Roupa"].ToString()));
            parametros.Add(new SqlParameter("Rating", 1));
            bd.executa_SQL(SQL,parametros);
            Media();
        }
        protected void Unnamed_ServerClick2(object sender, EventArgs e)
        {

            BaseDados bd = new BaseDados();
            string SQL;
            SQL = "Insert INTO Rating(IDModelo, Rating)";
            SQL += "Values(@IDModelo,@Rating)";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IDModelo", Request.QueryString["Roupa"].ToString()));
            parametros.Add(new SqlParameter("Rating", 2));
            bd.executa_SQL(SQL, parametros);
            Media();

        }
        protected void Unnamed_ServerClick3(object sender, EventArgs e)
        {

            BaseDados bd = new BaseDados();
            string SQL;
            SQL = "Insert INTO Rating(IDModelo, Rating)";
            SQL += "Values(@IDModelo,@Rating)";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IDModelo", Request.QueryString["Roupa"].ToString()));
            parametros.Add(new SqlParameter("Rating", 3));
            bd.executa_SQL(SQL, parametros);
            Media();
        }
        protected void Unnamed_ServerClick4(object sender, EventArgs e)
        {

            BaseDados bd = new BaseDados();
            string SQL;
            SQL = "Insert INTO Rating(IDModelo, Rating)";
            SQL += "Values(@IDModelo,@Rating)";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IDModelo", Request.QueryString["Roupa"].ToString()));
            parametros.Add(new SqlParameter("Rating", 4));
            bd.executa_SQL(SQL, parametros);
            Media();
        }
        protected void Unnamed_ServerClick5(object sender, EventArgs e)
        {

            BaseDados bd = new BaseDados();
            string SQL;
            SQL = "Insert INTO Rating(IDModelo, Rating)";
            SQL += "Values(@IDModelo,@Rating)";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IDModelo", Request.QueryString["Roupa"].ToString()));
            parametros.Add(new SqlParameter("Rating", 5));
            bd.executa_SQL(SQL, parametros);
            Media();
        }
    }
}