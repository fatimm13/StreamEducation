using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace StreamEducation
{
    public class Foro
    {

        private static string CONNECTION = Properties.Settings.Default.COMPLETE;

        private int id;
        private string nombre;
        private string descripcion;
        private Usuario creador;
        private Curso curso;

        public Foro(int miId)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT * FROM tForo WHERE id = " + miId + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    id = miId;
                    nombre = (string)rdr[1];
                    descripcion = (string)rdr[2];
                    creador = new Usuario((int)rdr[3]);
                    curso = new Curso((int) rdr[4]);
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error recuperando foro de la BD.");
                ventana.ShowDialog();
            }
        }

        public Foro(string miNombre, string miDescripcion, Usuario miCreador, Curso miCurso)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tForo (nombre, descripcion, creador, curso) VALUES ('" + miNombre + "', '" + miDescripcion + "','" + miCreador.Id + "','" + miCurso.Id + "');";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                string query2 = "SELECT max(ID) FROM tForo WHERE creador="+miCreador.Id+";";
                MySqlCommand cmd2 = new MySqlCommand(query2, miBD);
                id = (int)cmd2.ExecuteScalar(); 
                nombre = miNombre;
                descripcion = miDescripcion;
                creador = miCreador;
                curso = miCurso;
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al crear un foro nuevo.");
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
        }

        public string Descripcion
        {
            get { return descripcion; }
        }

        public Usuario Creador
        {
            get { return creador; }
        }

        public Curso Curso
        {
            get { return curso; }
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
                string query = "DELETE FROM tForo WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                miBD.Close();
                id = -1;
                nombre = null;
                descripcion = null;
                creador = null;
                curso = null;
            }
            catch
            {
                fError ventana = new fError("Error al intentar borrar el foro.");
                ventana.ShowDialog();
            }
        }

        public List<(int, string, string, string)> getDebates()
        {
            List<(int, string, string, string)> lista = new List<(int, string, string, string)>();
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT id, nombre, creador FROM tDebate WHERE FORO = '" + this.id + "';";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int miId = (int)rdr[0];
                    lista.Add((miId, (string)rdr[1], Usuario.getNombre((int)rdr[2]), Debate.NumIntervenciones(miId)));
                }
                rdr.Close();
                miBD.Close();
            }
            catch
            {
                fError ventana = new fError("Error al acceder a los debates del foro.");
                ventana.ShowDialog();
            }
            return lista;
        }

        public List<(int, string)> getNoticias()
        {
            List<(int, string)> lista = new List<(int, string)>();
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT id, nombre FROM tDebate WHERE FORO = 0 ;";
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
                fError ventana = new fError("Error al acceder a las noticias.");
                ventana.ShowDialog();
            }
            return lista;
        }

    }
}