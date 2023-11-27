using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace M17AB_LojaRoupas
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void loginbutton_click(object sender, EventArgs e)
        {
            BaseDados bd = new BaseDados();
            string sql = "select count(Nome) from Utilizador where email = '" + typeEmailX.Value + "' and Password = HASHBYTES('MD5',@pass)";
            List<SqlParameter> sp = new List<SqlParameter>();
            sp.Add(new SqlParameter("@pass", typePasswordX.Value));
            DataTable login = bd.devolve_consulta(sql, sp);
            if (login.Rows[0][0].ToString() == "1")
            {
                string IP = bd.devolve_consulta("Select IP from Utilizador where email='" + typeEmailX.Value + "'").Rows[0][0].ToString();
                string hostName = Dns.GetHostName();
                string myIP = Dns.GetHostEntry(hostName).AddressList[2].ToString();
                if (IP != null)
                {
                    if (myIP != IP)
                    {
                        MailMessage mail = new MailMessage("esengpsi12@gmail.com", typeEmailX.Value);

                        // Configurar a mensagem a enviar
                        mail.From = new MailAddress("esengpsi12@gmail.com");
                        mail.Subject = "CloverStudios - Entrada com um IP diferente";
                        mail.Body = String.Format("Por favor verifique se foi você a acessar o nosso site com um IP diferente do habitual se não foi substitua a sua password.", HttpContext.Current.Request.Url.AbsoluteUri.Substring(0, (HttpContext.Current.Request.Url.AbsoluteUri).Length - 10));

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
                if (bd.devolve_consulta("Select count(Admin) from Utilizador where email='" + typeEmailX.Value + "'").Rows[0][0].ToString() == "0")
                {
                    Session["user"] = bd.devolve_consulta("Select ID from Utilizador where email='" + typeEmailX.Value + "'").Rows[0][0].ToString();
                }
                else if (bd.devolve_consulta("Select count(Admin) from Utilizador where email='" + typeEmailX.Value + "' and Admin='True'").Rows[0][0].ToString() == "1")
                {
                    Session["admin"] = typeEmailX.Value;
                }
                if (Chk_lembrar.Checked)
                {
                    Response.Cookies["username"].Value = typeEmailX.Value;
                    Response.Cookies["password"].Value = typePasswordX.Value;
                }
                Response.Redirect("index.aspx");
            }
            else
            {
                lbl_Password.ForeColor = System.Drawing.Color.Red;
                lbl_Email.ForeColor = System.Drawing.Color.Red;
                labelTopo.Text = "Houve um erro no seu Login porfavor tente de novo";
            }
        }
    }
}