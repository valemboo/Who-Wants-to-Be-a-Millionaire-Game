namespace QuienQuiereSerMillonario
{
    partial class PantallaFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaFinal));
            lblPremioTitulo = new Label();
            lblPremioMonto = new Label();
            lblPremioFinal = new Label();
            btnVolverJugar = new Button();
            btnCerrarFinal = new Button();
            pictureLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // lblPremioTitulo
            // 
            lblPremioTitulo.BackColor = Color.Transparent;
            lblPremioTitulo.Font = new Font("Copperplate Gothic Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPremioTitulo.ForeColor = SystemColors.ButtonHighlight;
            lblPremioTitulo.Location = new Point(12, 174);
            lblPremioTitulo.Name = "lblPremioTitulo";
            lblPremioTitulo.Size = new Size(560, 84);
            lblPremioTitulo.TabIndex = 10;
            lblPremioTitulo.Text = ".";
            lblPremioTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblPremioTitulo.Click += lblPremioTitulo_Click;
            // 
            // lblPremioMonto
            // 
            lblPremioMonto.BackColor = Color.Transparent;
            lblPremioMonto.Font = new Font("Arial Narrow", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPremioMonto.ForeColor = SystemColors.ButtonHighlight;
            lblPremioMonto.Location = new Point(49, 323);
            lblPremioMonto.Name = "lblPremioMonto";
            lblPremioMonto.Size = new Size(481, 79);
            lblPremioMonto.TabIndex = 11;
            lblPremioMonto.Text = "monto";
            lblPremioMonto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPremioFinal
            // 
            lblPremioFinal.BackColor = Color.Transparent;
            lblPremioFinal.Font = new Font("Copperplate Gothic Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPremioFinal.ForeColor = Color.Orange;
            lblPremioFinal.Location = new Point(173, 279);
            lblPremioFinal.Name = "lblPremioFinal";
            lblPremioFinal.Size = new Size(245, 30);
            lblPremioFinal.TabIndex = 12;
            lblPremioFinal.Text = "Premio Final";
            lblPremioFinal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVolverJugar
            // 
            btnVolverJugar.BackgroundImage = Properties.Resources.boton;
            btnVolverJugar.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolverJugar.Font = new Font("Arial Rounded MT Bold", 12F);
            btnVolverJugar.ForeColor = SystemColors.ButtonHighlight;
            btnVolverJugar.Location = new Point(330, 457);
            btnVolverJugar.Margin = new Padding(3, 2, 3, 2);
            btnVolverJugar.Name = "btnVolverJugar";
            btnVolverJugar.Size = new Size(144, 38);
            btnVolverJugar.TabIndex = 14;
            btnVolverJugar.Text = "Volver a jugar";
            btnVolverJugar.UseVisualStyleBackColor = true;
            btnVolverJugar.Click += btnVolverJugar_Click;
            // 
            // btnCerrarFinal
            // 
            btnCerrarFinal.BackgroundImage = Properties.Resources.boton;
            btnCerrarFinal.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarFinal.Font = new Font("Arial Rounded MT Bold", 12F);
            btnCerrarFinal.ForeColor = SystemColors.ButtonHighlight;
            btnCerrarFinal.Location = new Point(114, 457);
            btnCerrarFinal.Margin = new Padding(3, 2, 3, 2);
            btnCerrarFinal.Name = "btnCerrarFinal";
            btnCerrarFinal.Size = new Size(144, 38);
            btnCerrarFinal.TabIndex = 13;
            btnCerrarFinal.Text = "Cerrar";
            btnCerrarFinal.UseVisualStyleBackColor = true;
            btnCerrarFinal.Click += btnCerrarFinal_Click;
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.Transparent;
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(218, 30);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(149, 141);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 15;
            pictureLogo.TabStop = false;
            pictureLogo.Click += pictureLogo_Click;
            // 
            // PantallaFinal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fqqsm;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(584, 561);
            Controls.Add(pictureLogo);
            Controls.Add(btnVolverJugar);
            Controls.Add(btnCerrarFinal);
            Controls.Add(lblPremioFinal);
            Controls.Add(lblPremioMonto);
            Controls.Add(lblPremioTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "PantallaFinal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fin del juego";
            Load += PantallaFinal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPremioTitulo;
        private Label lblPremioMonto;
        private Label lblPremioFinal;
        private Button btnVolverJugar;
        private Button btnCerrarFinal;
        private PictureBox pictureLogo;
    }
}