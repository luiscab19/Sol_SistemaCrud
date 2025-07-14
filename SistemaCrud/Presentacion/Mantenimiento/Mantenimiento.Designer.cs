namespace SistemaCrud.Presentacion.Mantenimiento
{
    partial class Mantenimiento
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
            this.buttonCurso = new System.Windows.Forms.Button();
            this.buttonPersona = new System.Windows.Forms.Button();
            this.buttonSeccion = new System.Windows.Forms.Button();
            this.buttonMateria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCurso
            // 
            this.buttonCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCurso.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCurso.Location = new System.Drawing.Point(45, 523);
            this.buttonCurso.Name = "buttonCurso";
            this.buttonCurso.Size = new System.Drawing.Size(219, 93);
            this.buttonCurso.TabIndex = 11;
            this.buttonCurso.Text = "Curso";
            this.buttonCurso.UseVisualStyleBackColor = false;
            this.buttonCurso.Click += new System.EventHandler(this.buttonCurso_Click);
            // 
            // buttonPersona
            // 
            this.buttonPersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersona.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPersona.Location = new System.Drawing.Point(45, 376);
            this.buttonPersona.Name = "buttonPersona";
            this.buttonPersona.Size = new System.Drawing.Size(219, 93);
            this.buttonPersona.TabIndex = 10;
            this.buttonPersona.Text = "Persona";
            this.buttonPersona.UseVisualStyleBackColor = false;
            this.buttonPersona.Click += new System.EventHandler(this.buttonPersona_Click);
            // 
            // buttonSeccion
            // 
            this.buttonSeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeccion.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSeccion.Location = new System.Drawing.Point(45, 229);
            this.buttonSeccion.Name = "buttonSeccion";
            this.buttonSeccion.Size = new System.Drawing.Size(219, 93);
            this.buttonSeccion.TabIndex = 9;
            this.buttonSeccion.Text = "Seccion";
            this.buttonSeccion.UseVisualStyleBackColor = false;
            this.buttonSeccion.Click += new System.EventHandler(this.buttonSeccion_Click);
            // 
            // buttonMateria
            // 
            this.buttonMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMateria.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMateria.Location = new System.Drawing.Point(45, 87);
            this.buttonMateria.Name = "buttonMateria";
            this.buttonMateria.Size = new System.Drawing.Size(219, 93);
            this.buttonMateria.TabIndex = 8;
            this.buttonMateria.Text = "Materia";
            this.buttonMateria.UseVisualStyleBackColor = false;
            this.buttonMateria.Click += new System.EventHandler(this.buttonMateria_Click);
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 703);
            this.Controls.Add(this.buttonCurso);
            this.Controls.Add(this.buttonPersona);
            this.Controls.Add(this.buttonSeccion);
            this.Controls.Add(this.buttonMateria);
            this.Name = "Mantenimiento";
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.Mantenimiento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCurso;
        private System.Windows.Forms.Button buttonPersona;
        private System.Windows.Forms.Button buttonSeccion;
        private System.Windows.Forms.Button buttonMateria;
    }
}