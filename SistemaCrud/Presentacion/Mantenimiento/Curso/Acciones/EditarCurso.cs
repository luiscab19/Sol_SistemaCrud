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

namespace SistemaCrud.Presentacion.Mantenimiento.Curso.Acciones
{
    public partial class EditarCurso : Form
    {
        private readonly DBComponent _db = new DBComponent();
        private int idOriginal;
        public EditarCurso()
        {
            InitializeComponent();
        }

        private void labelNombreMateria_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAgregarCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSeccion_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EditarCurso_Load(object sender, EventArgs e)
        {
            CargarSecciones();
            CargarMaterias();
            CargarProfesores();
            if (this.Tag != null)
            {
                dynamic datos = this.Tag;
                textBoxAgregarCodigo.Text = datos.Id_curso?.ToString() ?? string.Empty;
                int.TryParse(datos.Id_curso?.ToString(), out idOriginal);
                // Seleccionar sección
                if (!string.IsNullOrEmpty(datos.seccion_de))
                {
                    int idx = comboBoxSeccion.FindStringExact(datos.seccion_de);
                    if (idx >= 0) comboBoxSeccion.SelectedIndex = idx;
                }
                // Seleccionar materia
                if (!string.IsNullOrEmpty(datos.materia_na))
                {
                    int idx = comboBoxMateria.FindStringExact(datos.materia_na);
                    if (idx >= 0) comboBoxMateria.SelectedIndex = idx;
                }
                // Seleccionar profesor
                if (!string.IsNullOrEmpty(datos.Profesor_nombre))
                {
                    int idx = comboBoxProfesor.FindStringExact(datos.Profesor_nombre);
                    if (idx >= 0) comboBoxProfesor.SelectedIndex = idx;
                }
            }
        }

        private void CargarSecciones()
        {
            var secciones = _db.Query<dynamic>("Seccion", "GetAll");
            comboBoxSeccion.DataSource = secciones.ToList();
            comboBoxSeccion.DisplayMember = "seccion_de";
            comboBoxSeccion.ValueMember = "seccion_id";
        }
        private void CargarMaterias()
        {
            var materias = _db.Query<dynamic>("Materia", "GetAll");
            comboBoxMateria.DataSource = materias.ToList();
            comboBoxMateria.DisplayMember = "materia_na";
            comboBoxMateria.ValueMember = "materia_na";
        }
        private void CargarProfesores()
        {
            var profesores = _db.Query<dynamic>("Persona", "SelectProfesores");
            comboBoxProfesor.DataSource = profesores.ToList();
            comboBoxProfesor.DisplayMember = "Persona_no";
            comboBoxProfesor.ValueMember = "Persona_id";
        }

        private void comboBoxProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string nuevoCodigo = textBoxAgregarCodigo.Text.Trim();
            if (string.IsNullOrWhiteSpace(nuevoCodigo) || comboBoxSeccion.SelectedValue == null || comboBoxMateria.SelectedValue == null || comboBoxProfesor.SelectedValue == null)
            {
                MessageBox.Show("Debe completar todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int idNuevo;
                if (!int.TryParse(nuevoCodigo, out idNuevo))
                {
                    MessageBox.Show("El código debe ser un número", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int seccionId = (int)comboBoxSeccion.SelectedValue;
                string materiaNombre = comboBoxMateria.SelectedValue.ToString();
                int profesorId = (int)comboBoxProfesor.SelectedValue;
                int filasAfectadas = _db.Execute("Curso", "Update", new { Id = idNuevo, SeccionId = seccionId, MateriaNombre = materiaNombre, ProfesorId = profesorId });
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Curso actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
