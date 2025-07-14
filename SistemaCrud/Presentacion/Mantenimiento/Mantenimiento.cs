using SistemaCrud.Presentacion.Mantenimiento.Curso;
using SistemaCrud.Presentacion.Mantenimiento.Materia.Acciones;
using SistemaCrud.Presentacion.Mantenimiento.Persona;
using SistemaCrud.Presentacion.Mantenimiento.Persona.Acciones;
using SistemaCrud.Presentacion.Mantenimiento.Seccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCrud.Presentacion.Mantenimiento
{
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void buttonMateria_Click(object sender, EventArgs e)
        {
            materia form = new materia();
            form.Show();
        }

        private void buttonCurso_Click(object sender, EventArgs e)
        {
            cursito form = new cursito();
            form.Show();
        }

        private void buttonPersona_Click(object sender, EventArgs e)
        {
            Personas form = new Personas();
            form.Show();
        }

        private void buttonSeccion_Click(object sender, EventArgs e)
        {
            seccion form = new seccion();
            form.Show();
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {

        }
    }
}
