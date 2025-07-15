using SistemaCrud.Presentacion.Mantenimiento.Persona.Acciones;
using SistemaCrud.Presentacion.Mantenimiento.Seccion.Acciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaCRUD.Core;

namespace SistemaCrud.Presentacion.Mantenimiento.Seccion
{
    public partial class seccion : Form
    {
        private readonly DBComponent _db = new DBComponent();
        public seccion()
        {
            InitializeComponent();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarSeccion form = new EliminarSeccion();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSecciones();
            }
        }

        private void seccion_Load(object sender, EventArgs e)
        {
            ConfigureGrid();
            LoadSecciones();
        }

        private void ConfigureGrid()
        {
            dataGridViewmateria.AutoGenerateColumns = false;
            dataGridViewmateria.AllowUserToAddRows = false;
            dataGridViewmateria.AllowUserToDeleteRows = false;
            dataGridViewmateria.ReadOnly = true;
            dataGridViewmateria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewmateria.MultiSelect = false;
            dataGridViewmateria.BackgroundColor = SystemColors.Window;
            dataGridViewmateria.EnableHeadersVisualStyles = false;
            dataGridViewmateria.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewmateria.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridViewmateria.Columns.Clear();

            var btnEditar = new DataGridViewButtonColumn
            {
                Name = "Editar",
                HeaderText = "editar",
                Text = "✏️",
                UseColumnTextForButtonValue = true,
                Width = 60,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };
            var colCodigo = new DataGridViewTextBoxColumn
            {
                Name = "Codigo",
                HeaderText = "código",
                DataPropertyName = "seccion_id",
                Width = 200
            };
            var colSeccion = new DataGridViewTextBoxColumn
            {
                Name = "Seccion",
                HeaderText = "Sección",
                DataPropertyName = "seccion_de",
                Width = 800
            };
            dataGridViewmateria.Columns.AddRange(btnEditar, colCodigo, colSeccion);
            dataGridViewmateria.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridViewmateria.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewmateria.ColumnHeadersHeight = 35;
            dataGridViewmateria.RowHeadersVisible = false;
            dataGridViewmateria.RowTemplate.Height = 30;
            dataGridViewmateria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewmateria.Columns["Editar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewmateria.Columns["Editar"].Width = 60;
        }

        private void LoadSecciones()
        {
            try
            {
                dataGridViewmateria.DataSource = null;
                var secciones = _db.Query<dynamic>("Seccion", "GetAll");
                dataGridViewmateria.DataSource = secciones.ToList();
                dataGridViewmateria.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar secciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarSeccion form = new AgregarSeccion();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSecciones();
            }
        }

        private void dataGridViewmateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridViewmateria.Columns[e.ColumnIndex].Name == "Editar")
            {
                var codigo = dataGridViewmateria.Rows[e.RowIndex].Cells["Codigo"].Value?.ToString();
                var seccion = dataGridViewmateria.Rows[e.RowIndex].Cells["Seccion"].Value?.ToString();
                var formEditar = new Acciones.EditarSeccion();
                formEditar.Tag = new { seccion_id = codigo, seccion_de = seccion };
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    LoadSecciones();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
