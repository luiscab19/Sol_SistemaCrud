using ProcesoCRUD.Entidades;
using SistemaCRUD.Core;
using System;
using System.Windows.Forms;

namespace SistemaCrud.Presentacion.Mantenimiento.Materia.Acciones
{
    public partial class AgregarMateria : Form
    {
        private readonly DBComponent _db;
        private E_Materia _materia;

        public AgregarMateria()
        {
            InitializeComponent();
            _db = new DBComponent();
            _materia = new E_Materia();

            // Configurar enlace de datos
            textBoxAgregarMateria.DataBindings.Add("Text", _materia, "Materia_na", true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxContenido.DataBindings.Add("Text", _materia, "Materia_de", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el nombre no esté vacío
                if (string.IsNullOrWhiteSpace(_materia.Materia_na))
                {
                    MessageBox.Show("Debe ingresar un nombre para la materia", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxAgregarMateria.Focus();
                    return;
                }

                // Verificar si ya existe
                bool existe = _db.ExecuteScalar<int>("Materia", "Exists",
                                        new { Nombre = _materia.Materia_na.Trim() }) > 0;

                if (existe)
                {
                    MessageBox.Show("Ya existe una materia con este nombre", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insertar en la base de datos
                _db.Execute("Materia", "Insert", new
                {
                    Nombre = _materia.Materia_na.Trim(),
                    Descripcion = _materia.Materia_de?.Trim() ?? string.Empty
                });

                MessageBox.Show("Registro exitoso", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la materia:\n{ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eventos existentes (pueden mantenerse vacíos si no tienen lógica adicional)
        private void labelNombreMateria_Click(object sender, EventArgs e) { }
        private void textBoxAgregarMateria_TextChanged(object sender, EventArgs e) { }
        private void labelContenido_Click(object sender, EventArgs e) { }
        private void textBoxContenido_TextChanged(object sender, EventArgs e) { }
        private void Agregar_Load(object sender, EventArgs e) { }
    }
}