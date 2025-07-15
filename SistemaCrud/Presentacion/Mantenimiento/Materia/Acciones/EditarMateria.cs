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

namespace SistemaCrud.Presentacion.Mantenimiento.Materia.Acciones
{
    public partial class EditarMateria : Form
    {
        private readonly DBComponent _db = new DBComponent();
        private string nombreOriginal = null;
        public EditarMateria()
        {
            InitializeComponent();
        }

        private void labelAñadirMateria_Click(object sender, EventArgs e)
        {

        }

        private void labelNombreMateria_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEditarMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditarMateria_Load(object sender, EventArgs e)
        {
            // Si se pasan datos por Tag, asignarlos a los TextBox
            if (this.Tag != null)
            {
                dynamic datos = this.Tag;
                textBoxEditarMateria.Text = datos.materia_na ?? string.Empty;
                textBoxEditarContenido.Text = datos.materia_de ?? string.Empty;
                nombreOriginal = datos.materia_na ?? string.Empty;
            }
        }

        private void labelContenido_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEditarContenido_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = textBoxEditarMateria.Text.Trim();
            string nuevoContenido = textBoxEditarContenido.Text.Trim();

            if (string.IsNullOrWhiteSpace(nuevoNombre))
            {
                MessageBox.Show("Debe ingresar un nombre para la materia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int filasAfectadas = _db.Execute("Materia", "Update", new
                {
                    Nombre = nuevoNombre,
                    Descripcion = nuevoContenido,
                    NombreOriginal = nombreOriginal
                });
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Materia actualizada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la materia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
