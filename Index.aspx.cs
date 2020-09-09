using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Newtonsoft.Json;

namespace JSONbase
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            //Instanciamo la clase persona
            Persona persona = new Persona
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Edad = Convert.ToInt32(txtEdad.Text),
                correo = txtCorreo.Text,
                Numero = Convert.ToInt32(txtNumero.Text)
            };
            txtNombre.Text = " ";
            txtApellido.Text = " ";
            txtEdad.Text = " ";
            txtCorreo.Text = " ";
            txtNumero.Text = " ";
            if (Session["ARCHIVOJSON"].ToString() == string.Empty)
                Session["ARCHIVOJSON"] = JsonConvert.SerializeObject(persona);
            else
                Session["ARCHIVOJSON"] = Session["ARCHIVOJSON"].ToString() + "," + JsonConvert.SerializeObject(persona);
            lblPersona.Items.Add("Nombre: " + persona.Nombre + " Apellido: " + persona.Apellido +
                                 " Edad: " + persona.Edad + " Correo: " + persona.correo + " Numero: " + persona.Numero);

        }

        protected void btnJSON_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"D:\1.-REPOSITORIO\Jsonbase\aspnetJSON.json", "[" + Session["ARCHIVOJSON"].ToString() + "]");
            Response.Write("<script> alert('Json listo!');  </ script >");
        }
    }
}