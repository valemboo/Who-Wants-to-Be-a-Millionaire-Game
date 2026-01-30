namespace QuienQuiereSerMillonario
{
    partial class comodinInternet
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
            lblTiempo = new Label();
            SuspendLayout();
            // 
            // lblTiempo
            // 
            lblTiempo.BackColor = Color.Transparent;
            lblTiempo.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTiempo.ForeColor = SystemColors.ButtonHighlight;
            lblTiempo.Location = new Point(30, 24);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(276, 81);
            lblTiempo.TabIndex = 0;
            lblTiempo.TextAlign = ContentAlignment.MiddleCenter;
            lblTiempo.Click += lblTiempo_Click;
            // 
            // comodinInternet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.comodin2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(334, 136);
            Controls.Add(lblTiempo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Location = new Point(500, 120);
            MaximizeBox = false;
            Name = "comodinInternet";
            StartPosition = FormStartPosition.Manual;
            Text = "Cronómetro";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTiempo;
    }
}