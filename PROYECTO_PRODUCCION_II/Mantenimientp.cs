using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_PRODUCCION_II
{
    class Mantenimiento
    {
        Connection c;
        
        public DataTable cargarUsuario()
        {
            c = new Connection("usuario", "01234567");
            SqlCommand cmd = new SqlCommand(
            "Select e.Nombre as [Nombre del equipo], m.Nombre as [Tipo de Mantenimiento],"
                              + " om.FechaRegistro, om.Costo, om.Descripcion as [Fecha Registro] from"
                              + " OrdenMantenimiento om"
                              + " inner join FalloEquipoMto fem"
                              + " on fem.ID_FalloEqMto = om.ID_FalloEqMto"
                              + " inner join Mantenimiento m"
                              + " on m.ID_Mantenimiento = fem.ID_Mantenimiento"
                              + " inner join FalloEquipo fe"
                              + " on fe.ID_FalloEquipo = fem.ID_FalloEquipo"
                              + " inner join Fallo f"
                              + " on f.ID_Fallo = fe.ID_Fallo"
                              + " inner join Equipo e"
                              + " on e.ID_Equipo = fe.ID_Equipo", c.conector);

            SqlDataAdapter sqa = new SqlDataAdapter();
            sqa.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sqa.Fill(dt);

            return dt;
        }
    }
}
