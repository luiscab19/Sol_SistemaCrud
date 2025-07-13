namespace SistemaCrud.Presentacion.Mantenimiento.Materia.Acciones
{
    partial class AgregarMateria
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
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.labelAñadirMateria = new System.Windows.Forms.Label();
            this.labelContenido = new System.Windows.Forms.Label();
            this.labelNombreMateria = new System.Windows.Forms.Label();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.textBoxAgregarMateria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.White;
            this.buttonAceptar.Location = new System.Drawing.Point(170, 541);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(159, 77);
            this.buttonAceptar.TabIndex = 11;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // labelAñadirMateria
            // 
            this.labelAñadirMateria.AutoSize = true;
            this.labelAñadirMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAñadirMateria.Location = new System.Drawing.Point(112, 35);
            this.labelAñadirMateria.Name = "labelAñadirMateria";
            this.labelAñadirMateria.Size = new System.Drawing.Size(285, 42);
            this.labelAñadirMateria.TabIndex = 10;
            this.labelAñadirMateria.Text = "Añadir  Materia";
            // 
            // labelContenido
            // 
            this.labelContenido.AutoSize = true;
            this.labelContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContenido.Location = new System.Drawing.Point(52, 280);
            this.labelContenido.Name = "labelContenido";
            this.labelContenido.Size = new System.Drawing.Size(108, 25);
            this.labelContenido.TabIndex = 9;
            this.labelContenido.Text = "Contenido:";
            this.labelContenido.Click += new System.EventHandler(this.labelContenido_Click);
            // 
            // labelNombreMateria
            // 
            this.labelNombreMateria.AutoSize = true;
            this.labelNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreMateria.Location = new System.Drawing.Point(52, 133);
            this.labelNombreMateria.Name = "labelNombreMateria";
            this.labelNombreMateria.Size = new System.Drawing.Size(203, 25);
            this.labelNombreMateria.TabIndex = 8;
            this.labelNombreMateria.Text = "Nombre de la materia:";
            this.labelNombreMateria.Click += new System.EventHandler(this.labelNombreMateria_Click);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(52, 322);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.Size = new System.Drawing.Size(419, 147);
            this.textBoxContenido.TabIndex = 7;
            this.textBoxContenido.TextChanged += new System.EventHandler(this.textBoxContenido_TextChanged);
            // 
            // textBoxAgregarMateria
            // 
            this.textBoxAgregarMateria.Location = new System.Drawing.Point(52, 169);
            this.textBoxAgregarMateria.Multiline = true;
            this.textBoxAgregarMateria.Name = "textBoxAgregarMateria";
            this.textBoxAgregarMateria.Size = new System.Drawing.Size(419, 63);
            this.textBoxAgregarMateria.TabIndex = 6;
            this.textBoxAgregarMateria.TextChanged += new System.EventHandler(this.textBoxAgregarMateria_TextChanged);
            // 
            // AgregarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 653);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelAñadirMateria);
            this.Controls.Add(this.labelContenido);
            this.Controls.Add(this.labelNombreMateria);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.textBoxAgregarMateria);
            this.Name = "AgregarMateria";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelAñadirMateria;
        private System.Windows.Forms.Label labelContenido;
        private System.Windows.Forms.Label labelNombreMateria;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.TextBox textBoxAgregarMateria;
    }
}