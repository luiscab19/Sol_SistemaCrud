using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProcesoCRUD.Entidades;
using SistemaCRUD.Core;

namespace SistemaCrud.Presentacion.Mantenimiento.Seccion.Acciones
{
    public partial class AgregarSeccion : Form
    {
        private readonly DBComponent _db = new DBComponent();
        private E_Seccion _seccion = new E_Seccion();
        public AgregarSeccion()
        {
            InitializeComponent();
            // Data binding
            textBoxAgregarCodigo.DataBindings.Add("Text", _seccion, "seccion_id", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxContenido.DataBindings.Add("Text", _seccion, "seccion_de", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void AgregarSeccion_Load(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el código y la sección no estén vacíos
                if (_seccion.seccion_id == 0)
                {
                    MessageBox.Show("Debe ingresar un código para la sección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxAgregarCodigo.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(_seccion.seccion_de))
                {
                    MessageBox.Show("Debe ingresar el nombre de la sección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxContenido.Focus();
                    return;
                }
                // Verificar si ya existe
                bool existe = _db.ExecuteScalar<int>("Seccion", "Exists", new { Id = _seccion.seccion_id, Nombre = _seccion.seccion_de.Trim() }) > 0;
                if (existe)
                {
                    MessageBox.Show("Ya existe una sección con este código o nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Insertar en la base de datos
                _db.Execute("Seccion", "Insert", new { Id = _seccion.seccion_id, Nombre = _seccion.seccion_de.Trim() });
                MessageBox.Show("Sección registrada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la sección:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelSeccion_Click(object sender, EventArgs e)
        {

        }

        private void labelCodigo_Click(object sender, EventArgs e)
        {

        }

        private void textBoxContenido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAgregarCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
