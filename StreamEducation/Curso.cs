using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamEducation
{
    class Curso
    {
        private static string CONNECTION = Properties.Settings.Default.COMPLETE;
        
        private int id;
        private Usuario profesor;
        private string nombre;
        private string descripcion;

        public Curso(int i)
        {

            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT * FROM tCurso WHERE id = " + i + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    id = (int)rdr[0];
                    profesor = new Usuario((int)rdr[1]);
                    nombre = (string)rdr[2];
                    descripcion = (string)rdr[3];
                }

            }
            catch
            {
                throw new Error("Error recuperando curso con su id");
            }

        }
        public Curso( Usuario p, string n, string d)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tCurso (profesor,nombre,descripcion) VALUES(" + p.Id + ", '"
                    + n + "', '" + d + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();

                string query2 = "SELECT MAX(id) FROM tCurso WHERE profesor = '" + p.Id +"';";
                MySqlCommand cmd2 = new MySqlCommand(query2, miBD);
                id = (int)cmd2.ExecuteScalar();
                profesor = p;
                nombre = n;
                descripcion = d;

            }
            catch
            {
                throw new Error("Error al crear curso");
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
    }
}
