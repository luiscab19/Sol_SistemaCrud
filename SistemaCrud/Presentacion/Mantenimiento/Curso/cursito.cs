using SistemaCrud.Presentacion.Mantenimiento.Curso.Acciones;
using SistemaCrud.Presentacion.Mantenimiento.Materia.Acciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCrud.Presentacion.Mantenimiento.Curso
{
    public partial class cursito : Form
    {
        public cursito()
        {
            InitializeComponent();
        }

        private void Curso_Load(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarCurso form = new EliminarCurso();
            form.Show();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarCurso form = new AgregarCurso();
            form.Show();
        }

        private void dataGridViewmateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
