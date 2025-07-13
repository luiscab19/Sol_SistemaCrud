using SistemaCRUD.Core;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaCrud.Presentacion.Mantenimiento.Materia.Acciones
{
    public partial class Elimina : Form
    {
        private readonly DBComponent _db;

        public Elimina()
        {
            InitializeComponent();
            _db = new DBComponent();
        }

        private void EliminarMateria_Load(object sender, EventArgs e)
        {
            // Opcional: Cargar todas las materias en un ComboBox
            // CargarMaterias();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreMateria = textBoxEliminarMateria.Text.Trim();

                // Validar que se ingresó un nombre
                if (string.IsNullOrWhiteSpace(nombreMateria))
                {
                    MessageBox.Show("Debe ingresar el nombre de la materia a eliminar", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si existe la materia
                bool existe = _db.ExecuteScalar<int>("Materia", "Exists",
                                    new { Nombre = nombreMateria }) > 0;

                if (!existe)
                {
                    MessageBox.Show("No existe una materia con ese nombre", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar eliminación
                var confirmacion = MessageBox.Show($"¿Está seguro de eliminar la materia '{nombreMateria}'?",
                                                "Confirmar eliminación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    // Eliminar la materia
                    int filasAfectadas = _db.Execute("Materia", "Delete",
                                        new { Nombre = nombreMateria });

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Materia eliminada exitosamente", "Éxito",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la materia", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la materia: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eventos auxiliares
        private void textBoxEliminarMateria_TextChanged(object sender, EventArgs e) { }
        private void labelNombreMateria_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}