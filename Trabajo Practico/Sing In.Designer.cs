namespace Trabajo_Practico
{
    partial class Sign_In
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_crearCuenta = new System.Windows.Forms.Label();
            this.btn_iniciarSesion = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_crearCuenta
            // 
            this.lbl_crearCuenta.AutoSize = true;
            this.lbl_crearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_crearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crearCuenta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_crearCuenta.Location = new System.Drawing.Point(106, 180);
            this.lbl_crearCuenta.Name = "lbl_crearCuenta";
            this.lbl_crearCuenta.Size = new System.Drawing.Size(89, 13);
            this.lbl_crearCuenta.TabIndex = 15;
            this.lbl_crearCuenta.Text = "Crear una cuenta";
            this.lbl_crearCuenta.Click += new System.EventHandler(this.lbl_crearCuenta_Click);
            // 
            // btn_iniciarSesion
            // 
            this.btn_iniciarSesion.BackColor = System.Drawing.SystemColors.Control;
            this.btn_iniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_iniciarSesion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_iniciarSesion.Location = new System.Drawing.Point(37, 125);
            this.btn_iniciarSesion.Name = "btn_iniciarSesion";
            this.btn_iniciarSesion.Size = new System.Drawing.Size(221, 23);
            this.btn_iniciarSesion.TabIndex = 14;
            this.btn_iniciarSesion.Text = "Iniciar Sesion";
            this.btn_iniciarSesion.UseVisualStyleBackColor = false;
            this.btn_iniciarSesion.Click += new System.EventHandler(this.btn_iniciarSesion_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_cerrar.Location = new System.Drawing.Point(87, 154);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(128, 23);
            this.btn_cerrar.TabIndex = 13;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(87, 73);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(183, 20);
            this.txt_email.TabIndex = 12;
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(87, 99);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(183, 20);
            this.txt_contrasena.TabIndex = 11;
            this.txt_contrasena.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(17, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contraseña:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_email.Location = new System.Drawing.Point(17, 76);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 9;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_titulo.Location = new System.Drawing.Point(47, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(201, 31);
            this.lbl_titulo.TabIndex = 8;
            this.lbl_titulo.Text = "Inicio de sesion";
            // 
            // Sign_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 210);
            this.Controls.Add(this.lbl_crearCuenta);
            this.Controls.Add(this.btn_iniciarSesion);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Sign_In";
            this.Text = "Inicio de sesion";
            this.Load += new System.EventHandler(this.Sign_In_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_crearCuenta;
        private System.Windows.Forms.Button btn_iniciarSesion;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_titulo;
    }
}

