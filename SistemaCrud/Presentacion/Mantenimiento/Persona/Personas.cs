using SistemaCrud.Presentacion.Mantenimiento.Materia.Acciones;
using SistemaCrud.Presentacion.Mantenimiento.Persona.Acciones;
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

namespace SistemaCrud.Presentacion.Mantenimiento.Persona
{
    public partial class Personas : Form
    {
        private readonly DBComponent _db = new DBComponent();
        public Personas()
        {
            InitializeComponent();
        }

        private void buttonAgregarPersona_Click(object sender, EventArgs e)
        {
            Agregar_Persona form = new Agregar_Persona();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadPersonas();
            }
        }

        private void buttonEliminarPersona_Click(object sender, EventArgs e)
        {
            EliminarPersona form = new EliminarPersona();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadPersonas();
            }
        }

        private void textBoxPersona_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridViewPersona.Columns[e.ColumnIndex].Name == "Editar")
            {
                var nombre = dataGridViewPersona.Rows[e.RowIndex].Cells["Nombre"].Value?.ToString();
                var cedula = dataGridViewPersona.Rows[e.RowIndex].Cells["Cedula"].Value?.ToString();
                var tipo = dataGridViewPersona.Rows[e.RowIndex].Cells["TipoPersona"].Value?.ToString();
                var formEditar = new Acciones.EditarPersona();
                formEditar.Tag = new { persona_no = nombre, persona_id = cedula, tipo_persona_de = tipo };
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    LoadPersonas();
                }
            }
        }

        private void Persona_Load(object sender, EventArgs e)
        {
            ConfigureGrid();
            LoadPersonas();
        }

        private void ConfigureGrid()
        {
            dataGridViewPersona.AutoGenerateColumns = false;
            dataGridViewPersona.AllowUserToAddRows = false;
            dataGridViewPersona.AllowUserToDeleteRows = false;
            dataGridViewPersona.ReadOnly = true;
            dataGridViewPersona.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPersona.MultiSelect = false;
            dataGridViewPersona.BackgroundColor = SystemColors.Window;
            dataGridViewPersona.EnableHeadersVisualStyles = false;
            dataGridViewPersona.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewPersona.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridViewPersona.Columns.Clear();

            var btnEditar = new DataGridViewButtonColumn
            {
                Name = "Editar",
                HeaderText = "Editar",
                Text = "✏️",
                UseColumnTextForButtonValue = true,
                Width = 60,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            };
            var colNombre = new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "persona_no",
                Width = 400
            };
            var colCedula = new DataGridViewTextBoxColumn
            {
                Name = "Cedula",
                HeaderText = "Cédula",
                DataPropertyName = "persona_id",
                Width = 250
            };
            var colTipo = new DataGridViewTextBoxColumn
            {
                Name = "TipoPersona",
                HeaderText = "Tipo de Persona",
                DataPropertyName = "tipo_persona_de",
                Width = 350
            };
            dataGridViewPersona.Columns.AddRange(btnEditar, colNombre, colCedula, colTipo);
            dataGridViewPersona.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridViewPersona.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewPersona.ColumnHeadersHeight = 35;
            dataGridViewPersona.RowHeadersVisible = false;
            dataGridViewPersona.RowTemplate.Height = 30;
            dataGridViewPersona.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPersona.Columns["Editar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewPersona.Columns["Editar"].Width = 60;
        }

        private void LoadPersonas()
        {
            try
            {
                dataGridViewPersona.DataSource = null;
                var personas = _db.Query<dynamic>("Persona", "SelectAll");
                dataGridViewPersona.DataSource = personas.ToList();
                dataGridViewPersona.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar personas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
