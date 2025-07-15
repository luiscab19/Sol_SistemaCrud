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

namespace SistemaCrud.Presentacion.Mantenimiento.Persona.Acciones
{
    public partial class EliminarPersona : Form
    {
        private readonly DBComponent _db = new DBComponent();
        public EliminarPersona()
        {
            InitializeComponent();
        }

        private void EliminarPersona_Load(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se ingresó un ID válido
                if (!int.TryParse(textBoxEliminarPersona.Text.Trim(), out int personaId))
                {
                    MessageBox.Show("Debe ingresar un ID de persona válido", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si existe la persona
                bool existe = _db.ExecuteScalar<int>("Persona", "ExistsById", new { Id = personaId }) > 0;
                if (!existe)
                {
                    MessageBox.Show("No existe una persona con ese ID", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar dependencias (cursos o inscripciones)
                int dependencias = _db.ExecuteScalar<int>("Persona", "CheckDependencies", new { Id = personaId });
                if (dependencias > 0)
                {
                    MessageBox.Show("No se puede eliminar la persona porque tiene dependencias (cursos o inscripciones)", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar eliminación
                var confirmacion = MessageBox.Show($"¿Está seguro de eliminar la persona con ID: {personaId}?",
                                                  "Confirmar eliminación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    int filasAfectadas = _db.Execute("Persona", "Delete", new { Id = personaId });
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Persona eliminada exitosamente", "Éxito",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la persona", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la persona: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelEliminarPersona_Click(object sender, EventArgs e)
        {

        }

        private void labelCedulaPersona_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEliminarPersona_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
