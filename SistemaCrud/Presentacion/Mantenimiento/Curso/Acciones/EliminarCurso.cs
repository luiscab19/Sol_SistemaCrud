using SistemaCRUD.Core;
using System;
using System.Windows.Forms;

namespace SistemaCrud.Presentacion.Mantenimiento.Curso.Acciones
{
    public partial class EliminarCurso : Form
    {
        private readonly DBComponent _db;

        public EliminarCurso()
        {
            InitializeComponent();
            _db = new DBComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se ingresó un ID válido
                if (!int.TryParse(textBoxEliminarCurso.Text.Trim(), out int idCurso))
                {
                    MessageBox.Show("Debe ingresar un código de curso válido", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si existe el curso
                bool existe = _db.ExecuteScalar<int>("Curso", "ExistsById",
                                    new { Id = idCurso }) > 0;

                if (!existe)
                {
                    MessageBox.Show("No existe un curso con ese código", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener información del curso para mostrar en la confirmación
                var cursoInfo = _db.QueryFirstOrDefault<dynamic>("Curso", "SelectByIdComplete",
                                    new { Id = idCurso });

                // Confirmar eliminación
                var confirmacion = MessageBox.Show($"¿Está seguro de eliminar el curso con ID: {idCurso}?\n" +
                                                  $"Materia: {cursoInfo.materia_na}\n" +
                                                  $"Sección: {cursoInfo.seccion_de}\n" +
                                                  $"Profesor: {cursoInfo.Profesor_nombre}",
                                                  "Confirmar eliminación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    // Eliminar el curso
                    int filasAfectadas = _db.Execute("Curso", "Delete",
                                        new { Id = idCurso });

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Curso eliminado exitosamente", "Éxito",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el curso", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el curso: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eventos auxiliares
        private void textBoxEliminarCurso_TextChanged(object sender, EventArgs e) { }
        private void labelNombreCurso_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void EliminarCurso_Load(object sender, EventArgs e) { }
    }
}