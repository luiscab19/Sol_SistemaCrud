namespace SistemaCrud.Presentacion.Mantenimiento.Curso.Acciones
{
    partial class EliminarCurso
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
            this.labelNombreCurso = new System.Windows.Forms.Label();
            this.textBoxEliminarCurso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.White;
            this.buttonAceptar.Location = new System.Drawing.Point(177, 298);
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
            this.label1.Location = new System.Drawing.Point(121, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "Eliminar Curso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNombreCurso
            // 
            this.labelNombreCurso.AutoSize = true;
            this.labelNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCurso.Location = new System.Drawing.Point(68, 131);
            this.labelNombreCurso.Name = "labelNombreCurso";
            this.labelNombreCurso.Size = new System.Drawing.Size(334, 25);
            this.labelNombreCurso.TabIndex = 17;
            this.labelNombreCurso.Text = "Codigo del curso que desea eliminar:";
            this.labelNombreCurso.Click += new System.EventHandler(this.labelNombreCurso_Click);
            // 
            // textBoxEliminarCurso
            // 
            this.textBoxEliminarCurso.Location = new System.Drawing.Point(61, 170);
            this.textBoxEliminarCurso.Multiline = true;
            this.textBoxEliminarCurso.Name = "textBoxEliminarCurso";
            this.textBoxEliminarCurso.Size = new System.Drawing.Size(419, 63);
            this.textBoxEliminarCurso.TabIndex = 16;
            this.textBoxEliminarCurso.TextChanged += new System.EventHandler(this.textBoxEliminarCurso_TextChanged);
            // 
            // EliminarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 403);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNombreCurso);
            this.Controls.Add(this.textBoxEliminarCurso);
            this.Name = "EliminarCurso";
            this.Text = "EliminarCurso";
            this.Load += new System.EventHandler(this.EliminarCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombreCurso;
        private System.Windows.Forms.TextBox textBoxEliminarCurso;
    }
}