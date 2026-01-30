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
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            PantallaInstrucciones pantallaInstruccion = new PantallaInstrucciones();
            pantallaInstruccion.Show(); // Muestra la pantalla de preguntas
            this.Hide();
        }

        private void btnInstrucciones_Click(object sender, EventArgs e)
        {

        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarInicio_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
