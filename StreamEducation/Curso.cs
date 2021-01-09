using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamEducation
{
    public class Curso
    {

        private static string CONNECTION = Properties.Settings.Default.COMPLETE;
        
        private int id;
        private Usuario profesor;
        private string nombre;
        private string descripcion;
        private bool esPublico;
        private string fecha;

        public Curso(int miId)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT * FROM tCurso WHERE id = " + miId + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    id = (int)rdr[0];
                    profesor = new Usuario((int)rdr[1]);
                    nombre = (string)rdr[2];
                    descripcion = (string)rdr[3];
                    esPublico = (int)rdr[4] == 1;
                    fecha = (string)rdr[5];
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error recuperando curso de la BD.");
                ventana.ShowDialog();
            }
        }

        public Curso(Usuario miProfesor, string miNombre, string miDescripcion, bool publico, string miFecha)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tCurso (profesor, nombre, descripcion, publico, fecha) VALUES("
                    + miProfesor.Id + ", '" + miNombre + "', '" + miDescripcion + "', '" + (publico ? 1 : 0) + "', '" + miFecha + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();

                string query2 = "SELECT MAX(id) FROM tCurso WHERE profesor = '" + miProfesor.Id +"';";
                MySqlCommand cmd2 = new MySqlCommand(query2, miBD);
                id = (int)cmd2.ExecuteScalar();
                profesor = miProfesor;
                nombre = miNombre;
                descripcion = miDescripcion;
                esPublico = publico;
                fecha = miFecha;
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al crear un curso nuevo.");
                ventana.ShowDialog();
            }
        }

        public int Id
        {
            get { return id; }
        }

        public Usuario Profesor
        {
            get { return profesor; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Descripcion
        {
            get { return descripcion; }
        }

        public bool Publico
        {
            get { return esPublico; }
        }

        public string Fecha
        {
            get { return fecha; }
        }

        public override string ToString()
        {
            return nombre;
        }

        public void Borrar()
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "DELETE FROM tCurso WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                miBD.Close();
                id = -1;
                profesor = null;
                nombre = null;
                descripcion = null;
                esPublico = false;
                fecha = null;
            }
            catch
            {
                fError ventana = new fError("Error al intentar borrar el curso.");
                ventana.ShowDialog();
            }
        }

        public static List<(int, string, int)> listaCursos()
        {
            List<(int, string, int)> lista = new List<(int, string, int)>();
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT id, nombre, publico FROM tCurso WHERE id > 0;";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    lista.Add(((int)rdr[0], (string)rdr[1], (int)rdr[2]));
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al acceder a los cursos disponibles.");
                ventana.ShowDialog();
            }
            return lista;
        }

        public static List<string> getCursosPublicosFecha(string fecha)
        {
            List<string> lista = new List<string>();
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT nombre FROM tCurso where publico = 1 and fecha like '" + fecha + "';";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    lista.Add((string)rdr[0]);
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al acceder a los cursos disponibles.");
                ventana.ShowDialog();
            }
            return lista;
        }

        public List<(int, string, string)> getRecursos()
        {
            List<(int, string, string)> lista = new List<(int, string, string)>();
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT id, nombre, link FROM tRecurso WHERE curso=" + this.id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lista.Add(((int)rdr[0], (string)rdr[1], (string)rdr[2]));
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al acceder a los recursos del curso.");
                ventana.ShowDialog();
            }
            return lista;
        }

        public List<(int, string)> getForos()
        {
            List<(int, string)> lista = new List<(int, string)>();
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT id, nombre FROM tForo WHERE curso = '" + this.id + "';";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lista.Add(((int)rdr[0], (string)rdr[1]));
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al acceder a los foros del curso.");
                ventana.ShowDialog();
            }
            return lista;
        }

        public List<Usuario> getUsuarios(string filtro)
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT usuario FROM tCursoUsuario WHERE curso = '" + this.id + "';";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Usuario u = new Usuario((int)rdr[0]);
                    if (u.Nombre.ToUpper().Contains(filtro.ToUpper())) { lista.Add(u); }
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al acceder a los usuarios del curso.");
                ventana.ShowDialog();
            }
            return lista;
        }

        public List<Usuario> getPeticiones(string filtro)
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT usuario FROM tInscripcion WHERE curso = '" + this.id + "';";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Usuario u = new Usuario((int)rdr[0]);
                    if (u.Nombre.ToUpper().Contains(filtro.ToUpper())) { lista.Add(u); }
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al acceder a las peticiones del curso.");
                ventana.ShowDialog();
            }
            return lista;
        }

        public void valorar(int nota, string comentario)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tValoracion (curso, nota, comentario) VALUES('"
                    + id + "', '" + nota + "', '" + comentario + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al intentar valorar el curso.");
                ventana.ShowDialog();
            }
        }

    }
}
