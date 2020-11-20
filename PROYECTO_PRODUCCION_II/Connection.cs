using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PRODUCCION_II
{
    public class Connection
    {
        public SqlConnection conector;

        public Connection(string user, string pass)
        {
            try
            {
                conector = new SqlConnection($"SERVER = .; DATABASE = db_mantenimiento; UID = {user}; PWD = {pass}");
                conector.Open();
            }
            catch (Exception)
            {
               
            }

        }

        //Carga los datos a partir de un procedimiento hacía una tabla
        /*public DataTable CargarProcedimiento(string sp)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Connection = conector;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //Carga los datos a partir de una consulta hacía una tabla
        public DataTable CargarConsulta(string query)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Connection = conector;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void agregar(String spAgregar, SqlParameter[] campos)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = spAgregar;
                cmd.Connection = conector;
                cmd.Parameters.AddRange(campos);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);

                MessageBox.Show("Guardado Exitoso. ", "PROYECTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar. \n" + e.Message, "PROYECTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

        }

        public void editar(string spEditar, SqlParameter[] campos)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = spEditar;
                cmd.Connection = conector;
                cmd.Parameters.AddRange(campos);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                MessageBox.Show("Edicion Exitosa. ", "PROYECTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la edicion. \n" + e.Message, "PROYECTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
        }

        public void eliminar(string spEliminar, SqlParameter[] campo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = spEliminar;
                cmd.Connection = conector;
                cmd.Parameters.AddRange(campo);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);

                MessageBox.Show("Borrado Exitoso. ", "PROYECTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al eliminar. \n" + e.Message, "PROYECTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
        }*/

    }
}
