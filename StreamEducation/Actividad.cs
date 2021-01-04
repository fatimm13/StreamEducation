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
                fError ventana = new fError("Error recuperando actividad con su id: " + miId);
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

                string query2 = "SELECT MAX(id) FROM tActividad WHERE organizacion = '" + miOrganizacion.Id + "';";
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
                fError ventana = new fError("Error al crear actividad");
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
        public List<RecursoActividad> getRecursos()
        {
            List<RecursoActividad> lista = new List<RecursoActividad>();

            MySqlConnection miBD = new MySqlConnection(CONNECTION);
            miBD.Open();
            string query = "SELECT ID FROM tRecursoActividad WHERE Actividad=" + this.id + ";";
            MySqlCommand cmd = new MySqlCommand(query, miBD);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                int c = (int)rdr[0];
                lista.Add(new RecursoActividad(c));
            }
            rdr.Close();
            miBD.Close();
            return lista;
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
        public static List<Actividad> listaActividades()
        {
            List<Actividad> lista = new List<Actividad>();

            MySqlConnection miBD = new MySqlConnection(CONNECTION);
            miBD.Open();
            string query = "SELECT ID FROM tActividad;";
            MySqlCommand cmd = new MySqlCommand(query, miBD);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                int a = (int)rdr[0];
                lista.Add(new Actividad(a));
            }

            rdr.Close();
            miBD.Close();
            return lista;

        }
        public void valorar(int nota, string comentario)
        {
            MySqlConnection miBD = new MySqlConnection(CONNECTION);
            miBD.Open();
            string query = "INSERT INTO tValoracionActividad (actividad, nota, comentario) VALUES('"
                + id + "', '" + nota + "', '" + comentario + "');";
            MySqlCommand cmd = new MySqlCommand(query, miBD);
            cmd.ExecuteNonQuery();
            miBD.Close();
        }
        public override string ToString()
        {
            return nombre;
        }
    }
}
