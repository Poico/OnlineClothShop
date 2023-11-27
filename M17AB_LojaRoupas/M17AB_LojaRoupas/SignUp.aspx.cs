using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net;

namespace M17AB_LojaRoupas
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUpButton_ServerClick(object sender, EventArgs e)
        {
            BaseDados bd = new BaseDados();
            
            if (bd.devolve_consulta("select count(Nome) from Utilizador where Nome='"+Username1.Value+"'").Rows[0][0].ToString()=="1" && bd.devolve_consulta("select count(Nome) from Utilizador where Email='" + typeEmailX.Value + "'").Rows[0][0].ToString() == "1")
            {
                return;
            }

            if (typePasswordX.Value!=Password2.Value)
            {
                return;
            }


            string HostName = Dns.GetHostName();
            string myIp = Dns.GetHostEntry(HostName).AddressList[2].ToString();

            string StrSql = "Insert into Utilizador(email, Nome, Password, IP)";
            StrSql += "Values(@email,@Nome, HASHBYTES('MD5',@Password), @IP)";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@email",typeEmailX.Value));
            parametros.Add(new SqlParameter("@Nome",Username1.Value));
            parametros.Add(new SqlParameter("@Password",typePasswordX.Value));
            parametros.Add(new SqlParameter("@IP", myIp));

            bd.executa_SQL(StrSql, parametros);
            Response.Redirect("Login.aspx");
        }
    }
}