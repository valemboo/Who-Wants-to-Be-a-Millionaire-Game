namespace QuienQuiereSerMillonario
{
    partial class PantallaInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            pictureLogo = new PictureBox();
            btnIniciarJuego = new Button();
            btnCerrarInicio = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.Transparent;
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(162, 104);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(250, 246);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            pictureLogo.Click += pictureLogo_Click;
            // 
            // btnIniciarJuego
            // 
            btnIniciarJuego.BackColor = SystemColors.ActiveBorder;
            btnIniciarJuego.BackgroundImage = Properties.Resources.boton;
            btnIniciarJuego.Cursor = Cursors.Hand;
            btnIniciarJuego.Font = new Font("Copperplate Gothic Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarJuego.ForeColor = SystemColors.ButtonHighlight;
            btnIniciarJuego.Location = new Point(196, 380);
            btnIniciarJuego.Name = "btnIniciarJuego";
            btnIniciarJuego.Size = new Size(190, 45);
            btnIniciarJuego.TabIndex = 1;
            btnIniciarJuego.Text = "INICIAR JUEGO";
            btnIniciarJuego.UseVisualStyleBackColor = false;
            btnIniciarJuego.Click += btnIniciarJuego_Click;
            // 
            // btnCerrarInicio
            // 
            btnCerrarInicio.BackgroundImage = Properties.Resources.boton;
            btnCerrarInicio.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarInicio.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarInicio.ForeColor = SystemColors.ButtonHighlight;
            btnCerrarInicio.Location = new Point(500, 11);
            btnCerrarInicio.Margin = new Padding(3, 2, 3, 2);
            btnCerrarInicio.Name = "btnCerrarInicio";
            btnCerrarInicio.Size = new Size(72, 28);
            btnCerrarInicio.TabIndex = 14;
            btnCerrarInicio.Text = "Cerrar";
            btnCerrarInicio.UseVisualStyleBackColor = true;
            btnCerrarInicio.Click += btnCerrarInicio_Click;
            // 
            // PantallaInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fqqsm;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(584, 561);
            Controls.Add(btnCerrarInicio);
            Controls.Add(btnIniciarJuego);
            Controls.Add(pictureLogo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "PantallaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += PantallaInicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureLogo;
        private Button btnIniciarJuego;
        private Button btnCerrarInicio;
    }
}