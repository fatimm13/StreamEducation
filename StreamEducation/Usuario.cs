﻿using MySql.Data.MySqlClient;
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
                    rolProfesor = (bool)rdr[7];
                    rolAdmin = (bool)rdr[8];
                }

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
                    if (rdr[4] != DBNull.Value) { biografia = (string)rdr[4]; }
                    if (rdr[5] != DBNull.Value) { escuela = (string)rdr[5]; }
                    if (rdr[6] != DBNull.Value) { pais = (string)rdr[6]; }
                    rolProfesor = (int)rdr[7] == 1;
                    rolAdmin = (int)rdr[8] == 1;
                }

            }
            catch (Exception ex)
            {
                throw new Error(ex.Message);
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

    }

}
