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
    public partial class EditarPersona : Form
    {
        private readonly DBComponent _db = new DBComponent();
        private int idOriginal;
        public EditarPersona()
        {
            InitializeComponent();
        }

        private void labelNombreMateria_Click(object sender, EventArgs e)
        {


        }

        private void textBoxAgregarNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCedula_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string nuevoNombre = textBoxAgregarNombre.Text.Trim();
            string nuevaCedula = textBoxCedula.Text.Trim();
            if (string.IsNullOrWhiteSpace(nuevoNombre) || string.IsNullOrWhiteSpace(nuevaCedula))
            {
                MessageBox.Show("Debe ingresar el nombre y la cédula", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxTipoPersona.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar el tipo de persona", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int nuevoId;
                if (!int.TryParse(nuevaCedula, out nuevoId))
                {
                    MessageBox.Show("La cédula debe ser un número", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int tipoPersonaId = (int)comboBoxTipoPersona.SelectedValue;
                int filasAfectadas = _db.Execute("Persona", "Update", new { NuevoId = nuevoId, Nombre = nuevoNombre, TipoPersonaId = tipoPersonaId, IdOriginal = idOriginal });
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Persona actualizada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la persona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarPersona_Load(object sender, EventArgs e)
        {
            CargarTiposPersona();
            if (this.Tag != null)
            {
                dynamic datos = this.Tag;
                textBoxAgregarNombre.Text = datos.persona_no ?? string.Empty;
                textBoxCedula.Text = datos.persona_id?.ToString() ?? string.Empty;
                int.TryParse(datos.persona_id?.ToString(), out idOriginal);
                // Asignar tipo de persona si está en el combo
                if (!string.IsNullOrEmpty(datos.tipo_persona_de))
                {
                    int idx = comboBoxTipoPersona.FindStringExact(datos.tipo_persona_de);
                    if (idx >= 0) comboBoxTipoPersona.SelectedIndex = idx;
                }
            }
        }

        private void CargarTiposPersona()
        {
            try
            {
                var tipos = _db.Query<dynamic>("TipoPersona", "GetAll");
                comboBoxTipoPersona.DataSource = tipos.ToList();
                comboBoxTipoPersona.DisplayMember = "tipo_persona_de";
                comboBoxTipoPersona.ValueMember = "tipo_persona_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de persona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
