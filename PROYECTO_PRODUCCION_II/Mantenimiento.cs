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
    class Mantenimiento
    {
        Connection c;
        
        public DataTable cargarOrden()
        {
            c = new Connection("usuario", "01234567");
            SqlCommand cmd = new SqlCommand("CargarOrden", c.conector);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Tipo", "Predictivo"));

            SqlDataAdapter sqa = new SqlDataAdapter();
            sqa.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sqa.Fill(dt);


            return dt;
        }

        public ComboBox CargarComboBoxs(ComboBox cb, String proc, String campo)
        {
            c = new Connection("usuario", "01234567");
            SqlCommand cmd1 = new SqlCommand(proc, c.conector);
            cmd1.CommandType = CommandType.StoredProcedure;
            SqlDataReader registro = cmd1.ExecuteReader();
            while (registro.Read())
            {
                cb.Items.Add(registro[campo].ToString());
            }
            SqlDataReder.Close();
            return cb;
        }

        public ComboBox CargarPieza(ComboBox cb, String proc, String param, String campo)
        {
            c = new Connection("usuario", "01234567");
            SqlCommand cmd = new SqlCommand(proc, c.conector);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@"+param, campo);
            SqlDataReader equipo = cmd.ExecuteReader();
            while (equipo.Read())
            {
                cb.Items.Add(equipo["Nombre"].ToString());
            }

            return cb;
        }

        public ComboBox CargarFallo(ComboBox cb, String campo)
        {
            c = new Connection("usuario", "01234567");
            SqlCommand cmd = new SqlCommand("CargarFallo", c.conector);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Pieza", campo);
            SqlDataReader equipo = cmd.ExecuteReader();
            while (equipo.Read())
            {
                cb.Items.Add(equipo["Nombre"].ToString());
            }

            return cb;
        }

        public int obtenerIdEquipoMto(String fallo, String equipo, String mto)
        {
            c = new Connection("usuario", "01234567");
            SqlCommand cmd = new SqlCommand("IdMtoEquipo", c.conector);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter Fallo = new SqlParameter();
            Fallo.ParameterName = "@Fallo";
            Fallo.Value = fallo;
            cmd.Parameters.Add(Fallo);

            SqlParameter Equipo = new SqlParameter();
            Equipo.ParameterName = "@Equipo";
            Equipo.Value = equipo;
            cmd.Parameters.Add(Equipo);

            SqlParameter Mto = new SqlParameter();
            Mto.ParameterName = "@Mto";
            Mto.Value = mto;
            cmd.Parameters.Add(Mto);

            //SqlDataReader res = cmd.ExecuteReader();
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            return id;
        }

        public void RegistrarOrden(int id, float  costo, String fecha, String duracion, String desc)
        {
            c = new Connection("usuario", "01234567");
            SqlParameter[] campos = new SqlParameter[5];
            SqlCommand cmd = new SqlCommand("RegistrarOrden", c.conector);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter ID_FalloEqMto = new SqlParameter();
            ID_FalloEqMto.ParameterName = "@ID_FalloEqMto";
            ID_FalloEqMto.Value = id;
            cmd.Parameters.Add(ID_FalloEqMto);

            SqlParameter Costo = new SqlParameter();
            Costo.ParameterName = "@Costo";
            Costo.Value = costo;
            cmd.Parameters.Add(Costo);

            SqlParameter FechaRegistro = new SqlParameter();
            FechaRegistro.ParameterName = "@FechaRegistro";
            FechaRegistro.Value = fecha;
            cmd.Parameters.Add(FechaRegistro);

            SqlParameter Duracion = new SqlParameter();
            Duracion.ParameterName = "@Duracion";
            Duracion.Value = duracion;
            cmd.Parameters.Add(Duracion);

            SqlParameter Descripcion = new SqlParameter();
            Descripcion.ParameterName = "@Descripcion";
            Descripcion.Value = desc;
            cmd.Parameters.Add(Descripcion);

            /*cmd.Parameters.Add("@ID_FalloEqMto", id);
            cmd.Parameters.Add("@Costo", costo);
            cmd.Parameters.Add("@FechaRegistro", fecha);
            cmd.Parameters.Add("@Duracion", duracion);
            cmd.Parameters.Add("@Descripcion", desc);*/
            cmd.ExecuteReader();
        }

        public float obtenerCostoPieza(String nombre)
        {
            float costo = 1;
            c = new Connection("usuario", "01234567");
            Console.WriteLine(nombre);
            SqlCommand cmd = new SqlCommand("ObtenerCostoPieza", c.conector);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Nombre", nombre);
            //SqlDataReader resultado = cmd.ExecuteReader();
            //MessageBox.Show(resultado["Costo"].ToString());
            costo = float.Parse(cmd.ExecuteScalar().ToString());

            return costo;
        }

    }
}
