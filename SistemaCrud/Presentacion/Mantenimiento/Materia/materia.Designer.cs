namespace SistemaCrud.Presentacion.Mantenimiento.Materia.Acciones
{
    partial class materia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(materia));
            this.dataGridViewmateria = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmateria)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewmateria
            // 
            this.dataGridViewmateria.AllowUserToOrderColumns = true;
            this.dataGridViewmateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmateria.Location = new System.Drawing.Point(201, 264);
            this.dataGridViewmateria.Name = "dataGridViewmateria";
            this.dataGridViewmateria.RowHeadersWidth = 51;
            this.dataGridViewmateria.RowTemplate.Height = 24;
            this.dataGridViewmateria.Size = new System.Drawing.Size(1061, 306);
            this.dataGridViewmateria.TabIndex = 14;
            this.dataGridViewmateria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewmateria_CellContentClick);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.Location = new System.Drawing.Point(1249, 133);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(69, 59);
            this.buttonEliminar.TabIndex = 13;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1002, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Values";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregar.Image")));
            this.buttonAgregar.Location = new System.Drawing.Point(1156, 133);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(69, 59);
            this.buttonAgregar.TabIndex = 11;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 703);
            this.Controls.Add(this.dataGridViewmateria);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAgregar);
            this.Name = "materia";
            this.Text = "materia";
            this.Load += new System.EventHandler(this.materia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewmateria;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAgregar;
    }
}