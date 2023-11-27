using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Data;

namespace M17AB_LojaRoupas
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BaseDados bd = new BaseDados();
            container.InnerHtml+= bd.devolve_consulta("Select DISTINCT count(IP) From Utilizador");
            container.InnerHtml += "<p> </p>";
            container.InnerHtml += bd.devolve_consulta("Select count(ID) From Utilizador");
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            BaseDados bd = new BaseDados();
            DataTable dt = bd.devolve_consulta("Select email From Utilizador");
            foreach (DataRow dr in dt.Rows)
            {
                MailMessage mail = new MailMessage("esengpsi12@gmail.com", dr.ToString());

                // Configurar a mensagem a enviar
                mail.From = new MailAddress("esengpsi12@gmail.com");
                mail.Subject = "CloverStudios - Novos descontos";
                mail.Body = String.Format("O nosso site está com novos descontos", HttpContext.Current.Request.Url.AbsoluteUri.Substring(0, (HttpContext.Current.Request.Url.AbsoluteUri).Length - 10));

                // Configurar a conta de email para envio
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new System.Net.NetworkCredential("esengpsi12", "navarro2020");

                // Envio para o destinatário o email
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }

        }
    }
}