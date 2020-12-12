﻿using MySql.Data.MySqlClient;

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

            }
            catch
            {
                throw new Error("Error al cargar de BD.");
            }
        }
        public Foro(string miNombre, string miDescripcion, Usuario miCreador, Curso miCurso)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tForo VALUES ('" + miNombre + "'," + miDescripcion + "," + miCreador.Id + "," + miCurso.Id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                query = "SELECT max(ID) FROM tForo WHERE creador="+miCreador.Id+";";
                cmd = new MySqlCommand(query, miBD);
                //TODO: este int se puso a proposito?
                id = (int)cmd.ExecuteScalar(); 
                nombre = miNombre;
                descripcion = miDescripcion;
                creador = miCreador;
                curso = miCurso;

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
    }
}