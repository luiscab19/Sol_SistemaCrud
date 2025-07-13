namespace ProcesoCRUD.Entidades
{
    public class E_Persona
    {
        public int Persona_id { get; set; }
        public string Persona_no { get; set; }
        public int Tipo_persona_id { get; set; }
        public string Tipo_persona_de { get; set; }

        public E_Persona()
        {
            Persona_no = " ";
            Tipo_persona_de =  "";
        }

    }
}

