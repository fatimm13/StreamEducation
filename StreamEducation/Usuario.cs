using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamEducation
{
    class Usuario
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

        public Usuario(string c, string p)
        {

            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT * FROM tUsuario WHERE correo = '" + c + "';";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    correo = (string)rdr[2];
                    string password = (string)rdr[3];
                    if (!password.Equals(p))
                    {
                        correo = password = null;
                        throw new Error("Correo o Contraseña Incorrecta: ");
                    }
                    id = (int)rdr[0];
                    nombre = (string)rdr[1];
                    biografia = (string)rdr[4];
                    escuela = (string)rdr[5];
                    pais = (string)rdr[6];
                    rolProfesor = (bool)rdr[7];
                    rolAdmin = (bool)rdr[7];
                }
            }
            catch
            {
                throw new Error("Usuario o Contraseña Incorrecta: ");
            }

        }
        public Usuario(string n, string c, string p)
        {

            MySqlConnection miBD = new MySqlConnection(CONNECTION);
            miBD.Open();
            string query = "INSERT INTO tUsuario (nombre,correo,contrasena) VALUES('" + n + "', '"
                + c + "', '" + p + "');";
            MySqlCommand cmd = new MySqlCommand(query, miBD);
            cmd.ExecuteNonQuery();
            nombre = n;
            correo = c;

        }


        /*
        public int Id
        {
            get { return id; }
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME,USER,PASSWORD);
                miBD.Update("UPDATE tUsuario SET nombre = '" + value
                        + "' WHERE id = " + id + ";");
                nombre = value;
            }
        }
        public string Correo
        {
            get { return correo; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME, USER, PASSWORD);
                miBD.Update("UPDATE tUsuario SET correo = '" + value
                        + "' WHERE id = " + id + ";");
                correo = value;
            }
        }
        public string Biografia
        {
            get { return biografia; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME, USER, PASSWORD);
                miBD.Update("UPDATE tUsuario SET biografia = '" + value
                        + "' WHERE id = " + id + ";");
                correo = value;
            }
        }
        public string Escuela
        {
            get { return escuela; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME, USER, PASSWORD);
                miBD.Update("UPDATE tUsuario SET escuela = '" + value
                        + "' WHERE id = " + id + ";");
                escuela = value;
            }
        }
        public string Pais
        {
            get { return pais; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME, USER, PASSWORD);
                miBD.Update("UPDATE tUsuario SET pais = '" + value
                        + "' WHERE id = " + id + ";");
                pais = value;
            }
        }

        */

    }

}
