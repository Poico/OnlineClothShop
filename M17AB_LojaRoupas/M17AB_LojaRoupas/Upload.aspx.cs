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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            //FileUpload foto = (FileUpload)formFile.fin
            BaseDados bd  = new BaseDados();
            string StrSql = "Insert into Modelo(Nome,Tipo,Descricao,Designer,Preco)";
            StrSql += "Values(@Nome,@Tipo,@Descricao,@Designer,@Preco)";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Nome", Nome.Value));
            parametros.Add(new SqlParameter("@Tipo", Tipo.Value));
            parametros.Add(new SqlParameter("@Descricao", Descrisao.Value));
            parametros.Add(new SqlParameter("@Designer", Designer.Value));
            parametros.Add(new SqlParameter("@Preco", Preco.Value));
            bd.executa_SQL(StrSql, parametros);
            
            string id = bd.devolve_consulta("Select IDModelo From Modelo Where Nome='"+Nome.Value+"'").Rows[0][0].ToString();
            string jogoImg = Server.MapPath(@"~\Imagens\Roupa\");

            string ImgName = jogoMainImg.FileName;

            String filename = id;

            jogoImg += filename + ".jpg";
            jogoMainImg.SaveAs(jogoImg);
            
        }
    }
}