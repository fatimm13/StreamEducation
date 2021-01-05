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
        private bool rolAsociacion;
        private bool rolAdmin;
        private int pregunta;
        private string respuesta;

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
                    rolAsociacion = (int)rdr[8] == 1;
                    rolAdmin = (int)rdr[9] == 1;
                    pregunta = (int)rdr[10];
                    respuesta = (string)rdr[11];
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error recuperando usuario de la BD.");
                ventana.ShowDialog();
            }
        }

        public Usuario(string miNombre, string miCorreo, string miContrasena, bool esProfesor, bool esAsociacion, bool esAdmin, int miPregunta, string miRespuesta)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tUsuario (nombre,correo,contrasena, rolProfesor, rolAsociacion, rolAdmin, pregunta, respuesta) VALUES('" + miNombre + "', '"
                    + miCorreo + "', '" + miContrasena + "', '" + (esProfesor ? 1 : 0) + "', '" + (esAsociacion? 1 : 0) + "', '" + (esAdmin ? 1 : 0) + "', '" + miPregunta + "', '" + miRespuesta + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                string query2 = "SELECT MAX(id) FROM tUsuario WHERE correo = '" + miCorreo + "';";
                MySqlCommand cmd2 = new MySqlCommand(query2, miBD);
                id = (int)cmd2.ExecuteScalar();
                nombre = miNombre;
                correo = miCorreo;
                rolProfesor = esProfesor;
                rolAsociacion = esAsociacion;
                rolAdmin = esAdmin;
                pregunta = miPregunta;
                respuesta = miRespuesta;
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al crear un usuario nuevo.");
                ventana.ShowDialog();
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
                try
                {
                    MySqlConnection miBD = new MySqlConnection(CONNECTION);
                    miBD.Open();
                    string query = "UPDATE tUsuario SET nombre = '" + value + "' WHERE id = " + id + ";";
                    MySqlCommand cmd = new MySqlCommand(query, miBD);
                    cmd.ExecuteNonQuery();
                    nombre = value;
                    miBD.Close();
                }
                catch
                {
                    fError ventana = new fError("Error al actualizar nombre del usuario.");
                    ventana.ShowDialog();
                }
            }
        }

        public string Correo
        {
            get { return correo; }
            /*
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
            */
        }

        public string Biografia
        {
            get { return biografia; }
            set
            {
                try
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
                catch
                {
                    fError ventana = new fError("Error al actualizar biografia del usuario.");
                    ventana.ShowDialog();
                }
            }
        }
        public string Escuela
        {
            get { return escuela; }
            set
            {
                try
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
                catch
                {
                    fError ventana = new fError("Error al actualizar escuela del usuario.");
                    ventana.ShowDialog();
                }
            }
        }

        public string Pais
        {
            get { return pais; }
            set
            {
                try
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
                catch
                {
                    fError ventana = new fError("Error al actualizar pais del usuario.");
                    ventana.ShowDialog();
                }
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

        public bool RolAsociacion
        {
            get { return rolAsociacion; }
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
            catch
            {
                fError ventana = new fError("Error al intentar borrar el usuario.");
                ventana.ShowDialog();
            }
        }

        public static Usuario iniciarSesion(string miCorreo, string miContrasena)
        {
            Usuario usuario = null;
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT * FROM tUsuario WHERE correo = '" + miCorreo + "';";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    string password = (string)rdr[3];
                    if (password.Equals(miContrasena))
                    {
                        usuario = new Usuario((int)rdr[0]);
                    }
                    else
                    {
                        fError ventana = new fError("La contraseña introducida es incorrecta.");
                        ventana.ShowDialog();
                    }
                }
                else
                {
                    fError ventana = new fError("El correo introducido no esta registrado.");
                    ventana.ShowDialog();
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al intentar iniciar sesion.");
                ventana.ShowDialog();
            }
            return usuario;
        }

        public static string recuperarContrasena(string miCorreo, int miPregunta, string miRespuesta)
        {
            string contrasena = null;
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT contrasena FROM tUsuario WHERE correo = '" + miCorreo + "' and pregunta ='" + miPregunta + "'and upper(respuesta) = '" + miRespuesta.ToUpper() + "';";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read()) { contrasena = (string)rdr[0]; }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al intentar recuperar la contraseña.");
                ventana.ShowDialog();
            }
            return contrasena;
        }

        public void pedirInscripcion(int curso)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tInscripcion (curso, usuario) VALUES('" + curso + "', '" + id + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al pedir la inscripcion al curso.");
                ventana.ShowDialog();
            }
        }

        public void aceptarInscripcion(int curso)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tCursoUsuario VALUES ('" + curso + "','" + id + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                query = "DELETE FROM tInscripcion WHERE curso = '" + curso + "' and usuario ='" + id + "';";
                cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al aceptar la inscripcion al curso.");
                ventana.ShowDialog();
            }
        }

        public void rechazarInscripcion(int curso)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "DELETE FROM tInscripcion WHERE curso = '" + curso + "' and usuario ='" + id + "';";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al rechazar la inscripcion al curso.");
                ventana.ShowDialog();
            }
        }

        public bool estaInscrito(int curso)
        {
            bool inscrito = false;
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT usuario FROM tCursoUsuario WHERE curso = '" + curso + "' and usuario ='" + id + "';";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read()) { inscrito = true; }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al intentar comprobar la inscripcion.");
                ventana.ShowDialog();
            }
            return inscrito;
        }

        public void expulsar(int curso)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "DELETE FROM tCursoUsuario WHERE curso = " + curso + " and usuario ='" + id + "';";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al intentar expulsar al usuario del curso.");
                ventana.ShowDialog();
            }
        }

        public List<Curso> getCursos()
        {
            List<Curso> lista = new List<Curso>();
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT curso FROM tCursoUsuario WHERE usuario = '" + this.id + "';";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int c = (int)rdr[0];
                    lista.Add(new Curso(c));
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al acceder a los cursos del usuario.");
                ventana.ShowDialog();
            }
            return lista;
        }
        
    }
}
