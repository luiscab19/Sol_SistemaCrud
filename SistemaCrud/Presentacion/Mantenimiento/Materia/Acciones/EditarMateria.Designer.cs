namespace SistemaCrud.Presentacion.Mantenimiento.Materia.Acciones
{
    partial class EditarMateria
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
            this.textBoxEditarContenido = new System.Windows.Forms.TextBox();
            this.textBoxEditarMateria = new System.Windows.Forms.TextBox();
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
            this.buttonAceptar.TabIndex = 17;
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
            this.labelAñadirMateria.Size = new System.Drawing.Size(263, 42);
            this.labelAñadirMateria.TabIndex = 16;
            this.labelAñadirMateria.Text = "Editar Materia";
            this.labelAñadirMateria.Click += new System.EventHandler(this.labelAñadirMateria_Click);
            // 
            // labelContenido
            // 
            this.labelContenido.AutoSize = true;
            this.labelContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContenido.Location = new System.Drawing.Point(52, 280);
            this.labelContenido.Name = "labelContenido";
            this.labelContenido.Size = new System.Drawing.Size(108, 25);
            this.labelContenido.TabIndex = 15;
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
            this.labelNombreMateria.TabIndex = 14;
            this.labelNombreMateria.Text = "Nombre de la materia:";
            this.labelNombreMateria.Click += new System.EventHandler(this.labelNombreMateria_Click);
            // 
            // textBoxEditarContenido
            // 
            this.textBoxEditarContenido.Location = new System.Drawing.Point(52, 322);
            this.textBoxEditarContenido.Multiline = true;
            this.textBoxEditarContenido.Name = "textBoxEditarContenido";
            this.textBoxEditarContenido.Size = new System.Drawing.Size(419, 147);
            this.textBoxEditarContenido.TabIndex = 13;
            this.textBoxEditarContenido.TextChanged += new System.EventHandler(this.textBoxEditarContenido_TextChanged);
            // 
            // textBoxEditarMateria
            // 
            this.textBoxEditarMateria.Location = new System.Drawing.Point(52, 169);
            this.textBoxEditarMateria.Multiline = true;
            this.textBoxEditarMateria.Name = "textBoxEditarMateria";
            this.textBoxEditarMateria.Size = new System.Drawing.Size(419, 63);
            this.textBoxEditarMateria.TabIndex = 12;
            this.textBoxEditarMateria.TextChanged += new System.EventHandler(this.textBoxEditarMateria_TextChanged);
            // 
            // EditarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 653);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelAñadirMateria);
            this.Controls.Add(this.labelContenido);
            this.Controls.Add(this.labelNombreMateria);
            this.Controls.Add(this.textBoxEditarContenido);
            this.Controls.Add(this.textBoxEditarMateria);
            this.Name = "EditarMateria";
            this.Text = "EditarMateria";
            this.Load += new System.EventHandler(this.EditarMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelAñadirMateria;
        private System.Windows.Forms.Label labelContenido;
        private System.Windows.Forms.Label labelNombreMateria;
        private System.Windows.Forms.TextBox textBoxEditarContenido;
        private System.Windows.Forms.TextBox textBoxEditarMateria;
    }
}