using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspModulo2
{
    public partial class wLogin : System.Web.UI.Page
    {
        List<String> Usuarios;
 
        String SenhaPadrao = "aspLuiza";

       
 
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuarios = new List<string>();
            Usuarios.Add("lulu");
            Usuarios.Add("lulu1");
            Usuarios.Add("lulu2");


            if (Request.Cookies["login"] != null)
            {
                txtLogin.Text = Request.Cookies["login"].Value;
                txtSenha.Text = Request.Cookies["senha"].Value;
                btnExecutar_Click(sender, e);

            }
        }
        protected void btnExecutar_Click(object sender, EventArgs e)
        {

            Boolean flag = false;
            foreach (var item in Usuarios)

            {
                if (item == txtLogin.Text && SenhaPadrao == txtSenha.Text)
                {
                    HttpCookie login = new HttpCookie("login", txtLogin.Text);
                    Response.Cookies.Add(login);                  
                    HttpCookie senha = new HttpCookie("senha", txtSenha.Text);
                    Response.Cookies.Add(senha);
                    Response.Redirect("~/wPrincipal.aspx");
                }
            }
           
        }
    }
}