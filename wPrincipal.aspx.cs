using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspModulo2
{
    public partial class wPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lLogin.Text = "";
            if (Request.Cookies["login"] != null)
            {
                lLogin.Text = Request.Cookies["login"].Value;
                lsenha.Text = Request.Cookies["senha"].Value;
            }
        }

        protected void btExecutar_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["login"] != null)
            {
                //Response.Cookies.Remove("login");
                Request.Cookies.Clear();
                //Response.Cookies.AllKeys
            }
        }

        protected void btListar_Click(object sender, EventArgs e)
        {
            var keys = Request.Cookies.AllKeys;
            String texto = "<p>";
            String pos = "";

            for (int i = 0; i < Request.Cookies.Count; i++)
            {
                pos = keys[i];
                texto += pos + ":" + Request.Cookies[pos].Value + " ";
            }
            texto += "</p>";
            Response.Write(texto);
    }
    } }