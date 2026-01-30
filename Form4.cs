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
    public partial class comodinInternet : Form
    {
        int tiempoRestante = 20;
        System.Windows.Forms.Timer timer;

        public comodinInternet()
        {
            InitializeComponent();

            lblTiempo.Text = "Tienes 20 segundos para buscar la respuesta!";

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            lblTiempo.Text = $"¡Tienes {tiempoRestante} segundos para buscar la respuesta!";

            if (tiempoRestante == 0)
            {
                timer.Stop();
                MessageBox.Show("¡Se acabó el tiempo!");
                this.Close();
            }
        }
        private void lblTiempo_Click(object sender, EventArgs e)
        {

        }
    }
}
