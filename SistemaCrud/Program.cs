using System;
using System.Windows.Forms;

namespace ProyectoCRUD
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicaci�n.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SistemaCrud.Presentacion.Mantenimiento.Materia.Acciones.materia());
        }
    }
}
