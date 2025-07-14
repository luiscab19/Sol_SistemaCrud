using SistemaCrud.Presentacion.Mantenimiento.Persona.Acciones;
using SistemaCrud.Presentacion.Mantenimiento.Seccion.Acciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCrud.Presentacion.Mantenimiento.Seccion
{
    public partial class seccion : Form
    {
        public seccion()
        {
            InitializeComponent();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarSeccion form = new EliminarSeccion();
            form.Show();
        }

        private void seccion_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarSeccion form = new AgregarSeccion();
            form.Show();
        }

        private void dataGridViewmateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
