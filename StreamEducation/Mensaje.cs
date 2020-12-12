using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamEducation
{
    public class Mensaje
    {
        private static string CONNECTION = Properties.Settings.Default.COMPLETE;

        private int id;
        private Debate debate;
        private Usuario creador;
        private string nombre;
        private string descripcion;
        private string fecha;

        public Mensaje(int miId)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT * FROM tMensaje WHERE id = " + miId + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    id = (int)rdr[0];
                    debate = new Debate((int)rdr[1]);
                    creador = new Usuario((int)rdr[2]);
                    nombre = (string)rdr[3];
                    descripcion = (string)rdr[4];
                    fecha = (string)rdr[5];
                }
            }
            catch
            {
                throw new Error("Error al cargar de BD.");
            }
        }
        public Mensaje(string miNombre, string miDescripcion, Usuario miCreador, Debate miDebate)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                DateTime now = DateTime.Now;
                string sqldate = now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string query = "INSERT INTO tMensaje VALUES (" + miDebate.Id + "," + miCreador.Id + ", '" + miNombre + "','" + miDescripcion + "','" + sqldate + "';";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                query = "SELECT max(ID) FROM tMensaje WHERE creador=" + miCreador.Id + ";";
                cmd = new MySqlCommand(query, miBD);
                int id = (int)cmd.ExecuteScalar();
                debate = miDebate;
                creador = miCreador;
                nombre = miNombre;
                descripcion = miDescripcion;
                fecha = sqldate;
            }
            catch
            {
                throw new Error("Error al cargar de BD.");
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

        public Debate Debate
        {
            get { return debate; }
        }

        public Usuario Creador
        {
            get { return creador; }
        }

        public string Fecha
        {
            get { return fecha; }
        }
        public string Descripcion
        {
            get { return descripcion; }
        }
        public override string ToString()
        {
            string s = "Mensaje de: " + creador.ToString() + "    Enviado el "+fecha+" \n Titulo:"+nombre+"\n \n Mensaje:"+descripcion;
            return s;
        }
    }

}
