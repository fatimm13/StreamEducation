﻿using MySql.Data.MySqlClient;
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
        private DateTime fecha;
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
                    fecha = new DateTime((int)rdr[4]);
                    descripcion = (string)rdr[5];
                }

            }
            catch
            {
                throw new Error("Error al cargar de BD.");
            }
        }
        public Debate(string miNombre, string miDescripcion, Usuario miCreador, Foro miForo)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                DateTime now = DateTime.Now;
                string sqldate = now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string query = "INSERT INTO tDebate VALUES ('" + miNombre+ "'," + miForo.Id + "," + miCreador.Id + ",'" + sqldate + "','" + miDescripcion + "';";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                query = "SELECT max(ID) FROM tDebate WHERE creador=" + miCreador.Id + ";";
                cmd = new MySqlCommand(query, miBD);
                int id = (int) cmd.ExecuteScalar();
                nombre = miNombre;
                foro = miForo;
                creador = miCreador;
                fecha = now;
                descripcion = miDescripcion;

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

        public Foro Foro
        {
            get { return foro; }
        }

        public Usuario Creador
        {
            get { return creador; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
        }
        public string Descripcion
        {
            get { return descripcion; }
        }
    }
    
}
