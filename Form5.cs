using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuienQuiereSerMillonario
{
    public partial class PantallaFinal : Form
    {
        public PantallaFinal(string titulo, int monto)
        {
            InitializeComponent();
            lblPremioTitulo.Text = titulo; //Asigna el texto del título del premio
            lblPremioMonto.Text = "₡" + monto.ToString("N0"); //Muestra el monto ganado
        }

        public PantallaFinal()
        {
            InitializeComponent();
        }

        private void lblPremioTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarFinal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PantallaFinal_Load(object sender, EventArgs e)
        {

        }

        private void btnVolverJugar_Click(object sender, EventArgs e)
        {
            //Redirige al formulario de inicio
            PantallaInicio pantallaInicio = new PantallaInicio();
            pantallaInicio.Show();
            this.Close();
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
