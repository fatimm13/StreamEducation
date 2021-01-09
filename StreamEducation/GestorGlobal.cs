using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamEducation
{
    public static class GestorGlobal
    {
        private static Usuario usuarioActivo;
        private static Curso cursoActivo;
        private static Foro foroActivo;
        private static Debate debateActivo;
        private static Actividad actividadActiva;
        private static Dictionary<DateTime, List<string>> calendario = new Dictionary<DateTime, List<string>>();
        
        public static Usuario UsuarioActivo
        {
            get { return usuarioActivo; }
            set { usuarioActivo = value; }
        }
        public static Curso CursoActivo
        {
            get { return cursoActivo; }
            set { cursoActivo = value; }
        }
        public static Foro ForoActivo
        {
            get { return foroActivo; }
            set { foroActivo = value; }
        }
        public static Debate DebateActivo
        {
            get { return debateActivo; }
            set { debateActivo = value; }
        }

        public static Actividad ActividadActiva 
        {
            get { return actividadActiva; }
            set { actividadActiva = value; }
        }

        private static void addFecha(DateTime d, string s)
        {
            List<string> value;

            if (calendario.TryGetValue(d, out value))
            {
                if (!value.Contains(s)) value.Add(s);
            }
            else
            {
                value = new List<string>();
                value.Add(s);
                calendario.Add(d, value);
            }
        }

        public static Dictionary<DateTime, List<string>> getCalendario()
        {
            return calendario;
        }
        public static void rellenarCalendario()
        {
            calendario = new Dictionary<DateTime, List<string>>();
            foreach ((DateTime, string) t in Curso.cursosPublicoCalendario())
            {
                GestorGlobal.addFecha(t.Item1, "Inicia el curso '" + t.Item2 + "'.");
            }
            foreach ((DateTime, string) t in Actividad.actividadesCalendario())
            {
                GestorGlobal.addFecha(t.Item1, "Inicia la actividad '" + t.Item2 + "'.");
            }
            if (GestorGlobal.UsuarioActivo != null)
            {

                foreach ((DateTime, string) t in usuarioActivo.getCursosPrivadosCalendario())
                {
                    GestorGlobal.addFecha(t.Item1, "Inicia el curso '" + t.Item2 + "'.");
                }
            }
        }
        
        
    }
}
