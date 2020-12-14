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
                fError ventana = new fError("Error al cargar de BD.");
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
                fError ventana = new fError("Error al cargar de BD.");
                ventana.ShowDialog();
            }
        }
        public List<Debate> getDebates()
        {
            List<Debate> lista = new List<Debate>();

            MySqlConnection miBD = new MySqlConnection(CONNECTION);
            miBD.Open();
            string query = "SELECT ID FROM tDebate WHERE FORO=" + this.id + ";";
            MySqlCommand cmd = new MySqlCommand(query, miBD);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                int c = (int)rdr[0];
                lista.Add(new Debate(c));
            }
            rdr.Close();
            miBD.Close();

            return lista;
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

    }
}