namespace PrimerProyecto
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new System.Windows.Forms.Label();
            lblApellido = new System.Windows.Forms.Label();
            lblDocumento = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            txtApellido = new System.Windows.Forms.TextBox();
            txtDocumento = new System.Windows.Forms.TextBox();
            btnIngresar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(51, 56);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new System.Drawing.Point(51, 105);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(66, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new System.Drawing.Point(51, 153);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new System.Drawing.Size(87, 20);
            lblDocumento.TabIndex = 2;
            lblDocumento.Text = "Documento";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(205, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(181, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(205, 102);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(181, 27);
            txtApellido.TabIndex = 4;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new System.Drawing.Point(205, 150);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new System.Drawing.Size(181, 27);
            txtDocumento.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new System.Drawing.Point(544, 56);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(123, 43);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(544, 130);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(123, 43);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            ClientSize = new System.Drawing.Size(746, 246);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDocumento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "frmPrincipal";
            Text = "PRIMER PROYECTO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
