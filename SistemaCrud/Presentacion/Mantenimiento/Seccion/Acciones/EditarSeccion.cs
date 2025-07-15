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
    public partial class EditarSeccion : Form
    {
        private readonly DBComponent _db = new DBComponent();
        private int seccionIdOriginal;

        public EditarSeccion()
        {
            InitializeComponent();
        }

        private void EditarSeccion_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                dynamic datos = this.Tag;
                textBoxCodigoSeccion.Text = datos.seccion_id?.ToString() ?? string.Empty;
                textBoxSeccion.Text = datos.seccion_de ?? string.Empty;
                int.TryParse(datos.seccion_id?.ToString(), out seccionIdOriginal);
            }
        }

        private void textBoxCodigoSeccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNombreMateria_Click(object sender, EventArgs e)
        {

        }

        private void labelSeccion_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSeccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string nuevoCodigo = textBoxCodigoSeccion.Text.Trim();
            string nuevaSeccion = textBoxSeccion.Text.Trim();
            if (string.IsNullOrWhiteSpace(nuevoCodigo) || string.IsNullOrWhiteSpace(nuevaSeccion))
            {
                MessageBox.Show("Debe ingresar el código y la sección", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int filasAfectadas = _db.Execute("Seccion", "Update", new { Id = idNuevo, Nombre = nuevaSeccion });
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Sección actualizada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la sección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la sección: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
