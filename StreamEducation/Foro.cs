using MySql.Data.MySqlClient;

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
        public Foro(int id)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "SELECT * FROM tForo WHERE id = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    this.id = id;
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
        public Foro(string n, string d, Usuario cr, Curso cur)
        {
            try
            {
                MySqlConnection miBD = new MySqlConnection(CONNECTION);
                miBD.Open();
                string query = "INSERT INTO tForo VALUES ('" + n + "'," + d + "," + cr.Id + "," + cur.Id + ";";
                MySqlCommand cmd = new MySqlCommand(query, miBD);
                cmd.ExecuteNonQuery();
                query = "SELECT max(ID) FROM tForo WHERE creador="+cr.Id+";";
                cmd = new MySqlCommand(query, miBD);
                int id = (int)cmd.ExecuteScalar();
                nombre = n;
                descripcion = d;
                creador = cr;
                curso = cur;

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