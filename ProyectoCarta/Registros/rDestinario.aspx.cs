using BLL;
using Entidades;
using ProyectoCarta.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoCarta.Registros
{
    public partial class rDestinario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private Destinario LlenaClase()
        {
            Destinario dest = new Destinario();
            dest.DestinarioId = Util.ToInt(DestinarioIdTextBox.Text);
            dest.Nombre = NombreTextBox.Text;
            dest.CartasRevisivas = Util.ToInt(ResividaTextBox.Text);

            return dest;
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            DestinarioIdTextBox.Text = "0";
            NombreTextBox.Text = "";
            ResividaTextBox.Text = "0";
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            RepositorioBase<Destinario> repo = new RepositorioBase<Destinario>();
            Destinario dest = new Destinario();

            if (IsValid == false)
            {
                Util.ShowToastr(this.Page, " Campos Vacios", "Error", "Error");
            }
            dest = LlenaClase();
            if (Convert.ToInt32(DestinarioIdTextBox.Text) == 0)
            {
                paso = repo.Guardar(dest);
                Util.ShowToastr(this.Page, "Guardado con EXITO", "Guardado", "Success");
            }
            else
            {
                paso = repo.Modificar(dest);
                Util.ShowToastr(this.Page, "Modificado con EXITO", "Guardado", "Success");
            }

            if (paso)
            {
                Limpiar();
            }
            else
            {
                Util.ShowToastr(this.Page, "No se pudo Guardar", "Error", "Error");
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Util.ToInt(DestinarioIdTextBox.Text);
            RepositorioBase<Destinario> repo = new RepositorioBase<Destinario>();

            if (repo.Eliminar(id))
            {
                Util.ShowToastr(this.Page, " Eliminado con EXITO", "Eliminado", "Success");
                Limpiar();
            }
            else

                Util.ShowToastr(this.Page, " No se pudo eliminar", "Error", "Error");

        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Destinario> repo = new RepositorioBase<Destinario>();
            Destinario dest = new Destinario();

            if (dest != null)
            {
                NombreTextBox.Text = dest.Nombre;
                ResividaTextBox.Text = dest.CartasRevisivas.ToString();

                Util.ShowToastr(this.Page, "Su busqueda fue exitosa", "", "Info");
            }
            else
            {
                Util.ShowToastr(this.Page, " No existe", "Error", "Error");
            }
        }
    }
}