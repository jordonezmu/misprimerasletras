using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jardin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            //Textos por defecto en los campos del formulario
            txtDocumento.Tag = "Ingrese su CC";

            //Implemetación de los textos por defecto
            txtDocumento.Text = txtDocumento.Tag.ToString();

            //Color del texto por defecto
            txtDocumento.ForeColor = Color.Gray;

            //Eventos en el campo de texto
            txtDocumento.GotFocus += new EventHandler(OnGetFocus);
            txtDocumento.LostFocus += new EventHandler(OnLostFocus);
        }

        public void OnGetFocus(object sender, EventArgs e)
        {
            //Borrar el texto por defecto por el texto ingresado
            if (txtDocumento.Text.Contains(txtDocumento.Tag.ToString()))
                txtDocumento.Text = "";

            txtDocumento.ForeColor = Color.Black; //Color del texto ingresado
        }

        public void OnLostFocus(object sender, EventArgs e)
        {
            //Implementación del texto por defecto si el campo está vacío
            if (String.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                txtDocumento.Text = txtDocumento.Tag.ToString();
                txtDocumento.ForeColor = Color.Gray;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
