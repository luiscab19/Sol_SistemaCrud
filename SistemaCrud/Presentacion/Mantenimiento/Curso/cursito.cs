using SistemaCrud.Presentacion.Mantenimiento.Curso.Acciones;
using SistemaCrud.Presentacion.Mantenimiento.Materia.Acciones;
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

namespace SistemaCrud.Presentacion.Mantenimiento.Curso
{
    public partial class cursito : Form
    {
        private readonly DBComponent _db = new DBComponent();
        public cursito()
        {
            InitializeComponent();
            textBox1.TextChanged += textBox1_TextChanged;
        }

        private void Curso_Load(object sender, EventArgs e)
        {
            ConfigureGrid();
            LoadCursos();
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
                HeaderText = "codigo",
                DataPropertyName = "Id_curso",
                Width = 120
            };
            var colSeccion = new DataGridViewTextBoxColumn
            {
                Name = "Seccion",
                HeaderText = "Sección",
                DataPropertyName = "seccion_de",
                Width = 220
            };
            var colMateria = new DataGridViewTextBoxColumn
            {
                Name = "Materia",
                HeaderText = "Materia",
                DataPropertyName = "materia_na",
                Width = 320
            };
            var colProfesor = new DataGridViewTextBoxColumn
            {
                Name = "Profesor",
                HeaderText = "Profesor",
                DataPropertyName = "Profesor_nombre",
                Width = 340
            };
            dataGridViewmateria.Columns.AddRange(btnEditar, colCodigo, colSeccion, colMateria, colProfesor);
            dataGridViewmateria.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridViewmateria.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewmateria.ColumnHeadersHeight = 35;
            dataGridViewmateria.RowHeadersVisible = false;
            dataGridViewmateria.RowTemplate.Height = 30;
            dataGridViewmateria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewmateria.Columns["Editar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewmateria.Columns["Editar"].Width = 60;
        }

        private void LoadCursos(string searchTerm = null)
        {
            try
            {
                dataGridViewmateria.DataSource = null;
                IEnumerable<dynamic> cursos;
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    cursos = _db.Query<dynamic>("Curso", "GetAllComplete");
                }
                else
                {
                    var resultados = _db.Query<dynamic>("Curso", "Search", new { SearchTerm = $"%{searchTerm}%" });
                    cursos = resultados;
                }
                dataGridViewmateria.DataSource = cursos.ToList();
                dataGridViewmateria.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cursos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarCurso form = new EliminarCurso();
            form.Show();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarCurso form = new AgregarCurso();
            form.Show();
        }

        private void dataGridViewmateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridViewmateria.Columns[e.ColumnIndex].Name == "Editar")
            {
                var id = dataGridViewmateria.Rows[e.RowIndex].Cells["Codigo"].Value?.ToString();
                var seccion = dataGridViewmateria.Rows[e.RowIndex].Cells["Seccion"].Value?.ToString();
                var materia = dataGridViewmateria.Rows[e.RowIndex].Cells["Materia"].Value?.ToString();
                var profesor = dataGridViewmateria.Rows[e.RowIndex].Cells["Profesor"].Value?.ToString();
                var formEditar = new Acciones.EditarCurso();
                formEditar.Tag = new { Id_curso = id, seccion_de = seccion, materia_na = materia, Profesor_nombre = profesor };
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    LoadCursos();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadCursos(textBox1.Text.Trim());
        }
    }
}
