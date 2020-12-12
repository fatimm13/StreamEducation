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

            }
            catch
            {
                throw new Error("Recurso Incorrecto: ");
            }

        }
        public Recurso(Curso miCurso, string miNombre, string miLink)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tRecurso (curso,nombre,link) VALUES(" + miCurso.Id + ", '"
                    + miNombre + "', '" + miLink + "');";
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
                throw new Error("Error al crear recurso");
            }

        }

        public int Id
        {
            get { return id; }
        }
        public Curso Curso
        {
            get { return Curso; }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();

                string query = "UPDATE tRecurso SET nombre = '" + value
                        + "' WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                miBD.Close();
                nombre = value;
            }
        }

        public string Link
        {
            get { return link; }
            set
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();

                string query = "UPDATE tRecurso SET link = '" + value
                        + "' WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                miBD.Close();
                link = value;
            }
        }

    }
}
