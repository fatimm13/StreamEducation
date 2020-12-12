using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamEducation
{
    class Debate
    {
        private static string CONNECTION = Properties.Settings.Default.COMPLETE;

        private int id;
        private string nombre;
        private Foro foro;
        private Usuario creador;
        private DateTime fecha;
        private string descripcion;

        public Debate(int id)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT * FROM tDebate WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    
                    
                    this.id = (int)rdr[0];
                    nombre = (string)rdr[1];
                    foro = new Foro((int)rdr[2]);
                    creador = new Usuario((int)rdr[3]);
                    fecha = new DateTime((int)rdr[4]);
                    descripcion = (string)rdr[5];
                }

            }
            catch
            {
                throw new Error("Error al cargar de BD.");
            }
        }
        public Debate(string n, string d, Usuario cr, Foro f)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                DateTime now = DateTime.Now;
                string sqldate = now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string query = "INSERT INTO tDebate VALUES ('" + n+ "'," + f.Id + "," + cr.Id + ",'" + sqldate + "','" + d + "';";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                query = "SELECT max(ID) FROM tDebate WHERE creador=" + cr.Id + ";";
                cmd = new MySqlCommand(query, miBD);
                int id = (int) cmd.ExecuteScalar();
                nombre = n;
                foro = f;
                creador = cr;
                fecha = now;
                descripcion = d;

            }
            catch
            {
                throw new Error("Error al cargar de BD.");
            }
        }
    }
    
}
