using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
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
                fError ventana = new fError("Error recuperando actividad de la BD.");
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
                fError ventana = new fError("Error al crear una actividad nueva.");
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
            catch
            {
                fError ventana = new fError("Error al intentar borrar la actividad.");
                ventana.ShowDialog();
            }
        }

        public static List<(int, string)> listaActividades()
        {
            List<(int, string)> lista = new List<(int, string)>();
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT id, nombre FROM tActividad;";
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
                fError ventana = new fError("Error al acceder a las actividades disponibles.");
                ventana.ShowDialog();
            }
            return lista;
        }

        public static List<string> listaActividadesFecha(string fecha)
        {
            List<string> lista = new List<string>();
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT nombre FROM tActividad where fecha LIKE '" + fecha + "';";
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
                fError ventana = new fError("Error al acceder a las actividades disponibles.");
                ventana.ShowDialog();
            }
            return lista;
        }

        public static List<(DateTime, string)> actividadesCalendario()
        {
            List<(DateTime, string)> lista = new List<(DateTime, string)>();
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT nombre,fecha FROM tActividad ;";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();
                CultureInfo ci = CultureInfo.CreateSpecificCulture("es-ES");
                while (rdr.Read())
                {

                    (DateTime, string) p = (DateTime.Parse((string)rdr[1], ci), (string)rdr[0]);
                    lista.Add(p);
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al acceder a las actividades disponibles.");
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
                string query = "SELECT id, nombre, link FROM tRecursoActividad WHERE actividad=" + this.id + ";";
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
                fError ventana = new fError("Error al acceder a los recursos de la actividad.");
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
                string query = "INSERT INTO tValoracionActividad (actividad, nota, comentario) VALUES('"
                    + id + "', '" + nota + "', '" + comentario + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al intentar valorar la actividad.");
                ventana.ShowDialog();
            }
        }
        
    }
}
