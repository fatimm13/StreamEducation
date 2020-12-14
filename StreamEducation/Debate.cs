using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamEducation
{
    public class Debate
    {
        private static string CONNECTION = Properties.Settings.Default.COMPLETE;

        private int id;
        private string nombre;
        private Foro foro;
        private Usuario creador;
        private string descripcion;

        public Debate(int miId)
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
                    foro = new Foro((int)rdr[2]);
                    creador = new Usuario((int)rdr[3]);
                    descripcion = (string)rdr[4];
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al cargar de BD.");
                ventana.ShowDialog();
            }
        }
        public Debate(string miNombre, string miDescripcion, Usuario miCreador, Foro miForo)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tDebate (nombre, foro, creador, descripcion) VALUES ('" + miNombre+ "','" + miForo.Id + "','" + miCreador.Id + "','" + miDescripcion + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                query = "SELECT max(ID) FROM tDebate WHERE creador=" + miCreador.Id + ";";
                cmd = new MySqlCommand(query, miBD);
                int id = (int) cmd.ExecuteScalar();
                nombre = miNombre;
                foro = miForo;
                creador = miCreador;
                descripcion = miDescripcion;

                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al cargar de BD.");
                ventana.ShowDialog();
            }
        }

        internal string  intervenciones()
        {
            MySqlConnection miBD = new MySqlConnection(CONNECTION);
            miBD.Open();
            string query = "SELECT count(*) FROM tMensaje WHERE debate=" +id + ";";
            MySqlCommand cmd = new MySqlCommand(query, miBD);

            object res = cmd.ExecuteScalar();

            miBD.Close();

            return res.ToString();
        }

        public int Id
        {
            get { return id; }
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public Foro Foro
        {
            get { return foro; }
        }

        public Usuario Creador
        {
            get { return creador; }
        }

        public string Descripcion
        {
            get { return descripcion; }
        }
        public List<Mensaje> getMensajes()
        {
            List<Mensaje> lista = new List<Mensaje>();

            MySqlConnection miBD = new MySqlConnection(CONNECTION);
            miBD.Open();
            string query = "SELECT ID FROM tMensaje WHERE debate=" + this.id + ";";
            MySqlCommand cmd = new MySqlCommand(query, miBD);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                int c = (int)rdr[0];
                lista.Add(new Mensaje(c));
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
            string query = "DELETE FROM tDebate WHERE id = " + id + ";";
            MySqlCommand cmd = new MySqlCommand(query, miBD);
            cmd.ExecuteNonQuery();
            miBD.Close();
            id = -1;
            nombre = null;
            foro = null;
            creador = null;
            descripcion = null;

        }

    }
    
}
