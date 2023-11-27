using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace M17AB_LojaRoupas
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int temp = 0;
            BaseDados bd = new BaseDados();
            DataTable dt = new DataTable();
            dt = bd.devolve_consulta("Select * From Modelo Inner JOIN Carrinho ON Modelo.IDModelo = Carrinho.IDModelo where  Carrinho.IDCliente = "+Session["user"]);
            foreach (DataRow item in dt.Rows)
            {
                temp++;
                string nome= item[1].ToString();
                string tipo = item[2].ToString();
                double Preco= Convert.ToDouble(item[7].ToString());
                TableBody.InnerHtml += "<tr>";
                TableBody.InnerHtml += "<th scope = 'row' >"+temp+"</ th >";
                TableBody.InnerHtml += "<td>"+nome+"</ td >";
                TableBody.InnerHtml += "<td>"+tipo+"</ td >";
                TableBody.InnerHtml += "<td>"+Preco+"</ td >";
                TableBody.InnerHtml += "</ tr >";
            }
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            BaseDados bd = new BaseDados();
            bd.executa_SQL("DELETE FROM Carrinho WHERE IDCliente="+Session["user"]);
        }
    }
}