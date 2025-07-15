namespace SistemaCrud.Presentacion.Mantenimiento.Seccion.Acciones
{
    partial class EliminarSeccion
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombreSeccion = new System.Windows.Forms.Label();
            this.textBoxEliminarSeccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.White;
            this.buttonAceptar.Location = new System.Drawing.Point(168, 294);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(159, 77);
            this.buttonAceptar.TabIndex = 19;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "Eliminar Seccion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNombreSeccion
            // 
            this.labelNombreSeccion.AutoSize = true;
            this.labelNombreSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreSeccion.Location = new System.Drawing.Point(59, 127);
            this.labelNombreSeccion.Name = "labelNombreSeccion";
            this.labelNombreSeccion.Size = new System.Drawing.Size(369, 25);
            this.labelNombreSeccion.TabIndex = 17;
            this.labelNombreSeccion.Text = "Codigo de la seccion que desea eliminar:";
            this.labelNombreSeccion.Click += new System.EventHandler(this.labelNombreSeccion_Click);
            // 
            // textBoxEliminarSeccion
            // 
            this.textBoxEliminarSeccion.Location = new System.Drawing.Point(52, 166);
            this.textBoxEliminarSeccion.Multiline = true;
            this.textBoxEliminarSeccion.Name = "textBoxEliminarSeccion";
            this.textBoxEliminarSeccion.Size = new System.Drawing.Size(419, 63);
            this.textBoxEliminarSeccion.TabIndex = 16;
            this.textBoxEliminarSeccion.TextChanged += new System.EventHandler(this.textBoxEliminarSeccion_TextChanged);
            // 
            // EliminarSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 403);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNombreSeccion);
            this.Controls.Add(this.textBoxEliminarSeccion);
            this.Name = "EliminarSeccion";
            this.Text = "EliminarSeccion";
            this.Load += new System.EventHandler(this.EliminarSeccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombreSeccion;
        private System.Windows.Forms.TextBox textBoxEliminarSeccion;
    }
}