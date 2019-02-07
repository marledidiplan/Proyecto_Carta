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
    public partial class rCarta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Carta> repo = new RepositorioBase<Carta>();
            Carta carta = new Carta();

            if(carta!=null)
            {
                FechaTextBox.Text = carta.Fecha.ToString();
                CuerpoTextBox.Text = carta.Cuerpo;

                Util.ShowToastr(this.Page, "Su busqueda fue exitosa", "", "Info");
            }
            else
            {
                Util.ShowToastr(this.Page, " No existe", "Error", "Error");
            }

        }

        private void Limpiar()
        {
            CartaIdTextBox.Text = "0";
            FechaTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
            CuerpoTextBox.Text = "";
        }
        private void LlenarCombobox()
        {
            RepositorioBase<Destinario> repositorio = new RepositorioBase<Destinario>();
            DestinarioDropDownList.DataSource = repositorio.GetList(m => true);
            DestinarioDropDownList.DataValueField = "DestinarioId";
            DestinarioDropDownList.DataValueField = "Nombre";
            DestinarioDropDownList.DataBind();
        }
        public Carta LlenaClase()
        {
            Carta carta = new Carta();
            carta.CartaId = Util.ToInt(CartaIdTextBox.Text);
            DateTime date;
            bool resul = DateTime.TryParse(FechaTextBox.Text, out date);
            if (resul == true) ;
            carta.DestinarioId = Util.ToInt(DestinarioDropDownList.SelectedValue);
            carta.Cuerpo = CuerpoTextBox.Text;

            return carta;


        }
        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            RepositorioBase<Carta> repo = new RepositorioBase<Carta>();
            Carta carta = new Carta();

            if(IsValid ==false)
            {
                Util.ShowToastr(this.Page, " Campos Vacios", "Error", "Error");
            }
            carta = LlenaClase();
            if(Convert.ToInt32(CartaIdTextBox.Text) ==0)
            {
                paso = repo.Guardar(carta);
                Util.ShowToastr(this.Page, "Guardado con EXITO", "Guardado", "Success");
            }
            else
            {
                paso = repo.Modificar(carta);
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
            int id = Util.ToInt(CartaIdTextBox.Text);
            RepositorioBase<Carta> repo = new RepositorioBase<Carta>();

            if (repo.Eliminar(id))
            {
                Util.ShowToastr(this.Page, " Eliminado con EXITO", "Eliminado", "Success");
                Limpiar();
            }
            else

                Util.ShowToastr(this.Page, " No se pudo eliminar", "Error", "Error");
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}