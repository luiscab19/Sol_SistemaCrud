using Npgsql;
using ProcesoCRUD.Entidades;
using SistemaCRUD.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCrud.Presentacion.Mantenimiento.Persona.Acciones
{
    public partial class Agregar_Persona : Form
    {
        private readonly DBComponent _db;
        private E_Persona _persona;

        public Agregar_Persona()
        {
            InitializeComponent();
            _db = new DBComponent();
            _persona = new E_Persona();

            // Configurar enlace de datos
            textBoxAgregarNombre.DataBindings.Add("Text", _persona, "Persona_no",
                true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxCedula.DataBindings.Add("Text", _persona, "Persona_id",
                true, DataSourceUpdateMode.OnPropertyChanged);

            // Cargar tipos de persona fijos
            CargarTiposPersona();
        }

        private void CargarTiposPersona()
        {
            try
            {
                // Lista fija de tipos de persona
                var tipos = new List<dynamic>
                {
                    new { tipo_persona_id = 1, tipo_persona_de = "Estudiante" },
                    new { tipo_persona_id = 2, tipo_persona_de = "Trabajador" }
                };

                comboBoxTipoPersona.DataSource = tipos;
                comboBoxTipoPersona.DisplayMember = "tipo_persona_de";
                comboBoxTipoPersona.ValueMember = "tipo_persona_id";
                comboBoxTipoPersona.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de persona: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(_persona.Persona_no))
                {
                    MessageBox.Show("Debe ingresar un nombre", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxAgregarNombre.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(_persona.Persona_id))
                {
                    MessageBox.Show("Debe ingresar una cédula", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxCedula.Focus();
                    return;
                }
                // Validar que la cédula sea numérica
                if (!long.TryParse(_persona.Persona_id.Trim(), out _))
                {
                    MessageBox.Show("La cédula debe ser un valor numérico", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxCedula.Focus();
                    return;
                }
                // Obtener el tipo de persona seleccionado
                _persona.Tipo_persona_id = (int)comboBoxTipoPersona.SelectedValue;
                // Verificar si ya existe una persona con esta cédula
                bool existeCedula = _db.ExecuteScalar<int>("Persona", "ExistsById",
                                        new { Id = _persona.Persona_id.Trim() }) > 0;
                if (existeCedula)
                {
                    MessageBox.Show("Ya existe una persona con esta cédula", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Verificar si ya existe una persona con este nombre
                bool existeNombre = _db.ExecuteScalar<int>("Persona", "ExistsByName",
                                        new { Nombre = _persona.Persona_no.Trim() }) > 0;
                if (existeNombre)
                {
                    MessageBox.Show("Ya existe una persona con este nombre", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Insertar en la base de datos usando la cédula como ID
                _db.Execute("Persona", "Insert", new
                {
                    Id = _persona.Persona_id.Trim(),
                    Nombre = _persona.Persona_no.Trim(),
                    TipoPersonaId = _persona.Tipo_persona_id
                });
                MessageBox.Show($"Persona registrada exitosamente con cédula: {_persona.Persona_id}", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Npgsql.PostgresException pex)
            {
                MessageBox.Show($"Error de base de datos: {pex.MessageText}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la persona: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eventos auxiliares
        private void Agregar_Persona_Load(object sender, EventArgs e) { }
        private void comboBoxTipoPersona_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBoxCedula_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void labelCedula_Click(object sender, EventArgs e) { }
        private void labelNombreMateria_Click(object sender, EventArgs e) { }
        private void textBoxAgregarNombre_TextChanged(object sender, EventArgs e) { }
    }
}