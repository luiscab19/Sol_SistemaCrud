namespace SistemaCrud.Presentacion.Mantenimiento.Seccion.Acciones
{
    partial class AgregarSeccion
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
            this.labelSeccion = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.textBoxAgregarCodigo = new System.Windows.Forms.TextBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 42);
            this.label1.TabIndex = 16;
            this.label1.Text = "Añadir  Seccion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSeccion
            // 
            this.labelSeccion.AutoSize = true;
            this.labelSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeccion.Location = new System.Drawing.Point(52, 280);
            this.labelSeccion.Name = "labelSeccion";
            this.labelSeccion.Size = new System.Drawing.Size(89, 25);
            this.labelSeccion.TabIndex = 15;
            this.labelSeccion.Text = "Seccion:";
            this.labelSeccion.Click += new System.EventHandler(this.labelSeccion_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(52, 133);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(81, 25);
            this.labelCodigo.TabIndex = 14;
            this.labelCodigo.Text = "Codigo:";
            this.labelCodigo.Click += new System.EventHandler(this.labelCodigo_Click);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(52, 329);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.Size = new System.Drawing.Size(419, 65);
            this.textBoxContenido.TabIndex = 13;
            this.textBoxContenido.TextChanged += new System.EventHandler(this.textBoxContenido_TextChanged);
            // 
            // textBoxAgregarCodigo
            // 
            this.textBoxAgregarCodigo.Location = new System.Drawing.Point(52, 169);
            this.textBoxAgregarCodigo.Multiline = true;
            this.textBoxAgregarCodigo.Name = "textBoxAgregarCodigo";
            this.textBoxAgregarCodigo.Size = new System.Drawing.Size(419, 63);
            this.textBoxAgregarCodigo.TabIndex = 12;
            this.textBoxAgregarCodigo.TextChanged += new System.EventHandler(this.textBoxAgregarCodigo_TextChanged);
            // 
            // AgregarSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 653);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSeccion);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.textBoxAgregarCodigo);
            this.Name = "AgregarSeccion";
            this.Text = "AgregarSeccion";
            this.Load += new System.EventHandler(this.AgregarSeccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSeccion;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.TextBox textBoxAgregarCodigo;
    }
}