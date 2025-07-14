using ProcesoCRUD.Entidades;
using SistemaCRUD.Core;
using System;
using System.Windows.Forms;

namespace SistemaCrud.Presentacion.Mantenimiento.Curso.Acciones
{
    public partial class AgregarCurso : Form
    {
        private readonly DBComponent _db;
        private E_Curso _curso;

        public AgregarCurso()
        {
            InitializeComponent();
            _db = new DBComponent();
            _curso = new E_Curso();

            // Configurar enlace de datos
            comboBoxSeccion.DataBindings.Add("SelectedValue", _curso, "Seccion_id", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxMateria.DataBindings.Add("Text", _curso, "Materia_na", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxProfesor.DataBindings.Add("SelectedValue", _curso, "Persona_id", true, DataSourceUpdateMode.OnPropertyChanged);

            // Cargar datos iniciales
            CargarSecciones();
            CargarMaterias();
            CargarProfesores();
        }

        private void CargarSecciones()
        {
            try
            {
                var secciones = _db.Query<E_Seccion>("Seccion", "GetAll");
                comboBoxSeccion.DataSource = secciones;
                comboBoxSeccion.DisplayMember = "seccion_de";
                comboBoxSeccion.ValueMember = "seccion_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar secciones:\n{ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMaterias()
        {
            try
            {
                var materias = _db.Query<E_Materia>("Materia", "GetAll");
                comboBoxMateria.DataSource = materias;
                comboBoxMateria.DisplayMember = "materia_na";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar materias:\n{ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProfesores()
        {
            try
            {
                var profesores = _db.Query<E_Persona>("Persona", "SelectProfesores");
                comboBoxProfesor.DataSource = profesores;
                comboBoxProfesor.DisplayMember = "Persona_no";
                comboBoxProfesor.ValueMember = "Persona_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar profesores:\n{ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar selección de sección
                if (_curso.Seccion_id == 0)
                {
                    MessageBox.Show("Debe seleccionar una sección", "Validación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxSeccion.Focus();
                    return;
                }

                // Validar selección de materia
                if (string.IsNullOrWhiteSpace(_curso.Materia_na))
                {
                    MessageBox.Show("Debe seleccionar una materia", "Validación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxMateria.Focus();
                    return;
                }

                // Validar selección de profesor
                if (_curso.Persona_id == 0)
                {
                    MessageBox.Show("Debe seleccionar un profesor", "Validación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxProfesor.Focus();
                    return;
                }

                // Verificar si el curso ya existe
                bool existe = _db.ExecuteScalar<int>("Curso", "Exists", new
                {
                    SeccionId = _curso.Seccion_id,
                    MateriaNombre = _curso.Materia_na.Trim()
                }) > 0;

                if (existe)
                {
                    MessageBox.Show("Este curso ya está registrado", "Validación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insertar nuevo curso
                var nuevoId = _db.ExecuteScalar<int>("Curso", "Insert", new
                {
                    seccion_id = _curso.Seccion_id,
                    materia_na = _curso.Materia_na.Trim(),
                    persona_id = _curso.Persona_id
                });

                MessageBox.Show($"Curso creado exitosamente (ID: {nuevoId})", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el curso:\n{ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eventos de los controles (pueden mantenerse vacíos)
        private void AgregarCurso_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void labelNombreMateria_Click(object sender, EventArgs e) { }
        private void textBoxAgregarCodigo_TextChanged(object sender, EventArgs e) { }
        private void labelSeccion_Click(object sender, EventArgs e) { }
        private void comboBoxSeccion_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void comboBoxMateria_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void comboBoxProfesor_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}