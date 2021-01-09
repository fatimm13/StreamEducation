using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamEducation
{
    public class Recurso
    {

        private static string CONNECTION = Properties.Settings.Default.COMPLETE;

        private int id;
        private Curso curso;
        private string nombre;
        private string link;

        public Recurso(int miId)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT * FROM tRecurso WHERE id = " + miId + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    id = (int)rdr[0];
                    curso = new Curso((int)rdr[1]);
                    nombre = (string)rdr[2];
                    link = (string)rdr[3];
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error recuperando recurso de la BD.");
                ventana.ShowDialog();
            }

        }
        public Recurso(Curso miCurso, string miNombre, string miLink)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tRecurso (curso,nombre,link) VALUES("
                    + miCurso.Id + ", '" + miNombre + "', '" + miLink + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();

                string query2 = "SELECT MAX(id) FROM tRecurso WHERE curso= '" +miCurso.Id +"';";
                MySqlCommand cmd2 = new MySqlCommand(query2, miBD);
                id = (int) cmd2.ExecuteScalar();
                curso = miCurso;
                nombre = miNombre;
                link = miLink;
            }
            catch
            {
                fError ventana = new fError("Error al crear un recurso nuevo.");
                ventana.ShowDialog();
            }
        }

        public int Id
        {
            get { return id; }
        }

        public Curso Curso
        {
            get { return curso; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Link
        {
            get { return link; }
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
                string query = "DELETE FROM tRecurso WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                miBD.Close();
                id = -1;
                curso = null;
                nombre = null;
                link = null;
            }
            catch
            {
                fError ventana = new fError("Error al intentar borrar el recurso.");
                ventana.ShowDialog();
            }
        }

    }
}
