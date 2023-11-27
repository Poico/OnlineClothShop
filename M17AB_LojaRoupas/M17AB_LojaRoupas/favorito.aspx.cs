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
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BaseDados bd = new BaseDados();
            DataTable dt = new DataTable();
            dt = bd.devolve_consulta("Select * From Modelo, Favoritos Where Favoritos.IDModelo=Modelo.IDModelo and Favoritos.IDCliente='"+Session["user"]+"'");
            foreach (DataRow item in dt.Rows)
            {
                int id = int.Parse(item["IDModelo"].ToString());
                string nome = item["Nome"].ToString();
                string Descrisao = item["descricao"].ToString();
                float Preco = float.Parse(item["Preco"].ToString());
                float Rating = float.Parse(item["Rating"].ToString());
                Favoritos.InnerHtml += "<div class='card' style='width: 18rem;'>";
                Favoritos.InnerHtml += "<img src = 'Imagens/Roupa/"+id+".png' class='card-img-top' style='width: 286px; height:286px;'>";
                Favoritos.InnerHtml += "<div class='card-body'>";
                Favoritos.InnerHtml += "<h5 class='card-title'>"+nome+"</h5>";
                Favoritos.InnerHtml += "<p class='card-text'>Rating:" + Rating + "★</p>";
                Favoritos.InnerHtml += "<p class='card-text'>Preço:" + Math.Round(Preco, 2) + "€</p>";
                Favoritos.InnerHtml += "<p class='card-text'>"+Descrisao+"</p>";
                Favoritos.InnerHtml += "<a href='Roupa.aspx? Roupa ="+id+"' class='btn btn-primary'>Saber Mais</a>";
                Favoritos.InnerHtml += "</div>";
                Favoritos.InnerHtml += "</div>";


            }
        }
    }
}