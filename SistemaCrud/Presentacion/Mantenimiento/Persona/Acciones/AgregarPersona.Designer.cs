namespace SistemaCrud.Presentacion.Mantenimiento.Persona.Acciones
{
    partial class Agregar_Persona
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
            this.comboBoxTipoPersona = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCedula = new System.Windows.Forms.Label();
            this.labelNombreMateria = new System.Windows.Forms.Label();
            this.textBoxAgregarNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.White;
            this.buttonAceptar.Location = new System.Drawing.Point(178, 540);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(159, 77);
            this.buttonAceptar.TabIndex = 21;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // comboBoxTipoPersona
            // 
            this.comboBoxTipoPersona.FormattingEnabled = true;
            this.comboBoxTipoPersona.Location = new System.Drawing.Point(57, 454);
            this.comboBoxTipoPersona.Name = "comboBoxTipoPersona";
            this.comboBoxTipoPersona.Size = new System.Drawing.Size(414, 24);
            this.comboBoxTipoPersona.TabIndex = 20;
            this.comboBoxTipoPersona.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoPersona_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo de Persona:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(52, 311);
            this.textBoxCedula.Multiline = true;
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(419, 63);
            this.textBoxCedula.TabIndex = 18;
            this.textBoxCedula.TextChanged += new System.EventHandler(this.textBoxCedula_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "Añadir Persona";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCedula.Location = new System.Drawing.Point(52, 272);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(81, 25);
            this.labelCedula.TabIndex = 16;
            this.labelCedula.Text = "Cedula:";
            this.labelCedula.Click += new System.EventHandler(this.labelCedula_Click);
            // 
            // labelNombreMateria
            // 
            this.labelNombreMateria.AutoSize = true;
            this.labelNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreMateria.Location = new System.Drawing.Point(52, 134);
            this.labelNombreMateria.Name = "labelNombreMateria";
            this.labelNombreMateria.Size = new System.Drawing.Size(87, 25);
            this.labelNombreMateria.TabIndex = 15;
            this.labelNombreMateria.Text = "Nombre:";
            this.labelNombreMateria.Click += new System.EventHandler(this.labelNombreMateria_Click);
            // 
            // textBoxAgregarNombre
            // 
            this.textBoxAgregarNombre.Location = new System.Drawing.Point(52, 170);
            this.textBoxAgregarNombre.Multiline = true;
            this.textBoxAgregarNombre.Name = "textBoxAgregarNombre";
            this.textBoxAgregarNombre.Size = new System.Drawing.Size(419, 63);
            this.textBoxAgregarNombre.TabIndex = 14;
            this.textBoxAgregarNombre.TextChanged += new System.EventHandler(this.textBoxAgregarNombre_TextChanged);
            // 
            // Agregar_Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 653);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.comboBoxTipoPersona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCedula);
            this.Controls.Add(this.labelNombreMateria);
            this.Controls.Add(this.textBoxAgregarNombre);
            this.Name = "Agregar_Persona";
            this.Text = "Agregar_Persona";
            this.Load += new System.EventHandler(this.Agregar_Persona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.ComboBox comboBoxTipoPersona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.Label labelNombreMateria;
        private System.Windows.Forms.TextBox textBoxAgregarNombre;
    }
}