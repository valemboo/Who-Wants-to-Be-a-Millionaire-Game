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
    public partial class PantallaInstrucciones : Form
    {
        public PantallaInstrucciones()
        {
            InitializeComponent();
        }

        private void txtInstrucciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn5050_Click(object sender, EventArgs e)
        {
            PantallaInicio pantallaInicio = new PantallaInicio();
            pantallaInicio.Show();
            this.Close();
        }

        private void btnJugar2_Click(object sender, EventArgs e)
        {
            PantallaPreguntas pantallaJuego = new PantallaPreguntas();
            pantallaJuego.Show();
            this.Close(); 
        }
    }
}
