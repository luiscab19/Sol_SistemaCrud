namespace SistemaCrud.Presentacion.Mantenimiento.Persona
{
    partial class Personas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personas));
            this.dataGridViewPersona = new System.Windows.Forms.DataGridView();
            this.buttonEliminarPersona = new System.Windows.Forms.Button();
            this.textBoxPersona = new System.Windows.Forms.TextBox();
            this.buttonAgregarPersona = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersona
            // 
            this.dataGridViewPersona.AllowUserToOrderColumns = true;
            this.dataGridViewPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersona.Location = new System.Drawing.Point(201, 264);
            this.dataGridViewPersona.Name = "dataGridViewPersona";
            this.dataGridViewPersona.RowHeadersWidth = 51;
            this.dataGridViewPersona.RowTemplate.Height = 24;
            this.dataGridViewPersona.Size = new System.Drawing.Size(1060, 305);
            this.dataGridViewPersona.TabIndex = 18;
            this.dataGridViewPersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersona_CellContentClick);
            // 
            // buttonEliminarPersona
            // 
            this.buttonEliminarPersona.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEliminarPersona.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminarPersona.Image")));
            this.buttonEliminarPersona.Location = new System.Drawing.Point(1249, 133);
            this.buttonEliminarPersona.Name = "buttonEliminarPersona";
            this.buttonEliminarPersona.Size = new System.Drawing.Size(69, 59);
            this.buttonEliminarPersona.TabIndex = 17;
            this.buttonEliminarPersona.UseVisualStyleBackColor = false;
            this.buttonEliminarPersona.Click += new System.EventHandler(this.buttonEliminarPersona_Click);
            // 
            // textBoxPersona
            // 
            this.textBoxPersona.Location = new System.Drawing.Point(115, 151);
            this.textBoxPersona.Name = "textBoxPersona";
            this.textBoxPersona.Size = new System.Drawing.Size(1002, 22);
            this.textBoxPersona.TabIndex = 16;
            this.textBoxPersona.Text = "Values";
            this.textBoxPersona.TextChanged += new System.EventHandler(this.textBoxPersona_TextChanged);
            // 
            // buttonAgregarPersona
            // 
            this.buttonAgregarPersona.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAgregarPersona.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarPersona.Image")));
            this.buttonAgregarPersona.Location = new System.Drawing.Point(1156, 133);
            this.buttonAgregarPersona.Name = "buttonAgregarPersona";
            this.buttonAgregarPersona.Size = new System.Drawing.Size(69, 59);
            this.buttonAgregarPersona.TabIndex = 15;
            this.buttonAgregarPersona.UseVisualStyleBackColor = false;
            this.buttonAgregarPersona.Click += new System.EventHandler(this.buttonAgregarPersona_Click);
            // 
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 703);
            this.Controls.Add(this.dataGridViewPersona);
            this.Controls.Add(this.buttonEliminarPersona);
            this.Controls.Add(this.textBoxPersona);
            this.Controls.Add(this.buttonAgregarPersona);
            this.Name = "Personas";
            this.Text = "Persona";
            this.Load += new System.EventHandler(this.Persona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersona;
        private System.Windows.Forms.Button buttonEliminarPersona;
        private System.Windows.Forms.TextBox textBoxPersona;
        private System.Windows.Forms.Button buttonAgregarPersona;
    }
}