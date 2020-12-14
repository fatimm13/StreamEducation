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
                }
                rdr.Close();
                miBD.Close();

            }
            catch
            {
                fError ventana = new fError("Error recuperando curso con su id: " +miId);
                ventana.ShowDialog();
            }

        }
        public Curso( Usuario miProfesor, string miNombre, string miDescripcion)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tCurso (profesor,nombre,descripcion) VALUES(" + miProfesor.Id + ", '"
                    + miNombre + "', '" + miDescripcion + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();

                string query2 = "SELECT MAX(id) FROM tCurso WHERE profesor = '" + miProfesor.Id +"';";
                MySqlCommand cmd2 = new MySqlCommand(query2, miBD);
                id = (int)cmd2.ExecuteScalar();
                profesor = miProfesor;
                nombre = miNombre;
                descripcion = miDescripcion;
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al crear curso");
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
            set
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "UPDATE tCurso SET profesor = '" + value.Id
                        + "' WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                profesor = value;
                miBD.Close();
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "UPDATE tCurso SET nombre = '" + value
                        + "' WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                nombre = value;

                miBD.Close();
            }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "UPDATE tCurso SET descripcion = '" + value
                        + "' WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                descripcion = value;
                miBD.Close();
            }
        }

        public bool Publico
        {
            get { return esPublico; }
        }

        public static List<Curso> listaCursos()
        {
            List<Curso> lista = new List<Curso>();

            MySqlConnection miBD = new MySqlConnection(CONNECTION);
            miBD.Open();
            string query = "SELECT ID FROM tCurso;";
            MySqlCommand cmd = new MySqlCommand(query, miBD);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                int c = (int)rdr[0];
                lista.Add(new Curso(c));
            }
            rdr.Close();
            miBD.Close();
            return lista;
        }
        public List<Recurso> getRecursos()
        {
            List<Recurso> lista = new List<Recurso>();

            MySqlConnection miBD = new MySqlConnection(CONNECTION);
            miBD.Open();
            string query = "SELECT ID FROM tRecurso WHERE CURSO="+this.id+";";
            MySqlCommand cmd = new MySqlCommand(query, miBD);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                int c = (int)rdr[0];
                lista.Add(new Recurso(c));
            }
            rdr.Close();
            miBD.Close();
            return lista;
        }
        public List<Foro> getForos()
        {
            List<Foro> lista = new List<Foro>();

            MySqlConnection miBD = new MySqlConnection(CONNECTION);
            miBD.Open();
            string query = "SELECT ID FROM tForo WHERE CURSO=" + this.id + ";";
            MySqlCommand cmd = new MySqlCommand(query, miBD);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                int c = (int)rdr[0];
                lista.Add(new Foro(c));
            }
            rdr.Close();
            miBD.Close();
            return lista;
        }
        public override string ToString()
        {

            return nombre;
        }

        public void Borrar()
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
        }

    }
}
