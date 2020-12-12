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
    }
}
