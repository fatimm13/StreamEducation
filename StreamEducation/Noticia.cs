using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamEducation
{
    public class Noticia
    {

        private static string CONNECTION = Properties.Settings.Default.COMPLETE;

        private int id;
        private string nombre;
        private string descripcion;

        public Noticia(int miId)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT * FROM tDebate WHERE id = " + miId + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    id = (int)rdr[0];
                    nombre = (string)rdr[1];
                    descripcion = (string)rdr[4];
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error recuperando noticia de la BD.");
                ventana.ShowDialog();
            }
        }
        public Noticia(string miNombre, string miDescripcion)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tDebate (nombre, foro, creador, descripcion) VALUES ('" + miNombre + "', '0', '0', '" + miDescripcion + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                query = "SELECT max(ID) FROM tDebate WHERE creador = '0';";
                cmd = new MySqlCommand(query, miBD);
                int id = (int)cmd.ExecuteScalar();
                nombre = miNombre;
                descripcion = miDescripcion;
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al crear una noticia nueva.");
                ventana.ShowDialog();
            }
        }

        public int Id
        {
            get { return id; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Descripcion
        {
            get { return descripcion; }
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
                string query = "DELETE FROM tDebate WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                miBD.Close();
                id = -1;
                nombre = null;
                descripcion = null;
            }
            catch
            {
                fError ventana = new fError("Error al intentar borrar la noticia.");
                ventana.ShowDialog();
            }
        }

        public static List<(int, string)> getNoticias()
        {
            List<(int, string)> lista = new List<(int, string)>();
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT id, nombre FROM tDebate WHERE FORO = 0 ;";
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
                fError ventana = new fError("Error al acceder a las noticias.");
                ventana.ShowDialog();
            }
            return lista;
        }

        public List<(int, string)> getMensajes()
        {
            List<(int, string)> lista = new List<(int, string)>();
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT id, creador, nombre, fecha FROM tMensaje WHERE debate=" + this.id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string escribir = "Mensaje de: " + Usuario.getNombre((int)rdr[1]) + " \t Titulo: " + ((string)rdr[2])
                        + " \t Enviado el " + ((string)rdr[3]);
                    lista.Add(((int)rdr[0], escribir));
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al acceder a los mensajes de la noticia.");
                ventana.ShowDialog();
            }
            return lista;
        }

    }
}
