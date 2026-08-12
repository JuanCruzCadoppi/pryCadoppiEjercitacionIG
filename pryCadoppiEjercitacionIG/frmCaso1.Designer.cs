namespace pryCadoppiEjercitacionIG
{
    partial class frmCaso1
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnPresentar = new Button();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblEdad = new Label();
            txtEdad = new TextBox();
            lblCarrera = new Label();
            txtCarrera = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(102, 60);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(182, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(136, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnPresentar
            // 
            btnPresentar.Location = new Point(243, 220);
            btnPresentar.Name = "btnPresentar";
            btnPresentar.Size = new Size(75, 23);
            btnPresentar.TabIndex = 2;
            btnPresentar.Text = "Presentar";
            btnPresentar.UseVisualStyleBackColor = true;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(102, 93);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(182, 85);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(136, 23);
            txtApellido.TabIndex = 4;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(102, 131);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 5;
            lblEdad.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(182, 123);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(40, 23);
            txtEdad.TabIndex = 6;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(102, 171);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 7;
            lblCarrera.Text = "Carrera";
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(182, 163);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(136, 23);
            txtCarrera.TabIndex = 8;
            // 
            // frmCaso1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 340);
            Controls.Add(txtCarrera);
            Controls.Add(lblCarrera);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(btnPresentar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "frmCaso1";
            Text = "Mí presentación";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnPresentar;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblEdad;
        private TextBox txtEdad;
        private Label lblCarrera;
        private TextBox txtCarrera;
    }
}