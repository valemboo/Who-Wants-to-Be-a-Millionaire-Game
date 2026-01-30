namespace QuienQuiereSerMillonario
{
    partial class PantallaInstrucciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInstrucciones));
            lblinstrucciones = new Label();
            btnRegresarInicio = new Button();
            btnJugar2 = new Button();
            pictureLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // lblinstrucciones
            // 
            lblinstrucciones.BackColor = Color.Transparent;
            lblinstrucciones.Font = new Font("Bahnschrift SemiLight", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblinstrucciones.ForeColor = SystemColors.ButtonHighlight;
            lblinstrucciones.Location = new Point(24, 9);
            lblinstrucciones.Name = "lblinstrucciones";
            lblinstrucciones.Size = new Size(548, 528);
            lblinstrucciones.TabIndex = 0;
            lblinstrucciones.Text = resources.GetString("lblinstrucciones.Text");
            // 
            // btnRegresarInicio
            // 
            btnRegresarInicio.BackgroundImage = Properties.Resources.boton;
            btnRegresarInicio.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegresarInicio.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnRegresarInicio.ForeColor = SystemColors.ButtonHighlight;
            btnRegresarInicio.Location = new Point(308, 521);
            btnRegresarInicio.Margin = new Padding(3, 2, 3, 2);
            btnRegresarInicio.Name = "btnRegresarInicio";
            btnRegresarInicio.Size = new Size(123, 29);
            btnRegresarInicio.TabIndex = 6;
            btnRegresarInicio.Text = "Regresar";
            btnRegresarInicio.UseVisualStyleBackColor = true;
            btnRegresarInicio.Click += btn5050_Click;
            // 
            // btnJugar2
            // 
            btnJugar2.BackgroundImage = Properties.Resources.boton;
            btnJugar2.BackgroundImageLayout = ImageLayout.Stretch;
            btnJugar2.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnJugar2.ForeColor = SystemColors.ButtonHighlight;
            btnJugar2.Location = new Point(437, 521);
            btnJugar2.Margin = new Padding(3, 2, 3, 2);
            btnJugar2.Name = "btnJugar2";
            btnJugar2.Size = new Size(123, 29);
            btnJugar2.TabIndex = 7;
            btnJugar2.Text = "JUGAR";
            btnJugar2.UseVisualStyleBackColor = true;
            btnJugar2.Click += btnJugar2_Click;
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.Transparent;
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(361, 141);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(149, 141);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 8;
            pictureLogo.TabStop = false;
            // 
            // PantallaInstrucciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fqqsm;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(584, 561);
            Controls.Add(pictureLogo);
            Controls.Add(btnJugar2);
            Controls.Add(btnRegresarInicio);
            Controls.Add(lblinstrucciones);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "PantallaInstrucciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instrucciones";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblinstrucciones;
        private Button btnRegresarInicio;
        private Button btnJugar2;
        private PictureBox pictureLogo;
    }
}