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

namespace SistemaCrud.Presentacion.Mantenimiento.Seccion.Acciones
{
    public partial class EliminarSeccion : Form
    {
        private readonly DBComponent _db = new DBComponent();
        public EliminarSeccion()
        {
            InitializeComponent();
        }

        private void EliminarSeccion_Load(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se ingresó un ID válido
                if (!int.TryParse(textBoxEliminarSeccion.Text.Trim(), out int seccionId))
                {
                    MessageBox.Show("Debe ingresar un código de sección válido", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si existe la sección
                bool existe = _db.ExecuteScalar<int>("Seccion", "Exists", new { Id = seccionId, Nombre = "" }) > 0;
                if (!existe)
                {
                    MessageBox.Show("No existe una sección con ese código", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si hay cursos asociados a la sección
                int cursosAsociados = _db.ExecuteScalar<int>("Curso", "ExistsById", new { Id = seccionId });
                if (cursosAsociados > 0)
                {
                    MessageBox.Show("No se puede eliminar la sección porque tiene cursos asociados.", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar eliminación
                var confirmacion = MessageBox.Show($"¿Está seguro de eliminar la sección con código: {seccionId}?",
                                                  "Confirmar eliminación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    int filasAfectadas = _db.Execute("Seccion", "Delete", new { Id = seccionId });
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Sección eliminada exitosamente", "Éxito",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la sección", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la sección: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelNombreSeccion_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEliminarSeccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
