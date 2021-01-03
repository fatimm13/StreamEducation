using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamEducation
{
    public class Actividad
    {
        private static string CONNECTION = Properties.Settings.Default.COMPLETE;

        private int id;
        private Usuario organizacion;
        private string nombre;
        private string descripcion;
        private string fecha;

        public Actividad(int miId)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT * FROM tActividad WHERE id = " + miId + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    id = (int)rdr[0];
                    organizacion = new Usuario((int)rdr[1]);
                    nombre = (string)rdr[2];
                    descripcion = (string)rdr[3];
                    fecha = (string)rdr[4];
                }
                rdr.Close();
                miBD.Close();

            }
            catch
            {
                fError ventana = new fError("Error recuperando curso con su id: " + miId);
                ventana.ShowDialog();
            }

        }
        public Actividad(Usuario miOrganizacion, string miNombre, string miDescripcion, string miFecha)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tActividad (organizacion, nombre, descripcion, fecha) VALUES('"
                    + miOrganizacion.Id + "', '" + miNombre + "', '" + miDescripcion + "', '" + miFecha + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();

                string query2 = "SELECT MAX(id) FROM tActividad WHERE profesor = '" + miOrganizacion.Id + "';";
                MySqlCommand cmd2 = new MySqlCommand(query2, miBD);
                id = (int)cmd2.ExecuteScalar();
                organizacion = miOrganizacion;
                nombre = miNombre;
                descripcion = miDescripcion;
                fecha = miFecha;
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

        public Usuario Organizacion
        {
            get { return organizacion; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Descripcion
        {
            get { return descripcion; }
        }

        public string Fecha
        {
            get { return fecha; }
        }

        public void Borrar()
        {
            MySqlConnection miBD = new MySqlConnection(CONNECTION);
            miBD.Open();
            string query = "DELETE FROM tActividad WHERE id = " + id + ";";
            MySqlCommand cmd = new MySqlCommand(query, miBD);
            cmd.ExecuteNonQuery();
            miBD.Close();
            id = -1;
            organizacion = null;
            nombre = null;
            descripcion = null;
            fecha = null;
        }

    }
}
