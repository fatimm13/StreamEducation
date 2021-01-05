using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamEducation
{
    public class RecursoActividad
    {
        private static string CONNECTION = Properties.Settings.Default.COMPLETE;

        private int id;
        private Actividad actividad;
        private string nombre;
        private string link;

        public RecursoActividad(int miId)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT * FROM tRecursoActividad WHERE id = " + miId + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    id = (int)rdr[0];
                    actividad = new Actividad((int)rdr[1]);
                    nombre = (string)rdr[2];
                    link = (string)rdr[3];
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error recuperando recurso actividad de la BD.");
                ventana.ShowDialog();
            }
        }

        public RecursoActividad(Actividad miActividad, string miNombre, string miLink)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tRecursoActividad (actividad,nombre,link) VALUES(" + miActividad.Id + ", '"
                    + miNombre + "', '" + miLink + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();

                string query2 = "SELECT MAX(id) FROM tRecursoActividad WHERE actividad= '" + miActividad.Id + "';";
                MySqlCommand cmd2 = new MySqlCommand(query2, miBD);
                id = (int)cmd2.ExecuteScalar();
                actividad = miActividad;
                nombre = miNombre;
                link = miLink;
            }
            catch
            {
                fError ventana = new fError("Error al crear un recurso actividad nuevo.");
                ventana.ShowDialog();
            }
        }

        public int Id
        {
            get { return id; }
        }

        public Actividad Actividad
        {
            get { return actividad; }
        }

        public string Nombre
        {
            get { return nombre; }
            /*
            set
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();

                string query = "UPDATE tRecursoActividad SET nombre = '" + value
                        + "' WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                miBD.Close();
                nombre = value;
            }
            */
        }

        public string Link
        {
            get { return link; }
            /*
            set
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();

                string query = "UPDATE tRecursoActividad SET link = '" + value
                        + "' WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                miBD.Close();
                link = value;
            }
            */
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
                string query = "DELETE FROM tRecursoActividad WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                miBD.Close();
                id = -1;
                actividad = null;
                nombre = null;
                link = null;
            }
            catch
            {
                fError ventana = new fError("Error al intentar borrar el recurso actividad.");
                ventana.ShowDialog();
            }
        }

    }
}
