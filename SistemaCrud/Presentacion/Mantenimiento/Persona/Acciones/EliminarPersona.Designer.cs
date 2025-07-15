namespace SistemaCrud.Presentacion.Mantenimiento.Persona.Acciones
{
    partial class EliminarPersona
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
            this.labelEliminarPersona = new System.Windows.Forms.Label();
            this.labelCedulaPersona = new System.Windows.Forms.Label();
            this.textBoxEliminarPersona = new System.Windows.Forms.TextBox();
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
            // labelEliminarPersona
            // 
            this.labelEliminarPersona.AutoSize = true;
            this.labelEliminarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEliminarPersona.Location = new System.Drawing.Point(112, 32);
            this.labelEliminarPersona.Name = "labelEliminarPersona";
            this.labelEliminarPersona.Size = new System.Drawing.Size(317, 42);
            this.labelEliminarPersona.TabIndex = 18;
            this.labelEliminarPersona.Text = "Eliminar Persona";
            this.labelEliminarPersona.Click += new System.EventHandler(this.labelEliminarPersona_Click);
            // 
            // labelCedulaPersona
            // 
            this.labelCedulaPersona.AutoSize = true;
            this.labelCedulaPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCedulaPersona.Location = new System.Drawing.Point(59, 127);
            this.labelCedulaPersona.Name = "labelCedulaPersona";
            this.labelCedulaPersona.Size = new System.Drawing.Size(373, 25);
            this.labelCedulaPersona.TabIndex = 17;
            this.labelCedulaPersona.Text = "Cedula de la persona que desea eliminar:";
            this.labelCedulaPersona.Click += new System.EventHandler(this.labelCedulaPersona_Click);
            // 
            // textBoxEliminarPersona
            // 
            this.textBoxEliminarPersona.Location = new System.Drawing.Point(52, 166);
            this.textBoxEliminarPersona.Multiline = true;
            this.textBoxEliminarPersona.Name = "textBoxEliminarPersona";
            this.textBoxEliminarPersona.Size = new System.Drawing.Size(419, 63);
            this.textBoxEliminarPersona.TabIndex = 16;
            this.textBoxEliminarPersona.TextChanged += new System.EventHandler(this.textBoxEliminarPersona_TextChanged);
            // 
            // EliminarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 403);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelEliminarPersona);
            this.Controls.Add(this.labelCedulaPersona);
            this.Controls.Add(this.textBoxEliminarPersona);
            this.Name = "EliminarPersona";
            this.Text = "EliminarPersona";
            this.Load += new System.EventHandler(this.EliminarPersona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelEliminarPersona;
        private System.Windows.Forms.Label labelCedulaPersona;
        private System.Windows.Forms.TextBox textBoxEliminarPersona;
    }
}