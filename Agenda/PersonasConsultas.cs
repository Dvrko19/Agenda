using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Agenda
{
    public class PersonasConsultas
    {
        private ConexionMysql conexionMySql;
        private Persona mPersona;
        private List<Persona> mPersonas;

        public PersonasConsultas()
        {
            conexionMySql = new ConexionMysql();
            mPersonas = new List<Persona>();
            mPersona = new Persona();
        }

        public List<Persona> getPersonas(object filtro)
        {
            string QUERY = "SELECT * FROM personas ";
            MySqlDataReader mReader = null;
            try
            {
                if (filtro != "")
                {
                    QUERY += " WHERE " +
                        "id LIKE '%" + filtro + "%' OR " +
                        "nombre LIKE '%" + filtro + "%' OR " +
                        "email LIKE '%" + filtro + "%' OR " +
                        "phone LIKE '%" + filtro + "%' OR " +
                        "city LIKE '%" + filtro + "%';";
                }
                MySqlCommand mComando = new MySqlCommand(QUERY);
                mComando.Connection = conexionMySql.GetConnection();
                mReader = mComando.ExecuteReader();
                Persona mPersona = null;
                while (mReader.Read())
                {
                    mPersona = new Persona();
                    mPersona.id = mReader.GetInt32("id");
                    mPersona.nombre = mReader.GetString("nombre");
                    mPersona.email = mReader.GetString("email");
                    mPersona.phone = mReader.GetString("phone");
                    mPersona.city = mReader.GetString("city");
                    mPersona.Birth = mReader.GetString("birth");
                    mPersona.Gen = mReader.GetString("Gen");
                    mPersonas.Add(mPersona); 

                }
                mReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return mPersonas;
        }

        internal bool AgregarPersona(Persona mPersona)
        {
            String INSERT = "INSERT INTO personas (nombre, email, phone, city, birth, gen) values (@nombre, @email, @phone, @city, @birth, @gen);"; 
            MySqlCommand mCommmand = new MySqlCommand(INSERT, conexionMySql.GetConnection());

            mCommmand.Parameters.Add(new MySqlParameter("@nombre", mPersona.nombre));
            mCommmand.Parameters.Add(new MySqlParameter("@email", mPersona.email));
            mCommmand.Parameters.Add(new MySqlParameter("@phone", mPersona.phone));
            mCommmand.Parameters.Add(new MySqlParameter("@city", mPersona.city));
            mCommmand.Parameters.Add(new MySqlParameter("@birth", mPersona.Birth));
            mCommmand.Parameters.Add(new MySqlParameter("@gen", mPersona.Gen));

            return mCommmand.ExecuteNonQuery() > 0;
        }

        internal bool EliminarProducto(Persona mPersona)
        {
            String DELETE = "DELETE FROM personas WHERE id=@id;";
            MySqlCommand mCommmand = new MySqlCommand(DELETE, conexionMySql.GetConnection());

            mCommmand.Parameters.Add(new MySqlParameter("@id", mPersona.id));
         


            return mCommmand.ExecuteNonQuery() > 0;
        }

        internal bool ModificarPersona(Persona mPersona)
        {
            String UPDATE = "UPDATE personas SET " +
                    "nombre = @nombre, " +
                    "email = @email, " +
                    "phone = @phone, " +
                    "city = @city, " +
                    "birth= @birth, "+
                    "gen = @gen "+
                    "WHERE id = @id;";
            MySqlCommand mCommmand = new MySqlCommand(UPDATE, conexionMySql.GetConnection());

            mCommmand.Parameters.Add(new MySqlParameter("@nombre", mPersona.nombre));
            mCommmand.Parameters.Add(new MySqlParameter("@email", mPersona.email));
            mCommmand.Parameters.Add(new MySqlParameter("@phone", mPersona.phone));
            mCommmand.Parameters.Add(new MySqlParameter("@city", mPersona.city));
            mCommmand.Parameters.Add(new MySqlParameter("@id", mPersona.id));
            mCommmand.Parameters.Add(new MySqlParameter("@birth", mPersona.Birth));
            mCommmand.Parameters.Add(new MySqlParameter("@gen", mPersona.Gen));


            return mCommmand.ExecuteNonQuery() > 0;

        }
    }
}
