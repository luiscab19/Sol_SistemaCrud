using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SistemaCRUD.Core;

namespace SistemaCrud.Presentacion.Mantenimiento.Materia.Acciones
{
    public partial class materia : Form
    {
        private readonly DBComponent _db;

        public materia()
        {
            InitializeComponent();
            _db = new DBComponent();
            ConfigureGrid();
            LoadMaterias(); // Cargar datos al iniciar
        }

        private void ConfigureGrid()
        {
            // Configuración básica del DataGridView
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

            // Limpiar columnas existentes
            dataGridViewmateria.Columns.Clear();

            // Columnas del DataGridView
            var btnEditar = new DataGridViewButtonColumn
            {
                Name = "Editar",
                HeaderText = "Editar",
                Text = "✏️",
                UseColumnTextForButtonValue = true,
                Width = 60,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };

            var colMateria = new DataGridViewTextBoxColumn
            {
                Name = "Materia",
                HeaderText = "Materia",
                DataPropertyName = "materia_na",
                Width = 350,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Padding = new Padding(5, 0, 0, 0)
                }
            };

            var colContenido = new DataGridViewTextBoxColumn
            {
                Name = "Contenido",
                HeaderText = "Contenido",
                DataPropertyName = "materia_de",
                Width = 600,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Padding = new Padding(5, 0, 0, 0)
                }
            };

            dataGridViewmateria.Columns.AddRange(btnEditar, colMateria, colContenido);

            // Estilo de las celdas
            dataGridViewmateria.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridViewmateria.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewmateria.ColumnHeadersHeight = 35;
            dataGridViewmateria.RowHeadersVisible = false;
            dataGridViewmateria.RowTemplate.Height = 30;
        }

        private void LoadMaterias(string searchTerm = null)
        {
            try
            {
                dataGridViewmateria.DataSource = null;

                IEnumerable<dynamic> materias;
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    materias = _db.Query<dynamic>("Materia", "GetAll");
                }
                else
                {
                    // Usar la consulta Search y mapear los resultados a materia_na y materia_de, cubriendo ambos casos
                    var resultados = _db.Query<dynamic>("Materia", "Search", new { SearchTerm = $"%{searchTerm}%" });
                    materias = resultados.Select(m => new {
                        materia_na = m.materia_na ?? m.Nombre ?? "",
                        materia_de = m.materia_de ?? m.Contenido ?? ""
                    });
                }

                dataGridViewmateria.DataSource = materias.ToList();
                dataGridViewmateria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewmateria.Columns["Editar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridViewmateria.Columns["Editar"].Width = 60;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar materias: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ToDataTable(IEnumerable<dynamic> items)
        {
            var dt = new DataTable();

            if (!items.Any()) return dt;

            // Crear columnas basadas en las propiedades del primer elemento
            var firstItem = (IDictionary<string, object>)items.First();
            foreach (var key in firstItem.Keys)
            {
                dt.Columns.Add(key);
            }

            // Llenar filas
            foreach (var item in items)
            {
                var row = dt.NewRow();
                var itemDict = (IDictionary<string, object>)item;

                foreach (var prop in itemDict)
                {
                    row[prop.Key] = prop.Value ?? DBNull.Value;
                }
                dt.Rows.Add(row);
            }

            return dt;
        }

        private void dataGridViewmateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridViewmateria.Columns[e.ColumnIndex].Name == "Editar")
            {
                var nombreMateria = dataGridViewmateria.Rows[e.RowIndex].Cells["Materia"].Value?.ToString();
                var contenido = dataGridViewmateria.Rows[e.RowIndex].Cells["Contenido"].Value?.ToString();

                // Abrir pantalla de edición de materia
                var formEditar = new Acciones.EditarMateria();
                formEditar.Tag = new { materia_na = nombreMateria, materia_de = contenido };
                if (formEditar.ShowDialog() == DialogResult.OK)
                {
                    LoadMaterias(); // Refrescar datos después de editar
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadMaterias(textBox1.Text.Trim());
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Elimina form = new Elimina();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadMaterias();
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarMateria form = new AgregarMateria();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadMaterias();
            }
        }

        private void materia_Load(object sender, EventArgs e)
        {
            // Puede usarse para inicializaciones adicionales
        }
    }
}