namespace ProcesoCRUD.Entidades
{
    public class E_Curso
    {
        public int Id_curso { get; set; }
        public int Seccion_id { get; set; }
        public string Seccion_de { get; set; }
        public string Materia_na { get; set; }
        public string Materia_de { get; set; }
        public int Persona_id { get; set; } // Profesor
        public string Profesor_nombre { get; set; }

        public string CursoCompleto => $"{Materia_de} - Sección {Seccion_de}";
    }
}