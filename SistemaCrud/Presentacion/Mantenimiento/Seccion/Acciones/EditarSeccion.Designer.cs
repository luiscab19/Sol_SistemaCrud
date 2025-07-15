namespace SistemaCrud.Presentacion.Mantenimiento.Seccion.Acciones
{
    partial class EditarSeccion
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
            this.labelSeccion = new System.Windows.Forms.Label();
            this.labelNombreMateria = new System.Windows.Forms.Label();
            this.textBoxCodigoSeccion = new System.Windows.Forms.TextBox();
            this.textBoxSeccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.White;
            this.buttonAceptar.Location = new System.Drawing.Point(170, 566);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(159, 77);
            this.buttonAceptar.TabIndex = 23;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // labelAñadirMateria
            // 
            this.labelAñadirMateria.AutoSize = true;
            this.labelAñadirMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAñadirMateria.Location = new System.Drawing.Point(112, 60);
            this.labelAñadirMateria.Name = "labelAñadirMateria";
            this.labelAñadirMateria.Size = new System.Drawing.Size(253, 42);
            this.labelAñadirMateria.TabIndex = 22;
            this.labelAñadirMateria.Text = "Editar Secion";
            // 
            // labelSeccion
            // 
            this.labelSeccion.AutoSize = true;
            this.labelSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeccion.Location = new System.Drawing.Point(52, 305);
            this.labelSeccion.Name = "labelSeccion";
            this.labelSeccion.Size = new System.Drawing.Size(89, 25);
            this.labelSeccion.TabIndex = 21;
            this.labelSeccion.Text = "Seccion:";
            this.labelSeccion.Click += new System.EventHandler(this.labelSeccion_Click);
            // 
            // labelNombreMateria
            // 
            this.labelNombreMateria.AutoSize = true;
            this.labelNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreMateria.Location = new System.Drawing.Point(52, 158);
            this.labelNombreMateria.Name = "labelNombreMateria";
            this.labelNombreMateria.Size = new System.Drawing.Size(194, 25);
            this.labelNombreMateria.TabIndex = 20;
            this.labelNombreMateria.Text = "Codigo de la seccion";
            this.labelNombreMateria.Click += new System.EventHandler(this.labelNombreMateria_Click);
            // 
            // textBoxCodigoSeccion
            // 
            this.textBoxCodigoSeccion.Location = new System.Drawing.Point(52, 194);
            this.textBoxCodigoSeccion.Multiline = true;
            this.textBoxCodigoSeccion.Name = "textBoxCodigoSeccion";
            this.textBoxCodigoSeccion.Size = new System.Drawing.Size(419, 63);
            this.textBoxCodigoSeccion.TabIndex = 18;
            this.textBoxCodigoSeccion.TextChanged += new System.EventHandler(this.textBoxCodigoSeccion_TextChanged);
            // 
            // textBoxSeccion
            // 
            this.textBoxSeccion.Location = new System.Drawing.Point(52, 364);
            this.textBoxSeccion.Multiline = true;
            this.textBoxSeccion.Name = "textBoxSeccion";
            this.textBoxSeccion.Size = new System.Drawing.Size(419, 63);
            this.textBoxSeccion.TabIndex = 24;
            this.textBoxSeccion.TextChanged += new System.EventHandler(this.textBoxSeccion_TextChanged);
            // 
            // EditarSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 703);
            this.Controls.Add(this.textBoxSeccion);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelAñadirMateria);
            this.Controls.Add(this.labelSeccion);
            this.Controls.Add(this.labelNombreMateria);
            this.Controls.Add(this.textBoxCodigoSeccion);
            this.Name = "EditarSeccion";
            this.Text = "EditarSeccion";
            this.Load += new System.EventHandler(this.EditarSeccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelAñadirMateria;
        private System.Windows.Forms.Label labelSeccion;
        private System.Windows.Forms.Label labelNombreMateria;
        private System.Windows.Forms.TextBox textBoxCodigoSeccion;
        private System.Windows.Forms.TextBox textBoxSeccion;
    }
}