using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamEducation
{
    public class Usuario
    {
        private static string CONNECTION = Properties.Settings.Default.COMPLETE;

        private int id;
        private string nombre;
        private string correo;
        private string biografia;
        private string escuela;
        private string pais;

        private bool rolProfesor;
        private bool rolAdmin;

        public Usuario(int miId)
        {

            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT * FROM tUsuario WHERE id = " + miId + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    id = miId;
                    nombre = (string)rdr[1];
                    correo = (string)rdr[2];
                    biografia = (string)rdr[4];
                    escuela = (string)rdr[5];
                    pais = (string)rdr[6];
                    rolProfesor = (int)rdr[7] == 1;
                    rolAdmin = (int)rdr[8] == 1;
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                throw new Error("Error al buscar usuario por id");
            }

        }

        public Usuario(string miCorreo, string miContrasena)
        {

            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT * FROM tUsuario WHERE correo = '" + miCorreo + "';";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    correo = (string)rdr[2];
                    string password = (string)rdr[3];
                    if (!password.Equals(miContrasena))
                    {
                        correo = password = null;
                        throw new Error("Correo o Contraseña Incorrecta: ");
                    }
                    id = (int)rdr[0];
                    nombre = (string)rdr[1];
                    biografia = (string)rdr[4];
                    escuela = (string)rdr[5];
                    pais = (string)rdr[6];
                    rolProfesor = (int)rdr[7] == 1;
                    rolAdmin = (int)rdr[8] == 1;
                }
                else
                {
                    id = -1;
                }
                miBD.Close();
            }
            catch
            {
                throw new Error("Error al iniciar sesion.");
            }

        }

        public Usuario(string miNombre, string miCorreo, string miContrasena)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tUsuario (nombre,correo,contrasena) VALUES('" + miNombre + "', '"
                    + miCorreo + "', '" + miContrasena + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                string query2 = "SELECT MAX(id) FROM tUsuario WHERE correo = '" + miCorreo + "';";
                MySqlCommand cmd2 = new MySqlCommand(query2, miBD);
                id = (int)cmd2.ExecuteScalar();
                nombre = miNombre;
                correo = miCorreo;
                miBD.Close();
                
            }
            catch
            {
                throw new Error("Error al crear cuenta");
            }

        }

        public int Id
        {
            get { return id; }
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();

                string query = "UPDATE tUsuario SET nombre = '" + value
                        + "' WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                nombre = value;
                miBD.Close();
            }
        }
        public string Correo
        {
            get { return correo; }
            set
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "UPDATE tUsuario SET correo = '" + value
                        + "' WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                correo = value;
                miBD.Close();
            }
        }
        public string Biografia
        {
            get { return biografia; }
            set
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "UPDATE tUsuario SET biografia = '" + value
                        + "' WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                biografia = value;
                miBD.Close();
            }
        }
        public string Escuela
        {
            get { return escuela; }
            set
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "UPDATE tUsuario SET escuela = '" + value
                        + "' WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                escuela = value;
                miBD.Close();
            }
        }
        public string Pais
        {
            get { return pais; }
            set
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "UPDATE tUsuario SET pais = '" + value
                        + "' WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                pais = value;
                miBD.Close();
            }
        }


        public bool RolProfesor
        {
            get { return rolProfesor; }
            /*
            set
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "UPDATE tUsuario SET rolProfesor = " + value
                        + " WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                rolProfesor = value;
                miBD.Close();
            }
            */
        }

        public bool RolAdmin
        {
            get { return rolAdmin; }
            /*
            set
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "UPDATE tUsuario SET rolAdmin = " + value
                        + " WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                rolProfesor = value;
                miBD.Close();
            }
            */
        }
        public void Borrar()
        {
            MySqlConnection miBD = new MySqlConnection(CONNECTION);
            miBD.Open();
            string query = "DELETE FROM tUsuario WHERE id = " + id + ";";
            MySqlCommand cmd = new MySqlCommand(query, miBD);
            cmd.ExecuteNonQuery();
            id = -1;
            nombre = null;
            correo = null;
            biografia = null;
            escuela = null;
            pais = null;
            rolProfesor = false;
            rolAdmin = false;
            miBD.Close();
        }

        public List<Curso> getCursos()
        {
            List<Curso> lista = new List<Curso>();

            MySqlConnection miBD = new MySqlConnection(CONNECTION);
            miBD.Open();
            string query = "SELECT curso FROM tCursoUsuario WHERE usuario = '" + this.id + "';";
            MySqlCommand cmd = new MySqlCommand(query, miBD);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                int c = (int)rdr[0];
                lista.Add(new Curso(c));
            }
            rdr.Close();
            miBD.Close();
            return lista;
        }
        public override string ToString()
        {
            return nombre;
        }
    }

}
