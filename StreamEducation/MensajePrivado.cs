using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamEducation
{
    public class MensajePrivado
    {
        private static string CONNECTION = Properties.Settings.Default.COMPLETE;

        private int id;
        private Usuario emisor;
        private Usuario receptor;
        private string fecha;
        private string asunto;
        private string mensaje;

        public MensajePrivado(int miId)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT * FROM tMensajePrivado WHERE id = " + miId + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    id = (int)rdr[0];
                    emisor = new Usuario((int)rdr[1]);
                    receptor = new Usuario((int)rdr[2]);
                    fecha = (string)rdr[3];
                    asunto = (string)rdr[4];
                    mensaje = (string)rdr[5];
                }
                rdr.Close();
                miBD.Close();

            }
            catch
            {
                fError ventana = new fError("Error recuperando mensaje privado con su id: " + miId);
                ventana.ShowDialog();
            }
        }

        public MensajePrivado(Usuario miEmisor, Usuario miReceptor, string miAsunto, string miMensaje)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                DateTime now = DateTime.Now;
                string sqldate = now.ToString("dd-MM-yyyy, HH:mm");
                string query = "INSERT INTO tMensajePrivado (emisor, receptor, fecha, asunto, mensaje) VALUES("
                    + miEmisor.Id + ", '" + miReceptor.Id + "', '" + sqldate + "', '" + asunto + "', '" + mensaje + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();

                string query2 = "SELECT MAX(id) FROM tMensajePrivado WHERE emisor = '" + miEmisor.Id + "';";
                MySqlCommand cmd2 = new MySqlCommand(query2, miBD);
                id = (int)cmd2.ExecuteScalar();
                emisor = miEmisor;
                receptor = miReceptor;
                fecha = sqldate;
                asunto = miAsunto;
                mensaje = miMensaje;
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al crear mensaje privado");
                ventana.ShowDialog();
            }

        }

        public int Id
        {
            get { return id; }
        }

        public Usuario Emisor
        {
            get { return emisor; }
        }

        public Usuario Receptor
        {
            get { return receptor; }
        }

        public string Fecha
        {
            get { return fecha; }
        }

        public string Asunto
        {
            get { return asunto; }
        }

        public string Mensaje
        {
            get { return mensaje; }
        }

        public override string ToString()
        {
            return "Enviado por: " + emisor + "   Asunto: " + asunto;
        }

        public void Borrar()
        {
            MySqlConnection miBD = new MySqlConnection(CONNECTION);
            miBD.Open();
            string query = "DELETE FROM tMensajePrivado WHERE id = " + id + ";";
            MySqlCommand cmd = new MySqlCommand(query, miBD);
            cmd.ExecuteNonQuery();
            miBD.Close();
            id = -1;
            emisor = null;
            receptor = null;
            fecha = null;
            asunto = null;
            mensaje = null;
        }

    }
}
